using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class GenerateExelReport : Form
    {
        public GenerateExelReport()
        {
            InitializeComponent();

            EmployeeSelectCB.DataSource = (from emp in Algorithms.Notary.Employee
                                           where emp.DismissalDate == null
                                           where emp.Post == "Нотариус"
                                           select emp.Name).ToList();
        }

        private void GenerateReportB_Click(object sender, EventArgs e)
        {
            GenerateReportB.Cursor = Cursors.WaitCursor;

            List<VisibleOrder> orders = GetVisibleOrdersForTimeSpan();
            if (orders.Count == 0)
            {
                MessageBox.Show("В этом временном промежутке нет ни одного заказа", "Заказов нет",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var excel = ReportCreator.GenerateExcelReport(orders);
            excel.Visible = true;

            if (EmployeeSelectChB.Checked)
                ReportCreator.GenerateExlelEmployeeStatistic(excel, orders, Algorithms.Notary.Employee.FirstOrDefault(
                    x => x.Name == EmployeeSelectCB.Text && x.DismissalDate == null));


            this.Close();
        }
        private List<VisibleOrder> GetVisibleOrdersForTimeSpan()
        {
            IEnumerable<VisibleOrder> orders = null;

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
            else if (AllTimeRB.Checked)
            {
                orders = Algorithms.GetVisibleOrders();
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

        private void EmployeeSelectCB_SelectedValueChanged(object sender, EventArgs e)
        {
            EmployeeInfoL.Text = "Опыт работы в годах: " + (DateTime.Now.Year - Algorithms.Notary.Employee.FirstOrDefault(
            x => x.Name == EmployeeSelectCB.Text && x.DismissalDate == null).HireDate.Year).ToString();
        }

        private void EmployeeSelectChB_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeInfoL.Enabled = !EmployeeInfoL.Enabled;
            EmployeeSelectCB.Enabled = !EmployeeSelectCB.Enabled;
        }
    }
}
