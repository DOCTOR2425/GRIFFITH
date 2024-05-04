using System;
using System.Collections.Generic;
using System.Linq;

namespace TestWinForms
{
    public static class Algorithms
    {
        public enum Type { Client, Service, Order, Discount, Employee };
        public static NotaryBaseDataContext Notary = new NotaryBaseDataContext();
        
        public static IEnumerable<VisibleOrder> GetVisibleOrders()
        {
            return from order in Notary.Order
                   select new VisibleOrder
                   {
                       Клиент = order.Client.Name,
                       Услуга = order.Service.Name,
                       Нотариус = order.Employee.Name,
                       Дата = order.Date,
                       Цена = order.Service.Price,
                       Скидка = order.Discount.Percent
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

        public static double CalculateLastMonthlyProfit()
        {
            double profit = (from order in Notary.Order
                             where order.Date.Month == DateTime.Now.Month
                             select (order.Service.Price - (order.Service.Price * order.Discount.Percent / 100))).ToList().Sum();

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
