using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class MainWindow : Form// TODO сделать меню и добавить пункт составить диаграмму
    {
        private Algorithms.Type CurrentTable;

        public MainWindow()
        {
            InitializeComponent();

            Grid.DataSource = Algorithms.GetVisibleOrders();

            MoneyTextBox.Text = Algorithms.CalculateLastMonthlyProfit().ToString();
            ChangeCurrentTable(Algorithms.Type.Order);
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
            Grid.DataSource = Algorithms.GetVisibleClients();
            ChangeCurrentTable(Algorithms.Type.Client);
        }

        private void ShowOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grid.DataSource = Algorithms.GetVisibleOrders();
            ChangeCurrentTable(Algorithms.Type.Order);
        }

        private void ShowServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grid.DataSource = Algorithms.GetVisibleServices();
            ChangeCurrentTable(Algorithms.Type.Service);
        }

        private void ShowDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grid.DataSource = Algorithms.GetVisibleDiscounts();
            ChangeCurrentTable(Algorithms.Type.Discount);
        }

        private void ShowEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grid.DataSource = Algorithms.GetVisibleEmployees();
            ChangeCurrentTable(Algorithms.Type.Employee);
        }

        private void AddOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrder AddOrder = new AddOrder();
            AddOrder.ShowDialog();

            Grid.DataSource = Algorithms.GetVisibleOrders();
            ChangeCurrentTable(Algorithms.Type.Order);

            MoneyTextBox.Text = Algorithms.CalculateLastMonthlyProfit().ToString();
        }

        private void AddServiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddServiceDiscount addService = new AddServiceDiscount(Algorithms.Type.Service);
            addService.ShowDialog();

            Grid.DataSource = Algorithms.GetVisibleServices();
            ChangeCurrentTable(Algorithms.Type.Service);
        }

        private void AddDiscountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddServiceDiscount addDiscount = new AddServiceDiscount(Algorithms.Type.Discount);
            addDiscount.ShowDialog();

            Grid.DataSource = Algorithms.GetVisibleDiscounts();
            ChangeCurrentTable(Algorithms.Type.Discount);
        }

        private void AddEmployeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();

            Grid.DataSource = Algorithms.GetVisibleEmployees();
            ChangeCurrentTable(Algorithms.Type.Employee);
        }

        private void DeleteServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> services = (from service in Algorithms.Notary.Service
                                     where service.NewFlag == 1
                                     select service.Name).ToList();

            DeleteElement deleteElement = new DeleteElement(Algorithms.Type.Service);
            deleteElement.ShowDialog();

            Grid.DataSource = Algorithms.GetVisibleServices();
            ChangeCurrentTable(Algorithms.Type.Service);
        }

        private void DeleteDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> discounst = (from discount in Algorithms.Notary.Discount
                                      where discount.NewFlag == 1
                                      select discount.Name).ToList();

            DeleteElement deleteElement = new DeleteElement(Algorithms.Type.Discount);
            deleteElement.ShowDialog();

            Grid.DataSource = Algorithms.GetVisibleDiscounts();
            ChangeCurrentTable(Algorithms.Type.Discount);
        }

        private void DeleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> employes = (from emp in Algorithms.Notary.Employee
                                     where emp.DismissalDate == null
                                     select emp.Name).ToList();

            DeleteElement deleteElement = new DeleteElement(Algorithms.Type.Employee);
            deleteElement.ShowDialog();

            Grid.DataSource = Algorithms.GetVisibleEmployees();
            ChangeCurrentTable(Algorithms.Type.Employee);
        }

        private void ClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeElement changeElement = new ChangeElement(Algorithms.Type.Client,
                ((ToolStripMenuItem)sender).Text);
            changeElement.ShowDialog();

            Grid.DataSource = Algorithms.GetVisibleClients();
            ChangeCurrentTable(Algorithms.Type.Client);
        }

        private void ServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeElement changeElement = new ChangeElement(Algorithms.Type.Service,
                ((ToolStripMenuItem)sender).Text);
            changeElement.ShowDialog();

            Grid.DataSource = Algorithms.GetVisibleServices();
            ChangeCurrentTable(Algorithms.Type.Service);
        }

        private void DiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeElement changeElement = new ChangeElement(Algorithms.Type.Discount,
                ((ToolStripMenuItem)sender).Text);
            changeElement.ShowDialog();

            Grid.DataSource = Algorithms.GetVisibleDiscounts();
            ChangeCurrentTable(Algorithms.Type.Discount);
        }

        private void EmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeElement changeElement = new ChangeElement(Algorithms.Type.Employee,
                ((ToolStripMenuItem)sender).Text);
            changeElement.ShowDialog();

            Grid.DataSource = Algorithms.GetVisibleEmployees();
            ChangeCurrentTable(Algorithms.Type.Employee);
        }

        private void SearchB_Click(object sender, EventArgs e)
        {
            if (TableSelectCB.Text == "" || SearchFieldTB.Text == "")
            {
                MessageBox.Show("Вы не ввели параметры фильтрации", "Нет данных", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            object[] list = new object[0];
            switch (CurrentTable)
            {
                case Algorithms.Type.Client:
                    list = Algorithms.GetVisibleClients().ToArray();
                    break;
                case Algorithms.Type.Order:
                    list = Algorithms.GetVisibleOrders().ToArray();
                    break;
                case Algorithms.Type.Service:
                    list = Algorithms.GetVisibleServices().ToArray();
                    break;
                case Algorithms.Type.Discount:
                    list = Algorithms.GetVisibleDiscounts().ToArray();
                    break;
                case Algorithms.Type.Employee:
                    list = Algorithms.GetVisibleEmployees().ToArray();
                    break;
            }

            PropertyInfo field = list[0].GetType().GetProperty(TableSelectCB.Text);

            Grid.DataSource = (from obj in list
                               where field.GetValue(obj).ToString().ToLower()
                               .Contains(SearchFieldTB.Text.ToLower())
                               select obj).ToList();
        }

        private void DropFiltresB_Click(object sender, EventArgs e)
        {
            switch (CurrentTable)
            {
                case Algorithms.Type.Client:
                    Grid.DataSource = Algorithms.GetVisibleClients();
                    break;
                case Algorithms.Type.Order:
                    Grid.DataSource = Algorithms.GetVisibleOrders();
                    break;
                case Algorithms.Type.Service:
                    Grid.DataSource = Algorithms.GetVisibleServices();
                    break;
                case Algorithms.Type.Discount:
                    Grid.DataSource = Algorithms.GetVisibleDiscounts();
                    break;
                case Algorithms.Type.Employee:
                    Grid.DataSource = Algorithms.GetVisibleEmployees();
                    break;
            }
        }

        public void ChangeCurrentTable(Algorithms.Type type)
        {
            CurrentTable = type;
            switch (type)
            {
                case Algorithms.Type.Client:
                    TableSelectCB.DataSource = VisibleClient.GetFieldsName();
                    break;
                case Algorithms.Type.Service:
                    TableSelectCB.DataSource = VisibleService.GetFieldsName();
                    break;
                case Algorithms.Type.Order:
                    TableSelectCB.DataSource = VisibleOrder.GetFieldsName();
                    break;
                case Algorithms.Type.Discount:
                    TableSelectCB.DataSource = VisibleDiscount.GetFieldsName();
                    break;
                case Algorithms.Type.Employee:
                    TableSelectCB.DataSource = VisibleEmployee.GetFieldsName();
                    break;
            }
        }

        private void GenerateReportClick(object sender, EventArgs e)
        {
            GenerateExelReport window = new GenerateExelReport();
            window.ShowDialog();
        }

        private void GenerateContractClick(object sender, EventArgs e)
        {
            GenerateWordContractByOrder window = new GenerateWordContractByOrder();
            window.ShowDialog();
        }
    }
}
