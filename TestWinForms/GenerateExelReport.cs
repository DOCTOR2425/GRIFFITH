using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace TestWinForms
{
    public partial class GenerateExelReport : Form// TODO Оформить отчёт нормально с выводом денег и чем нибудь ещё
    {
        public GenerateExelReport()
        {
            InitializeComponent();
        }

        void DisplayOrders(Excel.Workbook currentApp, List<VisibleOrder> orders)
        {
            var excelApp = (Excel.Worksheet)currentApp.Worksheets.Add();
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
                catch
                {
                    i--;
                }
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

        void DisplayEmployeeEarnings(Excel.Workbook currentApp, Dictionary<string, double> earnings)
        {
            var excelApp = (Excel.Worksheet)currentApp.Worksheets.Add();
            excelApp.Name = "Заработок рабочих";

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
            currentApp.ActiveChart.ChartTitle.Characters.Text = "ЗАРАБОТОК РАБОЧИХ ЗА " +
                GetSelectedTimeSpan() + " МЕСЯЦЕВ";

            currentApp.ActiveChart.Axes(Excel.XlAxisType.xlCategory).HasTitle = true;
            currentApp.ActiveChart.Axes(Excel.XlAxisType.xlCategory).AxisTitle.Characters.Text = "Работники";

            currentApp.ActiveChart.Axes(Excel.XlAxisType.xlValue).HasTitle = true;
            currentApp.ActiveChart.Axes(Excel.XlAxisType.xlValue).AxisTitle.Characters.Text = "Зароботок (BYN)";
        }

        private void GenerateReportB_Click(object sender, EventArgs e)
        {
            List<VisibleOrder> orders = GetVisibleOrdersForTimeSpan();
            if (orders.Count == 0)
            {
                MessageBox.Show("В этом временном промежутке нет ни одного заказа", "Заказов нет",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var excelApp = new Excel.Application();
            var currentApp = excelApp.Workbooks.Add();

            DisplayOrders(currentApp, orders.ToList());

            Dictionary<string, double> earnings = GetEmployeeEarnings();
            DisplayEmployeeEarnings(currentApp, earnings);

            excelApp.Visible = true;
            this.Close();
        }

        private List<VisibleOrder> GetVisibleOrdersForTimeSpan()
        {
            IQueryable<VisibleOrder> orders = null;

            if (CurrentMonthRB.Checked)
            {
                orders = from order in Algorithms.GetVisibleOrders()
                         where order.Дата.Month == DateTime.Now.Month
                         select order;
            }
            else if (LastMonthRB.Checked)
            {
                orders = from order in Algorithms.GetVisibleOrders()
                         where order.Дата.Month == DateTime.Now.Month - 1
                         select order;
            }
            else if (LastYearRB.Checked)
            {
                orders = from order in Algorithms.GetVisibleOrders()
                         where order.Дата.Year == DateTime.Now.Year - 1
                         select order;
            }
            else
            {
                orders = from order in Algorithms.GetVisibleOrders()
                         where order.Дата >= StartDateC.SelectionStart && order.Дата <= EndDateC.SelectionStart
                         select order;
            }
            return orders.ToList();
        }

        private Dictionary<string, double> GetEmployeeEarnings()
        {
            List<VisibleOrder> orders = GetVisibleOrdersForTimeSpan();

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

        private int GetSelectedTimeSpan()
        {
            if (CurrentMonthRB.Checked || LastMonthRB.Checked)
            {
                return 1;
            }
            else if (LastYearRB.Checked)
            {
                return 12;
            }
            else
            {
                return (int)(EndDateC.SelectionStart - StartDateC.SelectionStart).TotalDays / 30;
            }
        }

        private void StartDateC_DateChanged(object sender, DateRangeEventArgs e)
        {
            CurrentMonthRB.Checked = false;
            LastMonthRB.Checked = false;
            LastYearRB.Checked = false;
        }

        private void EndDateC_DateChanged(object sender, DateRangeEventArgs e)
        {
            CurrentMonthRB.Checked = false;
            LastMonthRB.Checked = false;
            LastYearRB.Checked = false;
        }
    }
}
