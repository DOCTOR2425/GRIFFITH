using System;

namespace TestWinForms
{
    public abstract class Visible
    {
        public static string[] GetFieldsName() { return new string[] { }; }
    }
    public class VisibleClient : Visible
    {
        public string Имя { get; set; }
        public DateTime Дата_рождения { get; set; }
        public string Телефон { get; set; }
        public string Работа { get; set; }

        public new static string[] GetFieldsName()
        {
            string[] fields = new string[typeof(VisibleClient).GetProperties().Length];

            for (int i = 0; i < fields.Length; i++)
                fields[i] = typeof(VisibleClient).GetProperties()[i].Name;

            return fields;
        }
    }
    public class VisibleService : Visible
    {
        public string Название { get; set; }
        public double Цена { get; set; }
        public string Описание { get; set; }

        public new static string[] GetFieldsName()
        {
            string[] fields = new string[typeof(VisibleService).GetProperties().Length];

            for (int i = 0; i < fields.Length; i++)
                fields[i] = typeof(VisibleService).GetProperties()[i].Name;

            return fields;
        }
    }
    public class VisibleDiscount : Visible
    {
        public string Название { get; set; }
        public double Процент { get; set; }
        public string Описание { get; set; }

        public new static string[] GetFieldsName()
        {
            string[] fields = new string[typeof(VisibleDiscount).GetProperties().Length];

            for (int i = 0; i < fields.Length; i++)
                fields[i] = typeof(VisibleDiscount).GetProperties()[i].Name;

            return fields;
        }
    }
    public class VisibleEmployee : Visible
    {
        public string Имя { get; set; }
        public double Зарплата { get; set; }
        public string Должность { get; set; }
        public DateTime Найм { get; set; }
        public string Статус { get; set; }

        public new static string[] GetFieldsName()
        {
            string[] fields = new string[typeof(VisibleEmployee).GetProperties().Length];

            for (int i = 0; i < fields.Length; i++)
                fields[i] = typeof(VisibleEmployee).GetProperties()[i].Name;

            return fields;
        }
    }
    public class VisibleOrder : Visible
    {
        public string Клиент { get; set; }
        public string Услуга { get; set; }
        public string Нотариус { get; set; }
        public DateTime Дата { get; set; }
        public double Цена { get; set; }
        public double Итого { get; set; }
        public double Скидка { get; set; }

        public new static string[] GetFieldsName()
        {
            string[] fields = new string[typeof(VisibleOrder).GetProperties().Length];

            for (int i = 0; i < fields.Length; i++)
                fields[i] = typeof(VisibleOrder).GetProperties()[i].Name;

            return fields;
        }
    }
}
