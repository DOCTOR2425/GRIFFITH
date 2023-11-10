using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class AddServiceDiscount : Form
    {
        private NotaryBaseDataContext Notary = new NotaryBaseDataContext();
        private readonly Algorithms.Types typeOfElement;

        public AddServiceDiscount(Algorithms.Types type)
        {
            InitializeComponent();

            typeOfElement = type;

            switch (typeOfElement)
            {
                case Algorithms.Types.Service:
                    this.Text = "Добавление услуги";
                    AddButton.Text = "Добавить услугу";
                    NameLable.Text = "Имя услуги";
                    NumberLable.Text = "Стоимость услуги";
                    DescriptionLable.Text = "Описание услуги";
                    break;
                case Algorithms.Types.Discount:
                    this.Text = "Добавление скидки";
                    AddButton.Text = "Добавить скидку";
                    NameLable.Text = "Имя скидки";
                    NumberLable.Text = "Стоимость скидки";
                    DescriptionLable.Text = "Описание скидки";
                    break;
            }
        }

        private void DownNewFlag(object element)
        {
            if (typeOfElement == Algorithms.Types.Service)
            {
                (from serv in Algorithms.Notary.Service
                 where serv.Name == (element as Service).Name
                 select serv).ToList().ForEach(x => x.NewFlag = 0);

                return;
            }
             (from disc in Algorithms.Notary.Discount
              where disc.Name == (element as Discount).Name
              select disc).ToList().ForEach(x => x.NewFlag = 0);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "" || NumberTextBox.Text == "" || DescriptionTextBox.Text == "")
                return;

            double number;
            if (double.TryParse(NumberTextBox.Text, out number) == false)
                return;

            if(typeOfElement == Algorithms.Types.Service)
            {
                Service service = new Service();
                service.Name = NameTextBox.Text;
                service.Price = number;
                service.Description = DescriptionTextBox.Text;
                service.ServiceID = Guid.NewGuid();
                service.NewFlag = 1;

                DownNewFlag(service);

                Algorithms.Notary.Service.InsertOnSubmit(service);
            }
            else
            {
                Discount discount = new Discount();
                discount.Name = NameTextBox.Text;
                discount.Percent = number;
                discount.Description = DescriptionTextBox.Text;
                discount.DiscountID = Guid.NewGuid();
                discount.NewFlag = 1;

                DownNewFlag(discount);

                Algorithms.Notary.Discount.InsertOnSubmit(discount);
            }

            Algorithms.Notary.SubmitChanges();

            this.Close();
        }
    }
}
