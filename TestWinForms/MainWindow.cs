using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace TestWinForms
{
    public partial class MainWindow : Form
    {
        private readonly NotaryBaseDataContext Notary = new NotaryBaseDataContext();

        public MainWindow()
        {
            InitializeComponent();

            Algorithms.ShowOrders(Grid, Notary);
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
            Algorithms.ShowClient(Grid, Notary);
        }

        private void ShowOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Algorithms.ShowOrders(Grid, Notary);
        }

        private void ShowServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Algorithms.ShowService(Grid, Notary);
        }

        private void ShowDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Algorithms.ShowDiscount(Grid, Notary);
        }

        private void ShowEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Algorithms.ShowEmployee(Grid, Notary);
        }

        private void AddOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrder AddOrder = new AddOrder();
            AddOrder.ShowDialog();

            Algorithms.ShowOrders(Grid, Notary);
        }

        private void AddServiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddService addService = new AddService();
            addService.ShowDialog();

            Algorithms.ShowService(Grid, Notary);
        }

        private void AddDiscountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddDiscount addDiscount = new AddDiscount();
            addDiscount.ShowDialog();

            Algorithms.ShowDiscount(Grid, Notary);
        }

        private void AddEmployeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();

            Algorithms.ShowEmployee(Grid, Notary);
        }

        private void DeleteServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> services = (from service in Notary.Service
                                     where service.NewFlag == 1
                                     select service.Name).ToList();

            DeleteElement deleteElement = new DeleteElement(Algorithms.Types.Service, services);
            deleteElement.ShowDialog();

            Algorithms.ShowService(Grid, Notary);
        }

        private void DeleteDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> discounst = (from discount in Notary.Discount
                                      where discount.NewFlag == 1
                                      select discount.Name).ToList();

            DeleteElement deleteElement = new DeleteElement(Algorithms.Types.Discount, discounst);
            deleteElement.ShowDialog();

            Algorithms.ShowDiscount(Grid, Notary);
        }

        private void DeleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> employes = (from emp in Notary.Employee
                                     where emp.DismissalDate == null
                                     select emp.Name).ToList();

            DeleteElement deleteElement = new DeleteElement(Algorithms.Types.Employee, employes);
            deleteElement.ShowDialog();

            Algorithms.ShowEmployee(Grid, Notary);
        }
    }
}
