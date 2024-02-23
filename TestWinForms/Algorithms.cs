using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TestWinForms
{
    public class Algorithms
    {
        public enum Type { Client, Service, Order, Discount, Employee };
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
        public static double CalculateLastMonthlyProfit()
        {
            double profit = (from order in Notary.Order
                             where order.Date.Month == DateTime.Now.Month
                             join serv in Notary.Service on order.ServiceID equals serv.ServiceID
                             join disc in Notary.Discount on order.DiscountID equals disc.DiscountID
                             select (serv.Price - serv.Price * disc.Percent / 100)).ToList().Sum();

            return profit;
            
        }
    }
}
