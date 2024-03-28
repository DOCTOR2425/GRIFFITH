using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TestWinForms
{
    public static class Algorithms
    {
        public enum Type { Client, Service, Order, Discount, Employee };
        public static NotaryBaseDataContext Notary = new NotaryBaseDataContext();
        
        public static IEnumerable<VisibleOrder> GetVisibleOrders()
        {
            return from order in Notary.Order
                   join serv in Notary.Service on order.ServiceID equals serv.ServiceID
                   join client in Notary.Client on order.ClientID equals client.ClientID
                   join emp in Notary.Employee on order.EmployeeID equals emp.EmployeeID
                   join discount in Notary.Discount on order.DiscountID equals discount.DiscountID
                   into discounts
                   from disc in discounts.DefaultIfEmpty()
                   select new VisibleOrder
                   {
                       Клиент = client.Name,
                       Услуга = serv.Name,
                       Нотариус = emp.Name,
                       Дата = order.Date,
                       Цена = serv.Price,
                       Скидка = disc.Percent
                   };
        }

        public static IEnumerable<VisibleService> GetVisibleServices()
        {
            return from service in Notary.Service
                   where service.NewFlag == 1
                   select new VisibleService
                   {
                       Название = service.Name,
                       Цена = service.Price,
                       Описание = service.Description
                   };
        }

        public static IEnumerable<VisibleClient> GetVisibleClients()
        {
            return from client in Notary.Client
                   select new VisibleClient
                   {
                       Имя = client.Name,
                       Дата_рождения = client.BirthDate,
                       Телефон = client.Telephone,
                       Работа = client.Activity
                   };
        }

        public static IEnumerable<VisibleDiscount> GetVisibleDiscounts()
        {
            return from discount in Notary.Discount
                   where discount.NewFlag == 1
                   select new VisibleDiscount
                   {
                       Название = discount.Name,
                       Процент = discount.Percent,
                       Описание = discount.Description
                   };
        }

        public static IEnumerable<VisibleEmployee> GetVisibleEmployees()
        {
            return from employee in Notary.Employee
                   select new VisibleEmployee
                   {
                       Имя = employee.Name,
                       Зарплата = employee.Salary,
                       Должность = employee.Post,
                       Найм = employee.HireDate,
                       Статус = employee.DismissalDate == null ? "Работает" :
                       "Уволен " + employee.DismissalDate
                   };
        }

        public static IEnumerable<Client> GetClients()
        {
            return from cl in Notary.Client select cl;
        }

        public static IEnumerable<Order> GetOrders()
        {
            return from ord in Notary.Order select ord;
        }

        public static IEnumerable<Service> GetServices()
        {
            return from serv in Notary.Service
                   where serv.NewFlag == 1
                   select serv;
        }

        public static IEnumerable<Discount> GetDiscounts()
        {
            return from disc in Notary.Discount
                   where disc.NewFlag == 1
                   select disc;
        }

        public static IEnumerable<Employee> GetEmployees()
        {
            return from emp in Notary.Employee
                   where emp.DismissalDate == null
                   select emp;
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

        public static string GetCheckedName(List<RadioButton> radioButtons)
        {
            foreach (var radiobutton in radioButtons)
                if (radiobutton.Checked)
                    return radiobutton.Text;

            return null;
        }

        public static double CalculateLastMonthlyProfit()
        {
            double profit = (from order in Notary.Order
                             where order.Date.Month == DateTime.Now.Month
                             join serv in Notary.Service on order.ServiceID equals serv.ServiceID
                             join disc in Notary.Discount on order.DiscountID equals disc.DiscountID
                             select (serv.Price - (serv.Price * disc.Percent / 100))).ToList().Sum();

            return profit;
        }

        public static string ToUpperFirstLetter(string source)
        {
            if (string.IsNullOrEmpty(source))
                return string.Empty;

            char[] letters = source.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);

            return new string(letters);
        }
    }
}
