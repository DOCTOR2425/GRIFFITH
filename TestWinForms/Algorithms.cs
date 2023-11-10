using System.Collections.Generic;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestWinForms
{
    public class Algorithms
    {
        public enum Types { Client, Service, Order, Discount, Employee };
        public static readonly NotaryBaseDataContext Notary = new NotaryBaseDataContext();

        public static void ShowOrders(DataGridView Grid)
        {
            Grid.DataSource = from order in Notary.Order
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
                                  Скидка = disc.Percent
                              };

            Grid.Columns["Клиент"].Width = 150;
            Grid.Columns["Цена"].Width = 50;
            Grid.Columns["Нотариус"].Width = 150;
            Grid.Columns["Дата"].Width = 80;
            Grid.Columns["Скидка"].Width = 70;
            Grid.Columns["Услуга"].Width = 150;
        }
        public static void ShowService(DataGridView Grid)
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
        public static void ShowClient(DataGridView Grid)
        {
            Grid.DataSource = from client in Notary.Client
                              select new
                              {
                                  Имя = client.Name,
                                  Дата_рождения = client.BirthDate,
                                  Телефон = client.Telephone,
                                  Работа = client.Activity
                              };
            Grid.Columns["Имя"].Width = 150;
        }
        public static void ShowDiscount(DataGridView Grid)
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
        public static void ShowEmployee(DataGridView Grid)
        {
            Grid.DataSource = from employee in Notary.Employee
                              select new
                              {
                                  Имя = employee.Name,
                                  Зарплата = employee.Salary,
                                  Должность = employee.Post,
                                  Найм = employee.HireDate,
                                  Статус = employee.DismissalDate == null ? "Работает" :
                                  "Уволен " + employee.DismissalDate
                              };
            Grid.Columns["Имя"].Width = 180;
            Grid.Columns["Статус"].Width = 180;
        }
        public static List<RadioButton> FillGroupBox(GroupBox groupBox, List<string> names)
        {
            groupBox.Controls.Clear();

            var list = new List<RadioButton>(names.Count);

            Point GBLoc = groupBox.Location;

            for (int i = 0; i < names.Count; i++)
            {
                list.Add(new RadioButton());
                list[i].Text = names[i];
                list[i].Parent = groupBox;
                list[i].Location = new Point(5, GBLoc.Y + 20 * (i + 1));
            }

            return list;
        }
        public static bool HasCheced(List<RadioButton> radioButtons)
        {
            foreach (var radiobutton in radioButtons)
                if (radiobutton.Checked)
                    return true;

            return false;
        }
        public static string GetCheckedName(List<RadioButton> radioButtons)
        {
            foreach (var radiobutton in radioButtons)
                if (radiobutton.Checked)
                    return radiobutton.Text;

            return "";
        }
    }
}
