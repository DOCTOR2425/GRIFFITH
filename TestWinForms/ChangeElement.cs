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
                default:
                    MessageBox.Show("Ошибка выбора типа изменяемого объекта", "Системная ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        ChangeService();

                        break;
                    case Algorithms.Type.Discount:
                        ChangeDiscount();

                        break;
                    case Algorithms.Type.Employee:
                        ChangeEmployee();

                        break;
                    case Algorithms.Type.Client:
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
                ChangeValueTB.Text = "";
                MessageBox.Show("Неверно введённые данные\nПроверьте правильность формата введённых данных",
                    "Ошибка формата данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ChangeService()
        {
            Service service = Algorithms.Notary.Service.FirstOrDefault(x => x.Name == SelectItemCB.Text
                        && x.NewFlag == 1);
            Service newServ = new Service(service);
            service.NewFlag = 0;
            
            switch (classField)
            {
                case "Название":
                    newServ.Name = ChangeValueTB.Text;
                    break;
                case "Цена":
                    newServ.Price = Convert.ToDouble(ChangeValueTB.Text);
                    break;
                case "Описание":
                    newServ.Description = ChangeValueTB.Text;
                    break;
                default:
                    MessageBox.Show("Ошибка выбора парамента изменяемого объекта", "Системная ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            Algorithms.Notary.Service.InsertOnSubmit(newServ);
        }

        private void ChangeDiscount()
        {
            Discount discount = Algorithms.Notary.Discount.FirstOrDefault(x => x.Name == SelectItemCB.Text
                        && x.NewFlag == 1);
            Discount newDisc = new Discount(discount);
            discount.NewFlag = 0;

            switch (classField)
            {
                case "Название":
                    newDisc.Name = ChangeValueTB.Text;
                    break;
                case "Процент":
                    newDisc.Percent = Convert.ToDouble(ChangeValueTB.Text);
                    break;
                case "Описание":
                    newDisc.Description = ChangeValueTB.Text;
                    break;
                default:
                    MessageBox.Show("Ошибка выбора парамента изменяемого объекта", "Системная ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            Algorithms.Notary.Discount.InsertOnSubmit(newDisc);
        }

        private void ChangeEmployee()
        {
            Employee employee = Algorithms.Notary.Employee.FirstOrDefault(x => x.Name == SelectItemCB.Text
                                    && x.DismissalDate == null);
            Employee newEmp = new Employee(employee);
            employee.DismissalDate = DateTime.Now;

            switch (classField)
            {
                case "ФИО":
                    newEmp.Name = ChangeValueTB.Text;
                    break;
                case "Зарплата":
                    newEmp.Salary = Convert.ToDouble(ChangeValueTB.Text);
                    break;
                case "Должность":
                    newEmp.Post = ChangeValueTB.Text;
                    break;
                default:
                    MessageBox.Show("Ошибка выбора парамента изменяемого объекта", "Системная ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            Algorithms.Notary.Employee.InsertOnSubmit(newEmp);
        }

        private void ChangeClient()
        {
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
                default:
                    MessageBox.Show("Ошибка выбора парамента изменяемого объекта", "Системная ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void SelectItemCB_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (typeOfElement)
            {
                case Algorithms.Type.Client:
                    {
                        Client client = Algorithms.Notary.Client.FirstOrDefault(x => x.Name == SelectItemCB.Text);

                        ItemInfoL.Text = classField + " клиента: ";

                        switch (classField)
                        {
                            case "ФИО":
                                ItemInfoL.Text += client.Name;
                                break;
                            case "Телефон":
                                ItemInfoL.Text += client.Telephone;
                                break;
                            case "Род деятельности":
                                ItemInfoL.Text += client.Activity;
                                break;
                            case "Дата рождения":
                                ItemInfoL.Text += client.BirthDate.ToString("dd.MM.yyyy");
                                break;
                            default:
                                MessageBox.Show("Ошибка выбора парамента изменяемого объекта", "Системная ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }

                        break;
                    }
                case Algorithms.Type.Service:
                    {
                        Service service = Algorithms.Notary.Service.FirstOrDefault(x => x.Name == SelectItemCB.Text
                        && x.NewFlag == 1);

                        ItemInfoL.Text = classField + " услуги: ";

                        switch (classField)
                        {
                            case "Название":
                                ItemInfoL.Text += service.Name;
                                break;
                            case "Цена":
                                ItemInfoL.Text += service.Price.ToString();
                                break;
                            case "Описание":
                                ItemInfoL.Text += service.Description;
                                break;
                            default:
                                MessageBox.Show("Ошибка выбора парамента изменяемого объекта", "Системная ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }

                        break;
                    }
                case Algorithms.Type.Discount:
                    {
                        Discount discount = Algorithms.Notary.Discount.FirstOrDefault(x => x.Name == SelectItemCB.Text
                        && x.NewFlag == 1);

                        ItemInfoL.Text = classField + " скидки: ";

                        switch (classField)
                        {
                            case "Название":
                                ItemInfoL.Text += discount.Name;
                                break;
                            case "Процент":
                                ItemInfoL.Text += discount.Percent.ToString();
                                break;
                            case "Описание":
                                ItemInfoL.Text += discount.Description;
                                break;
                            default:
                                MessageBox.Show("Ошибка выбора парамента изменяемого объекта", "Системная ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }

                        break;
                    }
                case Algorithms.Type.Employee:
                    {
                        Employee employee = Algorithms.Notary.Employee.FirstOrDefault(x => x.Name == SelectItemCB.Text
                        && x.DismissalDate == null);

                        ItemInfoL.Text = classField + " работника: ";

                        switch (classField)
                        {
                            case "ФИО":
                                ItemInfoL.Text += employee.Name;
                                break;
                            case "Зарплата":
                                ItemInfoL.Text += employee.Salary.ToString();
                                break;
                            case "Должность":
                                ItemInfoL.Text += employee.Post;
                                break;
                            default:
                                MessageBox.Show("Ошибка выбора парамента изменяемого объекта", "Системная ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }

                        break;
                    }
                default:
                    MessageBox.Show("Ошибка выбора типа изменяемого объекта", "Системная ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
