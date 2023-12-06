using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace TestWinForms
{
    public partial class DeleteElement : Form
    {
        private readonly Algorithms.Types typeOfElement;
        private List<RadioButton> radioButtons;

        public DeleteElement(Algorithms.Types type)
        {
            InitializeComponent();

            typeOfElement = type;

            GroupBox1.Parent = panel1;
            panel1.AutoScroll = true;

            List<string> names = new List<string>();

            switch (typeOfElement)
            {
                case Algorithms.Types.Service:
                    DeleteButton.Text = "Удалить услугу";
                    this.Text = "Удаление услуги";
                    GroupBox1.Text = "Выбор услуги";

                    names = (from service in Algorithms.Notary.Service
                              where service.NewFlag == 1
                              select service.Name).ToList();
                    break;
                case Algorithms.Types.Discount:
                    DeleteButton.Text = "Удалить скидку";
                    this.Text = "Удаление скидки";
                    GroupBox1.Text = "Выбор скидки";

                    names = (from discount in Algorithms.Notary.Discount
                              where discount.NewFlag == 1
                              select discount.Name).ToList();
                    break;
                case Algorithms.Types.Employee:
                    DeleteButton.Text = "Уволить работника";
                    this.Text = "Удаление работника";
                    GroupBox1.Text = "Выбор работника";

                    names = (from emp in Algorithms.Notary.Employee
                              where emp.DismissalDate == null
                              select emp.Name).ToList();
                    break;
            }
            radioButtons = Algorithms.FillGroupBox(GroupBox1, names);
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Algorithms.HasCheced(radioButtons) == false)
                return;

            switch (typeOfElement)
            {
                case Algorithms.Types.Service:
                    Service services = (from serv in Algorithms.Notary.Service
                                        where serv.NewFlag == 1
                                        where serv.Name == Algorithms.GetCheckedName(radioButtons)
                                        select serv).ToList().First();

                    services.NewFlag = 0;

                    break;
                case Algorithms.Types.Discount:
                    Discount discount = (from disc in Algorithms.Notary.Discount
                                         where disc.NewFlag == 1
                                         where disc.Name == Algorithms.GetCheckedName(radioButtons)
                                         select disc).ToList().First();

                    discount.NewFlag = 0;

                    break;
                case Algorithms.Types.Employee:
                    Employee employee = (from emp in Algorithms.Notary.Employee
                                         where emp.DismissalDate == null
                                         where emp.Name == Algorithms.GetCheckedName(radioButtons)
                                         select emp).ToList().First();

                    employee.DismissalDate = DateTime.Now;

                    break;
            }
            Algorithms.Notary.SubmitChanges();
            this.Close();
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
            }
        }
    }
}
