using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class ChangeElement : Form// TODO добавить изменение заказа
    {
        private object objToChange;

        public ChangeElement(object objToChange)
        {
            InitializeComponent();

            this.objToChange = objToChange;
            switch (objToChange.GetType().Name)
            {
                case "Service":
                    ChangeButton.Text = "Изменить услуги";
                    this.Text = "Изменение услуги";
                    Field1L.Text = "Название услуги";
                    Field2L.Text = "Цена услуги";
                    Field3L.Text = "Описание услуги";

                    break;
                case "Discount":
                    ChangeButton.Text = "Изменить скидки";
                    this.Text = "Изменение скидки";
                    Field1L.Text = "Название скидки";
                    Field2L.Text = "Цена скидки";
                    Field3L.Text = "Описание скидки";

                    break;
                case "Employee":
                    ChangeButton.Text = "Изменить работника";
                    this.Text = "Изменение работника";
                    Field1L.Text = "Имя работника";
                    Field2L.Text = "Зарплата работника";
                    Field3L.Text = "Должность работника";

                    break;
                case "Client":
                    ChangeButton.Text = "Изменить клиента";
                    this.Text = "Изменение клиента";
                    Field1L.Text = "Имя клиента";
                    Field2L.Text = "Телефон клиента";
                    Field3L.Text = "Работа клиента";

                    break;
                case "Order":
                    ChangeButton.Text = "Изменить заказ";
                    this.Text = "Изменение заказа";
                    Field1L.Text = "Имя клиента";
                    Field2L.Text = "Телефон клиента";
                    Field3L.Text = "Работа клиента";

                    break;
                default:
                    MessageBox.Show("Ошибка выбора типа изменяемого объекта", "Системная ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    break;
            }
            SetDefaultValue();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (Field1TB.Text == "" || Field2TB.Text == "" || Field3TB.Text == "")
            {
                MessageBox.Show("Вы не ввели новые данные об объекте изменения", "Нет данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                switch (objToChange.GetType().Name)
                {
                    case "Service":
                        ChangeService();

                        break;
                    case "Discount":
                        ChangeDiscount();

                        break;
                    case "Employee":
                        ChangeEmployee();

                        break;
                    case "Client":
                        ChangeClient();

                        break;
                    default:
                        MessageBox.Show("Ошибка выбора типа изменяемого объекта", "Системная ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                Algorithms.Notary.SubmitChanges();
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверно введённые данные\nПроверьте правильность формата введённых данных",
                    "Ошибка формата данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SetDefaultValue()
        {
            switch (objToChange.GetType().Name)
            {
                case "Service":
                    Field1TB.Text = (objToChange as Service).Name;
                    Field2TB.Text = (objToChange as Service).Price.ToString();
                    Field3TB.Text = (objToChange as Service).Description;

                    break;
                case "Discount":
                    Field1TB.Text = (objToChange as Discount).Name;
                    Field2TB.Text = (objToChange as Discount).Percent.ToString();
                    Field3TB.Text = (objToChange as Discount).Description;

                    break;
                case "Employee":
                    Field1TB.Text = (objToChange as Employee).Name;
                    Field2TB.Text = (objToChange as Employee).Salary.ToString();
                    Field3TB.Text = (objToChange as Employee).Post;

                    break;
                case "Client":
                    Field1TB.Text = (objToChange as Client).Name;
                    Field2TB.Text = (objToChange as Client).Telephone;
                    Field3TB.Text = (objToChange as Client).Activity;

                    break;
            }
        }

        private void ChangeService()
        {
            (objToChange as Service).NewFlag = 0;

            Service newServ = new Service()
            {
                Name = Field1TB.Text,
                Price = Convert.ToDouble(Field2TB.Text),
                Description = Field3TB.Text,
                NewFlag = 1
            };

            Algorithms.Notary.Service.InsertOnSubmit(newServ);
        }

        private void ChangeDiscount()
        {
            (objToChange as Discount).NewFlag = 0;

            Discount newDisc = new Discount()
            {
                Name = Field1TB.Text,
                Percent = Convert.ToDouble(Field2TB.Text),
                Description = Field3TB.Text,
                NewFlag = 1
            };

            Algorithms.Notary.Discount.InsertOnSubmit(newDisc);
        }

        private void ChangeEmployee()
        {
            (objToChange as Employee).DismissalDate = DateTime.Now;

            Employee newEmp = new Employee()
            {
                Name = Field1TB.Text,
                Salary = Convert.ToDouble(Field2TB.Text),
                Post = Field3TB.Text,
                HireDate = (objToChange as Employee).HireDate
            };

            Algorithms.Notary.Employee.InsertOnSubmit(newEmp);
        }

        private void ChangeClient()
        {
            (objToChange as Client).Name = Field1TB.Text;
            (objToChange as Client).Telephone = Field2TB.Text;
            (objToChange as Client).Activity = Field3TB.Text;
        }

        private void ResetChangesB_Click(object sender, EventArgs e)
        {
            switch (objToChange.GetType().Name)
            {
                case "Service":
                    Field1TB.Text = (objToChange as Service).Name;
                    Field2TB.Text = (objToChange as Service).Price.ToString();
                    Field3TB.Text = (objToChange as Service).Description;

                    break;
                case "Discount":
                    Field1TB.Text = (objToChange as Discount).Name;
                    Field2TB.Text = (objToChange as Discount).Percent.ToString();
                    Field3TB.Text = (objToChange as Discount).Description;

                    break;
                case "Employee":
                    Field1TB.Text = (objToChange as Employee).Name;
                    Field2TB.Text = (objToChange as Employee).Salary.ToString();
                    Field3TB.Text = (objToChange as Employee).Post;

                    break;
                case "Client":
                    Field1TB.Text = (objToChange as Client).Name;
                    Field2TB.Text = (objToChange as Client).Telephone;
                    Field3TB.Text = (objToChange as Client).Activity;

                    break;
                default:
                    MessageBox.Show("Ошибка выбора типа изменяемого объекта", "Системная ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
