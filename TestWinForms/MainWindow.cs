﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class MainWindow : Form
    {
        private Algorithms.Type CurrentTable;

        public MainWindow()
        {
            InitializeComponent();

            Algorithms.ShowOrders(Grid);

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
            Algorithms.ShowClient(Grid);
            ChangeCurrentTable(Algorithms.Type.Client);
        }

        private void ShowOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Algorithms.ShowOrders(Grid);
            ChangeCurrentTable(Algorithms.Type.Order);
        }

        private void ShowServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Algorithms.ShowService(Grid);
            ChangeCurrentTable(Algorithms.Type.Service);
        }

        private void ShowDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Algorithms.ShowDiscount(Grid);
            ChangeCurrentTable(Algorithms.Type.Discount);
        }

        private void ShowEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Algorithms.ShowEmployee(Grid);
            ChangeCurrentTable(Algorithms.Type.Employee);
        }

        private void AddOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrder AddOrder = new AddOrder();
            AddOrder.ShowDialog();

            Algorithms.ShowOrders(Grid);
            ChangeCurrentTable(Algorithms.Type.Order);

            MoneyTextBox.Text = Algorithms.CalculateLastMonthlyProfit().ToString();
        }

        private void AddServiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddServiceDiscount addService = new AddServiceDiscount(Algorithms.Type.Service);
            addService.ShowDialog();

            Algorithms.ShowService(Grid);
            ChangeCurrentTable(Algorithms.Type.Service);
        }

        private void AddDiscountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddServiceDiscount addDiscount = new AddServiceDiscount(Algorithms.Type.Discount);
            addDiscount.ShowDialog();

            Algorithms.ShowDiscount(Grid);
            ChangeCurrentTable(Algorithms.Type.Discount);
        }

        private void AddEmployeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();

            Algorithms.ShowEmployee(Grid);
            ChangeCurrentTable(Algorithms.Type.Employee);
        }

        private void DeleteServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> services = (from service in Algorithms.Notary.Service
                                     where service.NewFlag == 1
                                     select service.Name).ToList();

            DeleteElement deleteElement = new DeleteElement(Algorithms.Type.Service);
            deleteElement.ShowDialog();

            Algorithms.ShowService(Grid);
            ChangeCurrentTable(Algorithms.Type.Service);
        }

        private void DeleteDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> discounst = (from discount in Algorithms.Notary.Discount
                                      where discount.NewFlag == 1
                                      select discount.Name).ToList();

            DeleteElement deleteElement = new DeleteElement(Algorithms.Type.Discount);
            deleteElement.ShowDialog();

            Algorithms.ShowDiscount(Grid);
            ChangeCurrentTable(Algorithms.Type.Discount);
        }

        private void DeleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> employes = (from emp in Algorithms.Notary.Employee
                                     where emp.DismissalDate == null
                                     select emp.Name).ToList();

            DeleteElement deleteElement = new DeleteElement(Algorithms.Type.Employee);
            deleteElement.ShowDialog();

            Algorithms.ShowEmployee(Grid);
            ChangeCurrentTable(Algorithms.Type.Employee);
        }

        private void ClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeElement changeElement = new ChangeElement(Algorithms.Type.Client,
                ((ToolStripMenuItem)sender).Text);
            changeElement.ShowDialog();

            Algorithms.ShowClient(Grid);
            ChangeCurrentTable(Algorithms.Type.Client);
        }

        private void ServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeElement changeElement = new ChangeElement(Algorithms.Type.Service,
                ((ToolStripMenuItem)sender).Text);
            changeElement.ShowDialog();

            Algorithms.ShowService(Grid);
            ChangeCurrentTable(Algorithms.Type.Service);
        }

        private void DiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeElement changeElement = new ChangeElement(Algorithms.Type.Discount,
                ((ToolStripMenuItem)sender).Text);
            changeElement.ShowDialog();

            Algorithms.ShowDiscount(Grid);
            ChangeCurrentTable(Algorithms.Type.Discount);
        }

        private void EmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeElement changeElement = new ChangeElement(Algorithms.Type.Employee,
                ((ToolStripMenuItem)sender).Text);
            changeElement.ShowDialog();

            Algorithms.ShowEmployee(Grid);
            ChangeCurrentTable(Algorithms.Type.Employee);
        }

        private void SearchB_Click(object sender, EventArgs e)
        {
            if (TableCB.Text == "" || SearchFieldTB.Text == "")
            {
                MessageBox.Show("Вы не ввели параметры фильтрации");
                return;
            }

            switch (CurrentTable)
            {
                case Algorithms.Type.Client:
                    ShowFiltredClients();
                    break;
                case Algorithms.Type.Order:
                    ShowFiltredOrders();
                    break;
                case Algorithms.Type.Service:
                    ShowFiltredServices();
                    break;
                case Algorithms.Type.Discount:
                    ShowFiltredDiscounts();
                    break;
                case Algorithms.Type.Employee:
                    ShowFiltredEmployees();
                    break;
            }
        }

        public void ShowFiltredClients()
        {
            try
            {
                var table = (from client in Algorithms.Notary.Client
                             select new
                             {
                                 Имя = client.Name,
                                 Дата_рождения = client.BirthDate,
                                 Телефон = client.Telephone,
                                 Работа = client.Activity
                             }).ToArray();

                PropertyInfo field = table.First().GetType().GetProperty(TableCB.Text);

                Grid.DataSource = (from client in table
                                   where field.GetValue(client).ToString().Equals(SearchFieldTB.Text)
                                   select client).ToArray();
            }
            catch (TargetException ex)
            {
                MessageBox.Show("Опять таргет");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Вы не ввели даннные");
            }
            catch (Exception ex)
            {
                MessageBox.Show("BOBA");
            }
        }
        public void ShowFiltredOrders()
        {
            //try
            //{
            var table = (from order in Algorithms.Notary.Order
                         join serv in Algorithms.Notary.Service on order.ServiceID equals serv.ServiceID
                         join client in Algorithms.Notary.Client on order.ClientID equals client.ClientID
                         join emp in Algorithms.Notary.Employee on order.EmployeeID equals emp.EmployeeID
                         join discount in Algorithms.Notary.Discount on order.DiscountID equals discount.DiscountID
                         into discounts
                         from disc in discounts.DefaultIfEmpty()
                         select new
                         {
                             Клиент = client.Name,
                             Услуга = serv.Name,
                             Нотариус = emp.Name,
                             Дата = order.Date,
                             Цена = serv.Price,
                             Скидка = disc.Percent
                         }).ToArray();

            PropertyInfo field = table.First().GetType().GetProperty(TableCB.Text);

            Grid.DataSource = (from client in table
                               where field.GetValue(client).ToString().Equals(SearchFieldTB.Text)
                               select client).ToArray();
            //}
            //catch (TargetException ex)
            //{
            //    MessageBox.Show("Опять таргет");
            //}
            //catch (NullReferenceException ex)
            //{
            //    MessageBox.Show("Вы не ввели даннные");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        public void ShowFiltredServices()
        {
            var table = (from service in Algorithms.Notary.Service
                         where service.NewFlag == 1
                         select new
                         {
                             Название = service.Name,
                             Цена = service.Price,
                             Описание = service.Description
                         }).ToArray();

            PropertyInfo field = table.First().GetType().GetProperty(TableCB.Text);

            Grid.DataSource = (from service in table
                               where field.GetValue(service).ToString().Equals(SearchFieldTB.Text)
                               select service).ToArray();
        }
        public void ShowFiltredDiscounts()
        {
            var table = (from discount in Algorithms.Notary.Discount
                         where discount.NewFlag == 1
                         select new
                         {
                             Название = discount.Name,
                             Процент = discount.Percent,
                             Описание = discount.Description
                         }).ToArray();

            PropertyInfo field = table.First().GetType().GetProperty(TableCB.Text);

            Grid.DataSource = (from discount in table
                               where field.GetValue(discount).ToString().Equals(SearchFieldTB.Text)
                               select discount).ToArray();
        }
        public void ShowFiltredEmployees()
        {
            var table = (from employee in Algorithms.Notary.Employee
                         select new
                         {
                             Имя = employee.Name,
                             Зарплата = employee.Salary,
                             Должность = employee.Post,
                             Найм = employee.HireDate,
                             Статус = employee.DismissalDate == null ? "Работает" :
                             "Уволен " + employee.DismissalDate
                         }).ToArray();

            PropertyInfo field = table.First().GetType().GetProperty(TableCB.Text);

            Grid.DataSource = (from employee in table
                               where field.GetValue(employee).ToString().Equals(SearchFieldTB.Text)
                               select employee).ToArray();
        }

        private void DropFiltresB_Click(object sender, EventArgs e)
        {
            switch (CurrentTable)
            {
                case Algorithms.Type.Client:
                    Algorithms.ShowClient(Grid);
                    break;
                case Algorithms.Type.Order:
                    Algorithms.ShowOrders(Grid);
                    break;
                case Algorithms.Type.Service:
                    Algorithms.ShowService(Grid);
                    break;
                case Algorithms.Type.Discount:
                    Algorithms.ShowDiscount(Grid);
                    break;
                case Algorithms.Type.Employee:
                    Algorithms.ShowEmployee(Grid);
                    break;
            }
        }

        public void ChangeCurrentTable(Algorithms.Type type)
        {
            CurrentTable = type;
            switch (type)
            {
                case Algorithms.Type.Client:
                    TableCB.DataSource = new string[] { "Имя", "Дата_рождения", "Телефон", "Работа" };
                    break;
                case Algorithms.Type.Service:
                    TableCB.DataSource = new string[] { "Название", "Цена", "Описание" };
                    break;
                case Algorithms.Type.Order:
                    TableCB.DataSource = new string[] { "Клиент", "Услуга", "Нотариус", "Дата", "Цена", "Скидка" };
                    break;
                case Algorithms.Type.Discount:
                    TableCB.DataSource = new string[] { "Название", "Процент", "Описание" };
                    break;
                case Algorithms.Type.Employee:
                    TableCB.DataSource = new string[] { "Имя", "Зарплата", "Должность", "Найм", "Статус" };
                    break;
            }
        }
    }
}
