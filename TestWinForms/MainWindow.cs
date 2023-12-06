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

            MoneyTextBox.Text = Algorithms.CalculateLastMonthlyProfit().ToString();
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

            MoneyTextBox.Text = Algorithms.CalculateLastMonthlyProfit().ToString();
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

            DeleteElement deleteElement = new DeleteElement(Algorithms.Types.Service);
            deleteElement.ShowDialog();

            Algorithms.ShowService(Grid);
        }

        private void DeleteDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> discounst = (from discount in Algorithms.Notary.Discount
                                      where discount.NewFlag == 1
                                      select discount.Name).ToList();

            DeleteElement deleteElement = new DeleteElement(Algorithms.Types.Discount);
            deleteElement.ShowDialog();

            Algorithms.ShowDiscount(Grid);
        }

        private void DeleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> employes = (from emp in Algorithms.Notary.Employee
                                     where emp.DismissalDate == null
                                     select emp.Name).ToList();

            DeleteElement deleteElement = new DeleteElement(Algorithms.Types.Employee);
            deleteElement.ShowDialog();

            Algorithms.ShowEmployee(Grid);
        }

        private void ФИОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeElement changeElement = new ChangeElement(Algorithms.Types.Client, "ФИО");
            changeElement.ShowDialog();

            Algorithms.ShowClient(Grid);
        }

        private void ТелефонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeElement changeElement = new ChangeElement(Algorithms.Types.Client, "Телефон");
            changeElement.ShowDialog();

            Algorithms.ShowClient(Grid);
        }

        private void РодДеятельностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeElement changeElement = new ChangeElement(Algorithms.Types.Client, "Род деятельности");
            changeElement.ShowDialog();

            Algorithms.ShowClient(Grid);
        }

        private void ДатаРожденияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeElement changeElement = new ChangeElement(Algorithms.Types.Client, "Дата рождения");
            changeElement.ShowDialog();

            Algorithms.ShowClient(Grid);
        }

        private void НазваниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeElement changeElement = new ChangeElement(Algorithms.Types.Service, "Название");
            changeElement.ShowDialog();

            Algorithms.ShowService(Grid);
        }

        private void ЦенаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeElement changeElement = new ChangeElement(Algorithms.Types.Service, "Цена");
            changeElement.ShowDialog();

            Algorithms.ShowService(Grid);
            MoneyTextBox.Text = Algorithms.CalculateLastMonthlyProfit().ToString();
        }

        private void ОписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeElement changeElement = new ChangeElement(Algorithms.Types.Service, "Описание");
            changeElement.ShowDialog();

            Algorithms.ShowService(Grid);
        }

        private void НазваниеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangeElement changeElement = new ChangeElement(Algorithms.Types.Discount, "Название");
            changeElement.ShowDialog();

            Algorithms.ShowDiscount(Grid);
        }

        private void ПроцентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeElement changeElement = new ChangeElement(Algorithms.Types.Discount, "Процент");
            changeElement.ShowDialog();

            Algorithms.ShowDiscount(Grid);
            MoneyTextBox.Text = Algorithms.CalculateLastMonthlyProfit().ToString();
        }

        private void ОписаниеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangeElement changeElement = new ChangeElement(Algorithms.Types.Discount, "Описание");
            changeElement.ShowDialog();

            Algorithms.ShowDiscount(Grid);
        }

        private void ФИОToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangeElement changeElement = new ChangeElement(Algorithms.Types.Employee, "ФИО");
            changeElement.ShowDialog();

            Algorithms.ShowEmployee(Grid);
        }

        private void ЗарплатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeElement changeElement = new ChangeElement(Algorithms.Types.Employee, "Зарплата");
            changeElement.ShowDialog();

            Algorithms.ShowEmployee(Grid);
        }

        private void ДолжностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeElement changeElement = new ChangeElement(Algorithms.Types.Employee, "Должность");
            changeElement.ShowDialog();

            Algorithms.ShowEmployee(Grid);
        }
    }
}
