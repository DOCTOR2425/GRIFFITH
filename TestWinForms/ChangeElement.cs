using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class ChangeElement : Form
    {
        private readonly Algorithms.Type typeOfElement;
        private readonly string classField;

        public ChangeElement(Algorithms.Type type, string field)
        {
            InitializeComponent();

            typeOfElement = type;
            classField = field;

            List<string> names = new List<string>();

            switch (typeOfElement)
            {
                case Algorithms.Type.Service:
                    ChangeButton.Text = "Изменить " + classField + " услуги";
                    this.Text = "Изменение услуги";
                    HeaderL.Text = "Выбор услуги";

                    names = (from service in Algorithms.Notary.Service
                             where service.NewFlag == 1
                             select service.Name).ToList();
                    break;
                case Algorithms.Type.Discount:
                    ChangeButton.Text = "Изменить " + classField + " скидки";
                    this.Text = "Изменение скидки";
                    HeaderL.Text = "Выбор скидки";

                    names = (from discount in Algorithms.Notary.Discount
                             where discount.NewFlag == 1
                             select discount.Name).ToList();
                    break;
                case Algorithms.Type.Employee:
                    ChangeButton.Text = "Изменить " + classField + " работника";
                    this.Text = "Изменение работника";
                    HeaderL.Text = "Выбор работника";

                    names = (from emp in Algorithms.Notary.Employee
                             where emp.DismissalDate == null
                             select emp.Name).ToList();
                    break;
                case Algorithms.Type.Client:
                    ChangeButton.Text = "Изменить " + classField + " клиента";
                    this.Text = "Изменение клиента";
                    HeaderL.Text = "Выбор клиента";

                    names = (from emp in Algorithms.Notary.Client
                             select emp.Name).ToList();
                    break;
            }

            SelectItemCB.DataSource = names;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {

            if (SelectItemCB.Text == "")
            {
                MessageBox.Show("Вы не выбрали объект для изменения", "Нет данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ChangeValueTB.Text == "")
            {
                MessageBox.Show("Вы не ввели новые данные", "Нет данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                switch (typeOfElement)
                {
                    case Algorithms.Type.Service:
                        Service service = Algorithms.Notary.Service.FirstOrDefault(x => x.Name == SelectItemCB.Text
                        && x.NewFlag == 1);

                        switch (classField)
                        {
                            case "Название":
                                service.Name = ChangeValueTB.Text;
                                break;
                            case "Цена":
                                service.Price = Convert.ToDouble(ChangeValueTB.Text);
                                break;
                            case "Описание":
                                service.Description = ChangeValueTB.Text;
                                break;
                        }

                        break;
                    case Algorithms.Type.Discount:
                        Discount discount = Algorithms.Notary.Discount.FirstOrDefault(x => x.Name == SelectItemCB.Text
                        && x.NewFlag == 1);

                        switch (classField)
                        {
                            case "Название":
                                discount.Name = ChangeValueTB.Text;
                                break;
                            case "Процент":
                                discount.Percent = Convert.ToDouble(ChangeValueTB.Text);
                                break;
                            case "Описание":
                                discount.Description = ChangeValueTB.Text;
                                break;
                        }

                        break;
                    case Algorithms.Type.Employee:
                        Employee employee = Algorithms.Notary.Employee.FirstOrDefault(x => x.Name == SelectItemCB.Text
                        && x.DismissalDate == null);

                        switch (classField)
                        {
                            case "ФИО":
                                employee.Name = ChangeValueTB.Text;
                                break;
                            case "Зарплата":
                                employee.Salary = Convert.ToDouble(ChangeValueTB.Text);
                                break;
                            case "Должность":
                                employee.Post = ChangeValueTB.Text;
                                break;
                        }

                        break;
                    case Algorithms.Type.Client:
                        Client client = Algorithms.Notary.Client.FirstOrDefault(x => x.Name == SelectItemCB.Text);

                        switch (classField)
                        {
                            case "ФИО":
                                client.Name = ChangeValueTB.Text;
                                break;
                            case "Телефон":
                                client.Telephone = ChangeValueTB.Text;
                                break;
                            case "Род деятельности":
                                client.Activity = ChangeValueTB.Text;
                                break;
                            case "Дата рождения":
                                client.BirthDate = Convert.ToDateTime(ChangeValueTB.Text);
                                break;
                        }
                        break;
                }

                Algorithms.Notary.SubmitChanges();
                this.Close();
            }
            catch (FormatException)
            {
                ChangeValueTB.Text = "";
                MessageBox.Show("Неверно введённые данные\nПроверьте правильность формата введённых данных",
                    "Ошибка формата данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SelectItemCB_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (typeOfElement)
            {
                case Algorithms.Type.Client:
                    {
                        Client client = Algorithms.Notary.Client.FirstOrDefault(x => x.Name == SelectItemCB.Text);

                        ItemValueL.Text = classField + " клиента: ";

                        switch (classField)
                        {
                            case "ФИО":
                                ItemValueL.Text += client.Name;
                                break;
                            case "Телефон":
                                ItemValueL.Text += client.Telephone;
                                break;
                            case "Род деятельности":
                                ItemValueL.Text += client.Activity;
                                break;
                            case "Дата рождения":
                                ItemValueL.Text += client.BirthDate.ToString("dd.MM.yyyy");
                                break;
                        }

                        break;
                    }
                case Algorithms.Type.Service:
                    {
                        Service service = Algorithms.Notary.Service.FirstOrDefault(x => x.Name == SelectItemCB.Text
                        && x.NewFlag == 1);

                        ItemValueL.Text = classField + " услуги: ";

                        switch (classField)
                        {
                            case "Название":
                                ItemValueL.Text += service.Name;
                                break;
                            case "Цена":
                                ItemValueL.Text += service.Price.ToString();
                                break;
                            case "Описание":
                                ItemValueL.Text += service.Description;
                                break;
                        }

                        break;
                    }
                case Algorithms.Type.Discount:
                    {
                        Discount discount = Algorithms.Notary.Discount.FirstOrDefault(x => x.Name == SelectItemCB.Text
                        && x.NewFlag == 1);

                        ItemValueL.Text = classField + " скидки: ";

                        switch (classField)
                        {
                            case "Название":
                                ItemValueL.Text += discount.Name;
                                break;
                            case "Процент":
                                ItemValueL.Text += discount.Percent.ToString();
                                break;
                            case "Описание":
                                ItemValueL.Text += discount.Description;
                                break;
                        }

                        break;
                    }
                case Algorithms.Type.Employee:
                    {
                        Employee employee = Algorithms.Notary.Employee.FirstOrDefault(x => x.Name == SelectItemCB.Text
                        && x.DismissalDate == null);

                        ItemValueL.Text = classField + " работника: ";

                        switch (classField)
                        {
                            case "ФИО":
                                ItemValueL.Text += employee.Name;
                                break;
                            case "Зарплата":
                                ItemValueL.Text += employee.Salary.ToString();
                                break;
                            case "Должность":
                                ItemValueL.Text += employee.Post;
                                break;
                        }

                        break;
                    }
            }
        }
    }
}
