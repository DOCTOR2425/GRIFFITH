using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace TestWinForms
{
    public class ReportCreator// TODO Розочка стат работника для отчёта
    {
        public static string fileTeplate { get { return "D:\\Project\\Course_3\\Проект GRIFFITH\\GRIFFITH\\TestWinForms\\Template.docx"; } }

        public static void GenerateContract(KeyValuePair<string, string>[] pairsToChange)
        {
            if (File.Exists(fileTeplate) == false)
            {
                MessageBox.Show("Не удалось найти шаблон файла для составления договора", "Ошибка файла",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var wordApp = new Word.Application();
            object mis = Type.Missing;
            wordApp.Documents.Open(fileTeplate);

            Word.Find find = wordApp.Selection.Find;

            for (int i = 0; i < pairsToChange.Length; i++)
            {
                try
                {
                    find.Text = pairsToChange[i].Key;
                    find.Replacement.Text = pairsToChange[i].Value;

                    object wrap = Word.WdFindWrap.wdFindContinue;
                    object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: mis, MatchSoundsLike: mis, Forward: true,
                        Wrap: wrap, ReplaceWith: mis, Replace: replace);
                }
                catch { i--; }
            }

            wordApp.Visible = true;
        }

        public static void GenerateContract(Order order)
        {
            if (File.Exists(fileTeplate) == false)
            {
                MessageBox.Show("Не удалось найти шаблон файла для составления договора", "Ошибка файла",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            KeyValuePair<string, string>[] pairsToChange = GetPairsToChange(order);

            var wordApp = new Word.Application();
            object mis = Type.Missing;
            wordApp.Documents.Open(fileTeplate);

            Word.Find find = wordApp.Selection.Find;

            for (int i = 0; i < pairsToChange.Length; i++)
            {
                try
                {
                    find.Text = pairsToChange[i].Key;
                    find.Replacement.Text = pairsToChange[i].Value;

                    object wrap = Word.WdFindWrap.wdFindContinue;
                    object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: mis, MatchSoundsLike: mis, Forward: true,
                        Wrap: wrap, ReplaceWith: mis, Replace: replace);
                }
                catch { i--; }
            }

            wordApp.Visible = true;
        }

        private static KeyValuePair<string, string>[] GetPairsToChange(Order order)
        {
            return new KeyValuePair<string, string>[9]
            {
                new KeyValuePair<string, string>( "<client>", order.Client.Name ),
                new KeyValuePair<string, string>( "<service>", order.Service.Name ),
                new KeyValuePair<string, string>( "<employee>", order.Employee.Name ),
                new KeyValuePair<string, string>( "<price>", order.Service.Price.ToString() ),
                new KeyValuePair<string, string>( "<discount>", order.Discount.Percent.ToString() ),

                new KeyValuePair<string, string>("<day>", order.Date.Day.ToString()),
                new KeyValuePair<string, string>("<month>", order.Date.ToString("MMMM")),
                new KeyValuePair<string, string>("<year>", order.Date.Year.ToString()),

                new KeyValuePair<string, string>( "<activity>", order.Client.Activity)
            };

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

            CreateProfitStatistic(excelApp.ActiveWorkbook, orders, employee);
            CreateEmployeeServiceStatistic(excelApp.ActiveWorkbook, orders, employee);
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
                try
                {
                    excelApp.Cells[i + 1, 1] = profit.Keys.ToArray()[i];
                    excelApp.Cells[i + 1, 2] = profit.Values.ToArray()[i];

                    excelApp.Columns.AutoFit();
                }
                catch { i--; }
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
                try
                {
                    excelApp.Cells[i + 1, 1] = profit.Keys.ToArray()[i];
                    excelApp.Cells[i + 1, 2] = profit.Values.ToArray()[i];

                    excelApp.Columns.AutoFit();
                }
                catch { i--; }
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
                try
                {
                    excelApp.Cells[i + 2, 1] = orders[i].Клиент;
                    excelApp.Cells[i + 2, 2] = orders[i].Услуга;
                    excelApp.Cells[i + 2, 3] = orders[i].Нотариус;
                    excelApp.Cells[i + 2, 4] = orders[i].Дата;
                    excelApp.Cells[i + 2, 5] = orders[i].Цена;
                    excelApp.Cells[i + 2, 6] = orders[i].Скидка;
                }
                catch { i--; }
            }

            while (true)
            {
                try
                {
                    excelApp.Columns[1].AutoFit();
                    excelApp.Columns[2].AutoFit();
                    excelApp.Columns[3].AutoFit();
                    excelApp.Columns[4].AutoFit();
                    excelApp.Columns[5].AutoFit();
                    excelApp.Columns[6].AutoFit();
                    break;
                }
                catch { }
            }
        }

        private static Excel.Chart CreateNewChart(Excel.Workbook currentApp, Dictionary<string, double> earnings, string chartName)
        {
            var excelApp = currentApp.Worksheets.Add();
            excelApp.Name = "Для " + chartName;

            for (int i = 0; i < earnings.Count; i++)
            {
                try
                {
                    excelApp.Cells[i + 1, 1] = earnings.Keys.ToArray()[i];
                    excelApp.Cells[i + 1, 2] = earnings.Values.ToArray()[i];

                    excelApp.Columns.AutoFit();
                }
                catch { i--; }
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
