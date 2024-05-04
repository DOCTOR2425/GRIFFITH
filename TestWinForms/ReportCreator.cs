using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace TestWinForms
{
    public class ReportCreator// TODO Сделать розочке максимальное значение
    {
        public static string FileTeplate { get { return "Template.docx"; } }

        public static void GenerateContract(Dictionary<string, string> pairsToChange)
        {
            if (File.Exists(FileTeplate) == false)
            {
                MessageBox.Show("Не удалось найти шаблон файла для составления договора", "Ошибка файла",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newFile = GetValidFile(pairsToChange["<client>"] + " " + pairsToChange["<service>"]);

            AddEndDate(pairsToChange);
            MessageBox.Show(pairsToChange["<day2>"]);

            var wordApp = new Word.Application();

            try
            {
                File.Copy(FileTeplate, newFile);
                wordApp.Documents.Open(newFile);
                object mis = Type.Missing;

                Word.Find find = wordApp.Selection.Find;

                for (int i = 0; i < pairsToChange.Count; i++)
                {
                    find.Text = pairsToChange.ElementAt(i).Key;
                    find.Replacement.Text = pairsToChange.ElementAt(i).Value;

                    object wrap = Word.WdFindWrap.wdFindContinue;
                    object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: mis, MatchSoundsLike: mis, Forward: true,
                        Wrap: wrap, ReplaceWith: mis, Replace: replace);
                }

                wordApp.Visible = true;
                wordApp.ActiveDocument.Save();
            }
            catch (COMException ex)
            {
                MessageBox.Show("Для составления договора закройте шаблон",
                    "Ошибка файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string GetValidFile(string name)
        {
            name = Environment.CurrentDirectory + "\\" + name + ".docx";
            if (File.Exists(name) == false)
                return name;

            int number = 2;
            string newName = name.Insert(name.Length - 5, number.ToString());
            while (File.Exists(newName))
            {
                number++;
                newName = name.Insert(name.Length - 5, number.ToString());
            }
            return newName;
        }

        private static Dictionary<string, string> GetPairsToChange(Order order)
        {
            return new Dictionary<string, string>
            {
                {"<client>", order.Client.Name },
                { "<service>", order.Service.Name },
                { "<employee>", order.Employee.Name },
                { "<price>", order.Service.Price.ToString() },
                { "<discount>", order.Discount.Percent.ToString() },

                { "<day>", order.Date.Day.ToString() },
                { "<month>", order.Date.ToString("MMMM") },
                { "<year>", order.Date.Year.ToString() }
            };
        }

        private static void AddEndDate(Dictionary<string, string> pair)
        {
            int month = DateTime.ParseExact(pair["<month>"], "MMMM", CultureInfo.CurrentCulture).Month;
            if (month == 12)
            {
                pair.Add("<year2>", (Convert.ToInt32(pair["<year>"]) + 1).ToString());
                pair.Add("<month2>", "Январь");
            }
            else
            {
                pair.Add("<year2>", pair["<year>"]);
                pair.Add("<month2>", new DateTime(2024, month + 1, 1).ToString("MMMM"));
            }

            pair.Add("<day2>", DateTime.DaysInMonth(Convert.ToInt32(pair["<year2>"]), month + 1).ToString());
        }

        public static Excel.Application GenerateExcelReport(List<VisibleOrder> orders)
        {
            var excelApp = new Excel.Application();
            var currentApp = excelApp.Workbooks.Add();

            DisplayOrders(currentApp, orders.ToList());

            CreateEmployeeStatistics(currentApp, orders);
            CreateServiceStatistics(currentApp, orders);
            CreateServiceFrequencyStatistics(currentApp, orders);

            return excelApp;
        }

        private static void CreateServiceFrequencyStatistics(Excel.Workbook currentApp, List<VisibleOrder> orders)
        {
            var chart = CreateServiceCountDiagram(currentApp, orders, "Для статистки востребованности");

            chart.Name = "Востребованность услуг";

            chart.ChartTitle.Characters.Text = "ВОСТРЕБОВАННОСТЬ УСЛУГ ЗА " +
                GetTimeSpan(orders) + " МЕСЯЦЕВ";
        }

        public static void GenerateExlelEmployeeStatistic(Excel.Application excelApp, List<VisibleOrder> orders, Employee employee)
        {
            // сделать розочку статистики(опыт в годах, выполненные заказы, средний зароботок в месяц, )
            // высчитывать у всех работников максимальный показатель
            orders = (from ord in orders
                      where ord.Нотариус == employee.Name
                      select ord).ToList();

            if (orders.Count() != 0)
            {
                CreateProfitStatistic(excelApp.ActiveWorkbook, orders, employee);
                CreateEmployeeServiceStatistic(excelApp.ActiveWorkbook, orders, employee);
                EmployeePentagram(excelApp.ActiveWorkbook, employee);
            }
            else
            {
                MessageBox.Show("У работника " + employee.Name + " нет выполненных заказов", "Нет данных для статистики",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void EmployeePentagram(Excel.Workbook currentApp, Employee employee)
        {
            double[] stats = CalculateStats(employee);

            var excelApp = currentApp.Worksheets.Add();
            excelApp.Name = "Для статок";

            Dictionary<string, double> fullStats = new Dictionary<string, double>
            {
                { "Опыт работы", stats[0] },
                { "Колличество заказов", stats[1] },
                { "Средняя цена за заказ", stats[2] },
                { "Опыт работы1", stats[3] },// поменять
                { "Опыт работы2", stats[4] }//  поменять
            };

            for (int i = 0; i < fullStats.Count; i++)
            {
                excelApp.Cells[i + 1, 1] = fullStats.Keys.ToArray()[i];
                excelApp.Cells[i + 1, 2] = fullStats.Values.ToArray()[i];

                excelApp.Columns.AutoFit();
            }

            currentApp.Charts.Add();
            currentApp.ActiveChart.ChartType = Excel.XlChartType.xlRadar;
            currentApp.ActiveChart.HasLegend = false;
            currentApp.ActiveChart.HasTitle = true;

            currentApp.ActiveChart.Name = "Стата " + employee.Name;

            currentApp.ActiveChart.ChartTitle.Characters.Text = "СТАТА " + employee.Name;
        }
        private static double[] CalculateStats(Employee employee)
        {
            double[] maxStats = new double[5];
            foreach (Employee emp in Algorithms.Notary.Employee)
            {   //  опыт работы
                if ((DateTime.Now.Date - emp.HireDate.Date).Days > maxStats[0])
                    maxStats[0] = (DateTime.Now.Date - emp.HireDate.Date).Days;
                //  колличество заказов
                int servCount = (from ord in Algorithms.Notary.Order
                                 where ord.EmployeeID == emp.EmployeeID
                                 select ord).Count();

                if (servCount > maxStats[1])
                    maxStats[1] = servCount;
                //  средняя цена за заказ
                try
                {
                    double averageProffit = (from ord in Algorithms.Notary.Order
                                             where ord.EmployeeID == emp.EmployeeID
                                             select ord.Service.Price).Average();

                    if (averageProffit > maxStats[2])
                        maxStats[2] = averageProffit;
                }
                catch { }
            }
            maxStats[3] = 5;
            maxStats[4] = 5;

            maxStats[0] = (DateTime.Now.Date - employee.HireDate.Date).Days / maxStats[0] * 10;
            maxStats[1] = (from ord in Algorithms.Notary.Order
                           where ord.EmployeeID == employee.EmployeeID
                           select ord).Count() / maxStats[1] * 10;

            maxStats[2] = (from ord in Algorithms.Notary.Order
                           where ord.EmployeeID == employee.EmployeeID
                           select ord.Service.Price).Average() / maxStats[2] * 10;

            return maxStats;
        }

        private static void CreateEmployeeServiceStatistic(Excel.Workbook currentApp, List<VisibleOrder> orders, Employee employee)
        {
            var chart = CreateServiceCountDiagram(currentApp, orders, "Для статистки услуг рабочего");

            chart.Name = "Услуги " + employee.Name;

            chart.ChartTitle.Characters.Text = "УСЛУГИ " + employee.Name + " ЗА " +
                GetTimeSpan(orders) + " МЕСЯЦЕВ";
        }

        private static Excel.Chart CreateServiceCountDiagram(Excel.Workbook currentApp, List<VisibleOrder> orders, string name)
        {
            var excelApp = currentApp.Worksheets.Add();
            excelApp.Name = name;

            Dictionary<string, int> profit = new Dictionary<string, int>();

            foreach (VisibleOrder order in orders)
            {
                try
                {
                    profit.Add(order.Услуга, 1);
                }
                catch
                {
                    profit[order.Услуга]++;
                }
            }

            for (int i = 0; i < profit.Count; i++)
            {
                excelApp.Cells[i + 1, 1] = profit.Keys.ToArray()[i];
                excelApp.Cells[i + 1, 2] = profit.Values.ToArray()[i];

                excelApp.Columns.AutoFit();
            }

            currentApp.Charts.Add();
            currentApp.ActiveChart.ChartType = Excel.XlChartType.xlPie;
            currentApp.ActiveChart.HasLegend = true;
            currentApp.ActiveChart.HasTitle = true;

            return currentApp.ActiveChart;
        }

        private static void CreateProfitStatistic(Excel.Workbook currentApp, List<VisibleOrder> orders, Employee employee)
        {
            var excelApp = currentApp.Worksheets.Add();
            excelApp.Name = "Для зароботока за месяц";

            Dictionary<string, double> profit = new Dictionary<string, double>();

            foreach (VisibleOrder order in orders)
            {
                try
                {
                    profit.Add(order.Дата.ToString("MMMM.yyyy"), order.Цена);
                }
                catch
                {
                    profit[order.Дата.ToString("MMMM.yyyy")] += order.Цена;
                }
            }

            for (int i = 0; i < profit.Count; i++)
            {
                excelApp.Cells[i + 1, 1] = profit.Keys.ToArray()[i];
                excelApp.Cells[i + 1, 2] = profit.Values.ToArray()[i];

                excelApp.Columns.AutoFit();
            }

            currentApp.Charts.Add();
            currentApp.ActiveChart.ChartType = Excel.XlChartType.xlColumnClustered;
            currentApp.ActiveChart.HasLegend = false;
            currentApp.ActiveChart.HasTitle = true;

            currentApp.ActiveChart.Axes(Excel.XlAxisType.xlCategory).HasTitle = true;

            currentApp.ActiveChart.Axes(Excel.XlAxisType.xlValue).HasTitle = true;
            currentApp.ActiveChart.Name = "Зароботок " + employee.Name;

            currentApp.ActiveChart.Axes(Excel.XlAxisType.xlCategory).AxisTitle.Characters.Text = "Месяца";
            currentApp.ActiveChart.ChartTitle.Characters.Text = "ЗАРАБОТОК " + employee.Name + " ЗА " +
                GetTimeSpan(orders) + " МЕСЯЦЕВ";
            currentApp.ActiveChart.Axes(Excel.XlAxisType.xlValue).AxisTitle.Characters.Text = "Доход (BYN)";
        }

        public static void DisplayOrders(Excel.Workbook currentApp, List<VisibleOrder> orders)
        {
            var excelApp = currentApp.Worksheets.Add();
            excelApp.Name = "Заказы";

            for (int i = 0; i < VisibleOrder.GetFieldsName().Length; i++)
            {
                try
                {
                    excelApp.Cells[1, i + 1] = VisibleOrder.GetFieldsName()[i];
                }
                catch { i--; }
            }

            for (int i = 0; i < orders.Count(); i++)
            {
                excelApp.Cells[i + 2, 1] = orders[i].Клиент;
                excelApp.Cells[i + 2, 2] = orders[i].Услуга;
                excelApp.Cells[i + 2, 3] = orders[i].Нотариус;
                excelApp.Cells[i + 2, 4] = orders[i].Дата;
                excelApp.Cells[i + 2, 5] = orders[i].Цена;
                excelApp.Cells[i + 2, 6] = orders[i].Скидка;
            }

            while (true)
            {
                excelApp.Columns[1].AutoFit();
                excelApp.Columns[2].AutoFit();
                excelApp.Columns[3].AutoFit();
                excelApp.Columns[4].AutoFit();
                excelApp.Columns[5].AutoFit();
                excelApp.Columns[6].AutoFit();
                break;
            }
        }

        private static Excel.Chart CreateNewChart(Excel.Workbook currentApp, Dictionary<string, double> earnings, string chartName)
        {
            var excelApp = currentApp.Worksheets.Add();
            excelApp.Name = "Для " + chartName;

            for (int i = 0; i < earnings.Count; i++)
            {
                excelApp.Cells[i + 1, 1] = earnings.Keys.ToArray()[i];
                excelApp.Cells[i + 1, 2] = earnings.Values.ToArray()[i];
            }

            currentApp.Charts.Add();
            currentApp.ActiveChart.ChartType = Excel.XlChartType.xlColumnClustered;
            currentApp.ActiveChart.HasLegend = false;
            currentApp.ActiveChart.HasTitle = true;

            currentApp.ActiveChart.Axes(Excel.XlAxisType.xlCategory).HasTitle = true;

            currentApp.ActiveChart.Axes(Excel.XlAxisType.xlValue).HasTitle = true;
            currentApp.ActiveChart.Name = chartName;

            return currentApp.ActiveChart;
        }

        private static void CreateEmployeeStatistics(Excel.Workbook currentApp, List<VisibleOrder> orders)
        {
            Dictionary<string, double> earnings = GetEmployeeEarnings(orders);

            var empChart = CreateNewChart(currentApp, earnings, "Зароботок с рабочих");

            empChart.Axes(Excel.XlAxisType.xlCategory).AxisTitle.Characters.Text = "Работники";
            empChart.ChartTitle.Characters.Text = "ЗАРАБОТОК С РАБОЧИХ ЗА " +
                GetTimeSpan(orders) + " МЕСЯЦЕВ";
            empChart.Axes(Excel.XlAxisType.xlValue).AxisTitle.Characters.Text = "Зароботок (BYN)";
        }

        private static void CreateServiceStatistics(Excel.Workbook currentApp, List<VisibleOrder> orders)
        {
            Dictionary<string, double> earnings = GetServiceEarnings(orders);

            var servChart = CreateNewChart(currentApp, earnings, "Зароботок с услуг");

            servChart.Axes(Excel.XlAxisType.xlCategory).AxisTitle.Characters.Text = "Услуги";
            servChart.ChartTitle.Characters.Text = "ЗАРАБОТОК С УСЛУГ ЗА " +
                GetTimeSpan(orders) + " МЕСЯЦЕВ";
            servChart.Axes(Excel.XlAxisType.xlValue).AxisTitle.Characters.Text = "Зароботок (BYN)";
        }

        private static Dictionary<string, double> GetServiceEarnings(List<VisibleOrder> orders)
        {
            Dictionary<string, double> earnings = new Dictionary<string, double>();
            for (int i = 0; i < orders.Count; i++)
            {
                try
                {
                    earnings.Add(orders[i].Услуга, orders[i].Цена);
                }
                catch
                {
                    earnings[orders[i].Услуга] += orders[i].Цена;
                }
            }

            return earnings;
        }

        private static Dictionary<string, double> GetEmployeeEarnings(List<VisibleOrder> orders)
        {
            Dictionary<string, double> earnings = new Dictionary<string, double>();
            for (int i = 0; i < orders.Count; i++)
            {
                try
                {
                    earnings.Add(orders[i].Нотариус, orders[i].Цена);
                }
                catch
                {
                    earnings[orders[i].Нотариус] += orders[i].Цена;
                }
            }

            return earnings;
        }

        private static int GetTimeSpan(List<VisibleOrder> orders)
        {
            if (orders.Count == 0)
                return 0;

            DateTime start = orders[0].Дата;
            DateTime end = orders[0].Дата;

            foreach (VisibleOrder order in orders)
            {
                if (order.Дата < start)
                    start = order.Дата;

                if (order.Дата > end)
                    end = order.Дата;
            }

            return end.Month - start.Month + 1;
        }
    }
}
