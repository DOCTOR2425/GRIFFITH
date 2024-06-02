using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class ChangeElement : Form
    {
        private object objToChange;

        public ChangeElement(object objToChange)
        {
            InitializeComponent();

            this.objToChange = objToChange;

            FillLabels();
            FillComboBoxes();
            ResetChangesB_Click(new object(), new EventArgs());
        }

        private void FillLabels()
        {
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
                    Field1L.Text = "Название услуги";
                    Field2L.Text = "Название скики";
                    Field3L.Text = "Имя работника";

                    break;
                default:
                    MessageBox.Show("Ошибка выбора типа изменяемого объекта", "Системная ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    break;
            }
        }

        private void FillComboBoxes()
        {
            switch (objToChange.GetType().Name)
            {
                case "Service":
                case "Discount":
                case "Employee":
                case "Client":
                    Field1CB.DataBindings.Clear();
                    Field2CB.DataBindings.Clear();
                    Field3CB.DataBindings.Clear();

                    break;
                case "Order":
                    Field1CB.DataSource = from obj in Algorithms.Notary.Service
                                          where obj.NewFlag == 1
                                          select obj.Name;

                    Field2CB.DataSource = from obj in Algorithms.Notary.Discount
                                          where obj.NewFlag == 1 || obj.Name == "ZERO"
                                          select obj.Name;

                    Field3CB.DataSource = from obj in Algorithms.Notary.Employee
                                          where obj.DismissalDate == null
                                          where obj.Post == "Нотариус"
                                          select obj.Name;

                    break;
                default:
                    MessageBox.Show("Ошибка выбора типа изменяемого объекта", "Системная ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    break;
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (Field1CB.Text == "" || Field2CB.Text == "" || Field3CB.Text == "")
            {
                MessageBox.Show("Вы не ввели новые данные об объекте изменения", "Нет данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isComplite = false;
            try
            {
                switch (objToChange.GetType().Name)
                {
                    case "Service":
                        isComplite = ChangeService();
                        break;
                    case "Discount":
                        isComplite = ChangeDiscount();
                        break;
                    case "Employee":
                        isComplite = ChangeEmployee();
                        break;
                    case "Client":
                        isComplite = ChangeClient();
                        break;
                    case "Order":
                        isComplite = ChangeOrder();
                        break;
                    default:
                        MessageBox.Show("Ошибка выбора типа изменяемого объекта", "Системная ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                if (isComplite == false)
                    return;

                Algorithms.Notary.SubmitChanges();
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверно введённые данные\nПроверьте правильность формата введённых данных",
                    "Ошибка формата данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool ChangeOrder()
        {
            (objToChange as Order).Service = Algorithms.Notary.Service.FirstOrDefault(x =>
            x.Name == Field1CB.Text && x.NewFlag == 1);

            (objToChange as Order).Discount = Algorithms.Notary.Discount.FirstOrDefault(x =>
            x.Name == Field2CB.Text && (x.NewFlag == 1 || x.Name == "ZERO"));

            (objToChange as Order).Employee = Algorithms.Notary.Employee.FirstOrDefault(x =>
            x.Name == Field3CB.Text && x.DismissalDate == null);

            return true;
        }

        private bool ChangeService()
        {
            if (ValidateNumber(20) == false)
            {
                MessageBox.Show("Неверно введённые данные о цене услуги\nВы ввели отрицательную или нулевую цену",
                "Ошибка данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            (objToChange as Service).NewFlag = 0;

            Service newServ = new Service()
            {
                Name = Field1CB.Text,
                Price = Convert.ToDouble(Field2CB.Text),
                Description = Field3CB.Text,
                NewFlag = 1,
                ServiceID = Guid.NewGuid()
            };

            Algorithms.Notary.Service.InsertOnSubmit(newServ);

            return true;
        }

        private bool ChangeDiscount()
        {
            if (ValidateNumber(1) == false)
            {
                Field2CB.Text = (objToChange as Discount).Percent.ToString();
                MessageBox.Show("Неверно введённые данные о проценте скидки\nВы ввели отрицательный или нулевой процент",
                    "Ошибка данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            (objToChange as Discount).NewFlag = 0;

            Discount newDisc = new Discount()
            {
                Name = Field1CB.Text,
                Percent = Convert.ToDouble(Field2CB.Text),
                Description = Field3CB.Text,
                NewFlag = 1,
                DiscountID = Guid.NewGuid()
            };

            Algorithms.Notary.Discount.InsertOnSubmit(newDisc);

            return true;
        }

        private bool ChangeEmployee()
        {
            if (ValidateName() == false)
            {
                Field1CB.Text = (objToChange as Employee).Name;
                MessageBox.Show("Неверно введённая данные ФИО работника\nПроверьте правильность введённого ФИО работника",
                    "Ошибка формата данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            if (ValidateNumber(600) == false)
            {
                Field2CB.Text = (objToChange as Employee).Salary.ToString();
                MessageBox.Show("Неверно введённые данные о зарплате\n" +
                    "Вы ввели отрицательную или нулевую зарплату или неверный формат данных",
                    "Ошибка данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            (objToChange as Employee).Name = Field1CB.Text;
            (objToChange as Employee).Salary = Convert.ToDouble(Field2CB.Text);
            (objToChange as Employee).Post = Field3CB.Text;

            return true;
        }
        private bool ValidateNumber(int number)
        {
            if (double.TryParse(Field2CB.Text, out _) == false)
                return false;
            if (Convert.ToDouble(Field2CB.Text) < number)
                return false;

            return true;
        }

        private bool ChangeClient()
        {
            if (ValidateName() == false)
            {
                Field1CB.Text = (objToChange as Client).Name;
                MessageBox.Show("Неверно введённая данные ФИО клиента\nПроверьте правильность введённого ФИО клиента",
                    "Ошибка формата данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ValidateClientTelephone() == false)
            {
                Field2CB.Text = (objToChange as Client).Telephone;
                MessageBox.Show("Неверно введённая данные номера телефона\nПроверьте правильность введённого номера телефона",
                "Ошибка формата данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            (objToChange as Client).Name = Field1CB.Text;
            (objToChange as Client).Telephone = Field2CB.Text;
            (objToChange as Client).Activity = Field3CB.Text;

            return true;
        }
        private bool ValidateClientTelephone()
        {
            Regex regex = new Regex(@"^\+375\s\(((29)|(33)|(25)|(44))\)\s\d{3}-\d{2}-\d{2}$");
            if (regex.IsMatch(Field2CB.Text) == false)
                return false;
            return true;
        }
        private bool ValidateName()
        {
            if (Field1CB.Text.Contains(" ") == false)
                return false;
            else if (Field1CB.Text.Length < 6)
                return false;

            foreach (char s in Field1CB.Text)
                if (Char.IsDigit(s))
                    return false;

            return true;
        }

        private void ResetChangesB_Click(object sender, EventArgs e)
        {
            switch (objToChange.GetType().Name)
            {
                case "Service":
                    Field1CB.Text = (objToChange as Service).Name;
                    Field2CB.Text = (objToChange as Service).Price.ToString();
                    Field3CB.Text = (objToChange as Service).Description;

                    break;
                case "Discount":
                    Field1CB.Text = (objToChange as Discount).Name;
                    Field2CB.Text = (objToChange as Discount).Percent.ToString();
                    Field3CB.Text = (objToChange as Discount).Description;

                    break;
                case "Employee":
                    Field1CB.Text = (objToChange as Employee).Name;
                    Field2CB.Text = (objToChange as Employee).Salary.ToString();
                    Field3CB.Text = (objToChange as Employee).Post;

                    break;
                case "Client":
                    Field1CB.Text = (objToChange as Client).Name;
                    Field2CB.Text = (objToChange as Client).Telephone;
                    Field3CB.Text = (objToChange as Client).Activity;

                    break;
                case "Order":
                    Field1CB.Text = (objToChange as Order).Service.Name;
                    Field2CB.Text = (objToChange as Order).Discount.Name;
                    Field3CB.Text = (objToChange as Order).Employee.Name;

                    break;
            }
        }
    }
}
