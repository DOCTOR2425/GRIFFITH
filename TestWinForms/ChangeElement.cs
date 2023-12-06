using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class ChangeElement : Form
    {
        private readonly Algorithms.Types typeOfElement;
        private readonly string classField;
        private List<RadioButton> radioButtons;

        public ChangeElement(Algorithms.Types type, string field)
        {
            InitializeComponent();

            typeOfElement = type;
            classField = field;

            GroupBox1.Parent = panel1;
            panel1.AutoScroll = true;

            List<string> names = new List<string>();

            switch (typeOfElement)
            {
                case Algorithms.Types.Service:
                    ChangeButton.Text = "Изменить услугу " + classField;
                    this.Text = "Изменение услуги";
                    GroupBox1.Text = "Выбор услуги";

                    names = (from service in Algorithms.Notary.Service
                             where service.NewFlag == 1
                             select service.Name).ToList();
                    break;
                case Algorithms.Types.Discount:
                    ChangeButton.Text = "Изменить скидку " + classField;
                    this.Text = "Изменение скидки";
                    GroupBox1.Text = "Выбор скидки";

                    names = (from discount in Algorithms.Notary.Discount
                             where discount.NewFlag == 1
                             select discount.Name).ToList();
                    break;
                case Algorithms.Types.Employee:
                    ChangeButton.Text = "Изменить работника " + classField;
                    this.Text = "Изменение работника";
                    GroupBox1.Text = "Выбор работника";

                    names = (from emp in Algorithms.Notary.Employee
                             where emp.DismissalDate == null
                             select emp.Name).ToList();
                    break;
                case Algorithms.Types.Client:
                    ChangeButton.Text = "Изменить клиента " + classField;
                    this.Text = "Изменение клиента";
                    GroupBox1.Text = "Выбор клиента";

                    names = (from emp in Algorithms.Notary.Client
                             select emp.Name).ToList();
                    break;
            }

            radioButtons = Algorithms.FillGroupBox(GroupBox1, names);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            switch (typeOfElement)
            {
                case Algorithms.Types.Service:
                    var services = (from serv in Algorithms.Notary.Service
                                    where serv.Name.Contains(TextBox1.Text)
                                    where serv.NewFlag == 1
                                    select serv.Name).ToList();

                    radioButtons = Algorithms.FillGroupBox(GroupBox1, services);
                    break;
                case Algorithms.Types.Discount:
                    var discounts = (from disc in Algorithms.Notary.Discount
                                     where disc.Name.Contains(TextBox1.Text)
                                     where disc.NewFlag == 1
                                     select disc.Name).ToList();

                    radioButtons = Algorithms.FillGroupBox(GroupBox1, discounts);
                    break;
                case Algorithms.Types.Employee:
                    var emploees = (from emp in Algorithms.Notary.Employee
                                    where emp.Name.Contains(TextBox1.Text)
                                    where emp.DismissalDate == null
                                    select emp.Name).ToList();

                    radioButtons = Algorithms.FillGroupBox(GroupBox1, emploees);
                    break;
                case Algorithms.Types.Client:
                    var clienst = (from clnt in Algorithms.Notary.Client
                                    where clnt.Name.Contains(TextBox1.Text)
                                    select clnt.Name).ToList();
                    radioButtons = Algorithms.FillGroupBox(GroupBox1, clienst);
                    break;
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (Algorithms.HasCheced(radioButtons) == false)
                return;
            if (ChangeTextBox.Text == "")
                return;

            try
            {
                switch (typeOfElement)
                {
                    case Algorithms.Types.Service:
                        Service services = (from serv in Algorithms.Notary.Service
                                            where serv.Name == Algorithms.GetCheckedName(radioButtons)
                                            where serv.NewFlag == 1
                                            select serv).ToList().First();

                        switch (classField)
                        {
                            case "Название":
                                services.Name = ChangeTextBox.Text;
                                break;
                            case "Цена":
                                services.Price = Convert.ToDouble(ChangeTextBox.Text);
                                break;
                            case "Описание":
                                services.Description = ChangeTextBox.Text;
                                break;
                        }

                        break;
                    case Algorithms.Types.Discount:
                        Discount discount = (from disc in Algorithms.Notary.Discount
                                             where disc.Name == Algorithms.GetCheckedName(radioButtons)
                                             where disc.NewFlag == 1
                                             select disc).ToList().First();

                        switch (classField)
                        {
                            case "Название":
                                discount.Name = ChangeTextBox.Text;
                                break;
                            case "Процент":
                                discount.Percent = Convert.ToDouble(ChangeTextBox.Text);
                                break;
                            case "Описание":
                                discount.Description = ChangeTextBox.Text;
                                break;
                        }

                        break;
                    case Algorithms.Types.Employee:
                        Employee employee = (from emp in Algorithms.Notary.Employee
                                             where emp.Name == Algorithms.GetCheckedName(radioButtons)
                                             where emp.DismissalDate == null
                                             select emp).ToList().First();

                        switch (classField)
                        {
                            case "ФИО":
                                employee.Name = ChangeTextBox.Text;
                                break;
                            case "Зарплата":
                                employee.Salary = Convert.ToDouble(ChangeTextBox.Text);
                                break;
                            case "Должность":
                                employee.Post = ChangeTextBox.Text;
                                break;
                        }

                        break;
                    case Algorithms.Types.Client:
                        Client client = (from clnt in Algorithms.Notary.Client
                                         where clnt.Name == Algorithms.GetCheckedName(radioButtons)
                                         select clnt).ToList().First();

                        switch (classField)
                        {
                            case "ФИО":
                                client.Name = ChangeTextBox.Text;
                                break;
                            case "Телефон":
                                client.Telephone = ChangeTextBox.Text;
                                break;
                            case "Род деятельности":
                                client.Activity = ChangeTextBox.Text;
                                break;
                            case "Дата рождения":
                                client.BirthDate = Convert.ToDateTime(ChangeTextBox.Text);
                                break;
                        }
                        break;
                }

                Algorithms.Notary.SubmitChanges();
                this.Close();
            }
            catch (FormatException ex)
            {
                ChangeTextBox.Text = "";
                MessageBox.Show("Неверно введённые данные\nПроверьте правильность формата введённых данных", 
                    "Ошибка формата данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
