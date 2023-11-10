using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            Algorithms.ShowOrders(Grid);

            MoneyTextBox.Text = (from order in Algorithms.Notary.Order
                                 join serv in Algorithms.Notary.Service on order.ServiceID equals serv.ServiceID
                                 select serv.Price).ToList().Sum().ToString();
        }

        private void Grid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string toView = "";

            for (int i = 0; i < Grid.Columns.Count; i++)
                toView += Grid.Columns[i].Name + ":  " +
                          Grid.Rows[e.RowIndex].Cells[i].Value + "\n";

            MessageBox.Show(toView, "Выбранные элемент");
        }

        private void ShowClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Algorithms.ShowClient(Grid);
        }

        private void ShowOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Algorithms.ShowOrders(Grid);
        }

        private void ShowServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Algorithms.ShowService(Grid);
        }

        private void ShowDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Algorithms.ShowDiscount(Grid);
        }

        private void ShowEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Algorithms.ShowEmployee(Grid);
        }

        private void AddOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrder AddOrder = new AddOrder();
            AddOrder.ShowDialog();

            Algorithms.ShowOrders(Grid);

            MoneyTextBox.Text = (from order in Algorithms.Notary.Order
                                 join serv in Algorithms.Notary.Service on order.ServiceID equals serv.ServiceID
                                 select serv.Price).ToList().Sum().ToString();
        }

        private void AddServiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddServiceDiscount addService = new AddServiceDiscount(Algorithms.Types.Service);
            addService.ShowDialog();

            Algorithms.ShowService(Grid);
        }

        private void AddDiscountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddServiceDiscount addDiscount = new AddServiceDiscount(Algorithms.Types.Discount);
            addDiscount.ShowDialog();

            Algorithms.ShowDiscount(Grid);
        }

        private void AddEmployeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();

            Algorithms.ShowEmployee(Grid);
        }

        private void DeleteServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> services = (from service in Algorithms.Notary.Service
                                     where service.NewFlag == 1
                                     select service.Name).ToList();

            DeleteElement deleteElement = new DeleteElement(Algorithms.Types.Service, services);
            deleteElement.ShowDialog();

            Algorithms.ShowService(Grid);
        }

        private void DeleteDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> discounst = (from discount in Algorithms.Notary.Discount
                                      where discount.NewFlag == 1
                                      select discount.Name).ToList();

            DeleteElement deleteElement = new DeleteElement(Algorithms.Types.Discount, discounst);
            deleteElement.ShowDialog();

            Algorithms.ShowDiscount(Grid);
        }

        private void DeleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> employes = (from emp in Algorithms.Notary.Employee
                                     where emp.DismissalDate == null
                                     select emp.Name).ToList();

            DeleteElement deleteElement = new DeleteElement(Algorithms.Types.Employee, employes);
            deleteElement.ShowDialog();

            Algorithms.ShowEmployee(Grid);
        }
    }
}
