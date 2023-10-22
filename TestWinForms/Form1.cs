using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class Form1 : Form
    {
        private readonly NotaryBaseDataContext Notary = new NotaryBaseDataContext();

        public Form1()
        {
            InitializeComponent();

            ShowOrders();
        }

        private void ShowOrders()
        {
            var query = from order in Notary.Order
                        join serv in Notary.Service on order.ServiceID equals serv.ServiceID
                        join client in Notary.Client on order.ClientID equals client.ClientID
                        join emp in Notary.Employee on order.EmployeeID equals emp.EmployeeID
                        join discount in Notary.Discount on order.DiscountID equals discount.DiscountID
                        into discounts
                        from disc in discounts.DefaultIfEmpty()
                        select new
                        {
                            Клиент = client.Name,
                            Услуга = serv.Name,
                            Нотариус = emp.Name,
                            Дата = order.Date,
                            Цена = serv.Price,
                            Скидка = disc.Percent == null ? 0 : disc.Percent
                        };

            Grid.DataSource = query.ToList();

            Grid.Columns["Клиент"].Width = 150;
            Grid.Columns["Цена"].Width = 50;
            Grid.Columns["Нотариус"].Width = 150;
            Grid.Columns["Дата"].Width = 80;
            Grid.Columns["Скидка"].Width = 70;
        }

        private void ShowClientsButton_Click(object sender, EventArgs e)
        {
            Grid.DataSource = from client in Notary.Client
                              select new
                              {
                                  Клиент = client.Name,
                                  Телефон = client.Telephone,
                                  Работа = client.Activity
                              };
        }

        private void ShowServiceButton_Click(object sender, EventArgs e)
        {
            Grid.DataSource = from service in Notary.Service
                              where service.NewFlag == 1
                              select new
                              {
                                  Название = service.Name,
                                  Цена = service.Price,
                                  Описание = service.Description
                              };
            Grid.Columns["Описание"].Width = 250;
            Grid.Columns["Описание"].Visible = true;
        }

        private void ShowOrdersButton_Click(object sender, EventArgs e)
        {
            ShowOrders();
        }

        private void ShowDiscountButton_Click(object sender, EventArgs e)
        {
            Grid.DataSource = from discount in Notary.Discount
                              where discount.NewFlag == 1
                              select new
                              {
                                  Название = discount.Name,
                                  Процент = discount.Percent,
                                  Описание = discount.Description
                              };
            Grid.Columns["Описание"].Visible = false;
            Grid.Columns["Название"].Width = 200;
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            AddOrder AddOrder = new AddOrder();
            AddOrder.ShowDialog();

            ShowOrders();
        }

        private void AddServiceButton_Click(object sender, EventArgs e)
        {
            AddService addService = new AddService();
            addService.ShowDialog();

            Grid.DataSource = from service in Notary.Service
                              where service.NewFlag == 1
                              select new
                              {
                                  Название = service.Name,
                                  Цена = service.Price,
                                  Описание = service.Description
                              };
            Grid.Columns["Описание"].Width = 250;
        }

        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            AddDiscount addDiscount = new AddDiscount();
            addDiscount.ShowDialog();

            Grid.DataSource = from discount in Notary.Discount
                              where discount.NewFlag == 1
                              select new
                              {
                                  Название = discount.Name,
                                  Процент = discount.Percent,
                                  Описание = discount.Description
                              };
            Grid.Columns["Описание"].Visible = false;
            Grid.Columns["Название"].Width = 200;
        }

        private void Grid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string toView = "";

            for (int i = 0; i < Grid.Columns.Count; i++)
                toView += Grid.Columns[i].Name + ":  " +
                          Grid.Rows[e.RowIndex].Cells[i].Value + "\n";

            MessageBox.Show(toView, "Выбранные элемент");
        }

        private void ShowEmployeesButton_Click(object sender, EventArgs e)
        {
            Grid.DataSource = from employee in Notary.Employee
                              select new
                              {
                                  Имя = employee.Name,
                                  Зарплата = employee.Salary,
                                  Должность = employee.Post,
                                  Найм = employee.HireDate,
                                  Статус = employee.DismissalDate == null ? "Работает" :
                                  "Уволен " + employee.DismissalDate.ToString()
                              };
            Grid.Columns["Имя"].Width = 180;
            Grid.Columns["Статус"].Width = 180;
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();

            Grid.DataSource = from employee in Notary.Employee
                              where employee.DismissalDate == null
                              select new
                              {
                                  Имя = employee.Name,
                                  Зарплата = employee.Salary,
                                  Найм = employee.HireDate
                              };
        }
    }
}
