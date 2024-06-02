using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class AddServiceDiscount : Form
    {
        private readonly Algorithms.Type typeOfElement;

        public AddServiceDiscount(Algorithms.Type type)
        {
            InitializeComponent();

            typeOfElement = type;

            switch (typeOfElement)
            {
                case Algorithms.Type.Service:
                    this.Text = "Добавление услуги";
                    AddButton.Text = "Добавить услугу";
                    NameLable.Text = "Имя услуги";
                    NumberLable.Text = "Стоимость услуги";
                    DescriptionLable.Text = "Описание услуги";
                    break;
                case Algorithms.Type.Discount:
                    this.Text = "Добавление скидки";
                    AddButton.Text = "Добавить скидку";
                    NameLable.Text = "Имя скидки";
                    NumberLable.Text = "Стоимость скидки";
                    DescriptionLable.Text = "Описание скидки";
                    break;
            }
        }

        //private void DownNewFlag(object element)
        //{
        //    if (typeOfElement == Algorithms.Type.Service)
        //    {
        //        (from serv in Algorithms.Notary.Service
        //         where serv.Name == (element as Service).Name
        //         select serv).ToList().ForEach(x => x.NewFlag = 0);
        //    }
        //    else
        //    {
        //        (from disc in Algorithms.Notary.Discount
        //         where disc.Name == (element as Discount).Name
        //         select disc).ToList().ForEach(x => x.NewFlag = 0);
        //    }
        //}

        private object IsUnique(object element)
        {
            object obj = null;
            if (typeOfElement == Algorithms.Type.Service)
            {
                obj = Algorithms.Notary.Service.FirstOrDefault(x =>
                       x.Name == (element as Service).Name &&
                       x.NewFlag == 1);
            }
            else
            {
                obj = Algorithms.Notary.Discount.FirstOrDefault(x =>
                       x.Name == (element as Discount).Name &&
                       x.NewFlag == 1);
            }
            return obj;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "" || NumberTextBox.Text == "" || DescriptionTextBox.Text == "")
            {
                MessageBox.Show("Вы не ввели все данные о" +
                    (typeOfElement == Algorithms.Type.Service ? "б услуге" : " скидке"),
                                "Ошибка формата данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            if (double.TryParse(NumberTextBox.Text, out double number) == false)
            {
                NumberTextBox.Text = "";
                MessageBox.Show("Неверно введённый формат данных\nПроверьте правильность формата введённ" +
                    (typeOfElement == Algorithms.Type.Service ? "ой цены услуги" : "ого процента скидки"),
                                "Ошибка формата данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            if (number < (typeOfElement == Algorithms.Type.Service ? 20 : 1))
            {
                NumberTextBox.Text = "";
                MessageBox.Show("Неверно введённые данные\nВы ввели отрицательн" +
                    (typeOfElement == Algorithms.Type.Service ? "ую цену услуги" : "оый процент скидки"),
                                "Ошибка введённых данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            if (typeOfElement == Algorithms.Type.Service)
            {
                Service service = new Service
                {
                    Name = NameTextBox.Text,
                    Price = number,
                    Description = DescriptionTextBox.Text,
                    ServiceID = Guid.NewGuid(),
                    NewFlag = 1
                };

                if (IsUnique(service) != null)
                {
                    MessageBox.Show("Услуга с название " + service.Name + " уже есть\n" +
                        "Цена: " + ((Service)IsUnique(service)).Price + "\nОписание: " +
                        ((Service)IsUnique(service)).Description, "Ошибка добавления",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                Algorithms.Notary.Service.InsertOnSubmit(service);
            }
            else
            {
                Discount discount = new Discount
                {
                    Name = NameTextBox.Text,
                    Percent = number,
                    Description = DescriptionTextBox.Text,
                    DiscountID = Guid.NewGuid(),
                    NewFlag = 1
                };

                if (IsUnique(discount) != null)
                {
                    MessageBox.Show("Скидка с название " + discount.Name + " уже есть\n" +
                        "Процент: " + ((Discount)IsUnique(discount)).Percent + "\nОписание: " +
                        ((Discount)IsUnique(discount)).Description, "Ошибка добавления",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                Algorithms.Notary.Discount.InsertOnSubmit(discount);
            }

            Algorithms.Notary.SubmitChanges();

            this.Close();
        }
    }
}
