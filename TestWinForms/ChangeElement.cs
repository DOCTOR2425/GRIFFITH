using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class ChangeElement : Form// TODO сделать маску комбобоксам (по возможности)
    {
        private object objToChange;

        public ChangeElement(object objToChange)
        {
            InitializeComponent();

            this.objToChange = objToChange;
            
            FillLabels();
            FillComboBoxesCollection();
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

        private void FillComboBoxesCollection()
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
                    case "Order":
                        ChangeOrder();
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

        private void ChangeOrder()
        {
            (objToChange as Order).Service = Algorithms.Notary.Service.FirstOrDefault(x=>
            x.Name == Field1CB.Text && x.NewFlag == 1);

            (objToChange as Order).Discount = Algorithms.Notary.Discount.FirstOrDefault(x =>
            x.Name == Field2CB.Text && (x.NewFlag == 1 || x.Name == "ZERO"));

            (objToChange as Order).Employee = Algorithms.Notary.Employee.FirstOrDefault(x =>
            x.Name == Field3CB.Text && x.DismissalDate == null);
        }

        private void ChangeService()
        {
            (objToChange as Service).NewFlag = 0;

            Service newServ = new Service()
            {
                Name = Field1CB.Text,
                Price = Convert.ToDouble(Field2CB.Text),
                Description = Field3CB.Text,
                NewFlag = 1
            };

            Algorithms.Notary.Service.InsertOnSubmit(newServ);
        }

        private void ChangeDiscount()
        {
            (objToChange as Discount).NewFlag = 0;

            Discount newDisc = new Discount()
            {
                Name = Field1CB.Text,
                Percent = Convert.ToDouble(Field2CB.Text),
                Description = Field3CB.Text,
                NewFlag = 1
            };

            Algorithms.Notary.Discount.InsertOnSubmit(newDisc);
        }

        private void ChangeEmployee()
        {
            (objToChange as Employee).DismissalDate = DateTime.Now;

            Employee newEmp = new Employee()
            {
                Name = Field1CB.Text,
                Salary = Convert.ToDouble(Field2CB.Text),
                Post = Field3CB.Text,
                HireDate = (objToChange as Employee).HireDate
            };

            Algorithms.Notary.Employee.InsertOnSubmit(newEmp);
        }

        private void ChangeClient()
        {
            (objToChange as Client).Name = Field1CB.Text;
            (objToChange as Client).Telephone = Field2CB.Text;
            (objToChange as Client).Activity = Field3CB.Text;
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
