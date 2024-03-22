using System;

namespace TestWinForms
{
    public abstract class Visible<T> where T : Visible<T>
    {
        public static string[] GetFieldsName()
        {
            string[] fields = new string[typeof(T).GetProperties().Length];

            for (int i = 0; i < fields.Length; i++)
                fields[i] = typeof(T).GetProperties()[i].Name;

            return fields;
        }
    }
    public class VisibleClient : Visible<VisibleClient>
    {
        public string Имя { get; set; }
        public DateTime Дата_рождения { get; set; }
        public string Телефон { get; set; }
        public string Работа { get; set; }
    }
    public class VisibleService : Visible<VisibleService>
    {
        public string Название { get; set; }
        public double Цена { get; set; }
        public string Описание { get; set; }
    }
    public class VisibleDiscount : Visible<VisibleDiscount>
    {
        public string Название { get; set; }
        public double Процент { get; set; }
        public string Описание { get; set; }
    }
    public class VisibleEmployee : Visible<VisibleEmployee>
    {
        public string Имя { get; set; }
        public double Зарплата { get; set; }
        public string Должность { get; set; }
        public DateTime Найм { get; set; }
        public string Статус { get; set; }
    }
    public class VisibleOrder : Visible<VisibleOrder>
    {
        public string Клиент { get; set; }
        public string Услуга { get; set; }
        public string Нотариус { get; set; }
        public DateTime Дата { get; set; }
        public double Цена { get; set; }
        public double Скидка { get; set; }
    }
    
}
