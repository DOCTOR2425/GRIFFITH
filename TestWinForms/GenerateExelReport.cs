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

        void DisplayInExcel(List<VisibleOrder> orders)
        {
            var excelApp = new Excel.Application();
            excelApp.Workbooks.Add();
            excelApp.Visible = true;

            excelApp.Range["A1"].Select();

            for (int i = 0; i < VisibleOrder.GetFieldsName().Length; i++)
            {
                try
                {
                    excelApp.ActiveCell.Value = VisibleOrder.GetFieldsName()[i];
                    excelApp.ActiveCell.Offset[0, 1].Select();
                }
                catch { i--; }
            }

            excelApp.Range["A2"].Select();

            for (int i = 0; i < orders.Count(); i++)
            {
                try
                {
                    excelApp.ActiveCell.Value = orders[i].Клиент;
                    excelApp.ActiveCell.Offset[0, 1].Select();
                    excelApp.ActiveCell.Value = orders[i].Услуга;
                    excelApp.ActiveCell.Offset[0, 1].Select();
                    excelApp.ActiveCell.Value = orders[i].Нотариус;
                    excelApp.ActiveCell.Offset[0, 1].Select();
                    excelApp.ActiveCell.Value = orders[i].Дата;
                    excelApp.ActiveCell.Offset[0, 1].Select();
                    excelApp.ActiveCell.Value = orders[i].Цена;
                    excelApp.ActiveCell.Offset[0, 1].Select();
                    excelApp.ActiveCell.Value = orders[i].Скидка;
                    excelApp.ActiveCell.Offset[1, 0].Select();
                    excelApp.Range["A" + (2 + i + 1)].Select();
                }
                catch
                {
                    excelApp.Range["A" + (2 + i)].Select();
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

        private void GenerateReportB_Click(object sender, EventArgs e)
        {
            List<VisibleOrder> orders = GetVisibleOrdersForTimeSpan();
            if (orders.Count == 0)
            {
                MessageBox.Show("В этом временном промежутке нет ни одного заказа", "Заказов нет",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DisplayInExcel(orders.ToList());

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
