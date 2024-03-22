using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class DeleteElement : Form
    {
        private readonly Algorithms.Type typeOfElement;

        public DeleteElement(Algorithms.Type type)
        {
            InitializeComponent();

            typeOfElement = type;

            List<string> names = new List<string>();

            switch (typeOfElement)
            {
                case Algorithms.Type.Service:
                    DeleteButton.Text = "Удалить услугу";
                    this.Text = "Удаление услуги";
                    HeaderL.Text = "Выбор услуги";

                    names = (from service in Algorithms.Notary.Service
                             where service.NewFlag == 1
                             select service.Name).ToList();
                    break;
                case Algorithms.Type.Discount:
                    DeleteButton.Text = "Удалить скидку";
                    this.Text = "Удаление скидки";
                    HeaderL.Text = "Выбор скидки";

                    names = (from discount in Algorithms.Notary.Discount
                             where discount.NewFlag == 1
                             select discount.Name).ToList();
                    break;
                case Algorithms.Type.Employee:
                    DeleteButton.Text = "Уволить работника";
                    this.Text = "Удаление работника";
                    HeaderL.Text = "Выбор работника";

                    names = (from emp in Algorithms.Notary.Employee
                             where emp.DismissalDate == null
                             select emp.Name).ToList();
                    break;
                default:
                    MessageBox.Show("Ошибка выбора типа удаляемого объекта", "Системная ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            SelectItemCB.DataSource = names;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (SelectItemCB.Text == "")
                return;

            switch (typeOfElement)
            {
                case Algorithms.Type.Service:
                    Service services = Algorithms.Notary.Service.FirstOrDefault(
                        x => x.Name == SelectItemCB.Text && x.NewFlag == 1);

                    services.NewFlag = 0;
                    break;
                case Algorithms.Type.Discount:
                    Discount discount = Algorithms.Notary.Discount.FirstOrDefault(
                        x => x.Name == SelectItemCB.Text && x.NewFlag == 1);

                    discount.NewFlag = 0;
                    break;
                case Algorithms.Type.Employee:
                    Employee employee = Algorithms.Notary.Employee.FirstOrDefault(
                        x => x.Name == SelectItemCB.Text && x.DismissalDate == null);

                    employee.DismissalDate = DateTime.Now;
                    break;
                default:
                    MessageBox.Show("Ошибка выбора типа удаляемого объекта", "Системная ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            Algorithms.Notary.SubmitChanges();
            this.Close();
        }

        private void SelectItemCB_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (typeOfElement)
            {
                case Algorithms.Type.Service:
                    ItemInfoL.Text = "Стоимость услуги: " + Algorithms.Notary.Service.FirstOrDefault(
                        x => x.Name == SelectItemCB.Text && x.NewFlag == 1).Price.ToString();

                    ItemInfo2L.Text = "Описание услуги: " + Algorithms.Notary.Service.FirstOrDefault(
                        x => x.Name == SelectItemCB.Text && x.NewFlag == 1).Description;
                    break;
                case Algorithms.Type.Discount:
                    ItemInfoL.Text = "Процент скидки: " + Algorithms.Notary.Discount.FirstOrDefault(
                        x => x.Name == SelectItemCB.Text && x.NewFlag == 1).Percent.ToString();

                    ItemInfo2L.Text = "Описание услуги: " + Algorithms.Notary.Discount.FirstOrDefault(
                        x => x.Name == SelectItemCB.Text && x.NewFlag == 1).Description;
                    break;
                case Algorithms.Type.Employee:
                    ItemInfoL.Text = "Зарплата работника: " + Algorithms.Notary.Employee.FirstOrDefault(
                        x => x.Name == SelectItemCB.Text && x.DismissalDate == null).Salary.ToString();

                    ItemInfo2L.Text = "Описание услуги: " + Algorithms.Notary.Employee.FirstOrDefault(
                        x => x.Name == SelectItemCB.Text && x.DismissalDate == null).Post;
                    break;
                default:
                    MessageBox.Show("Ошибка выбора типа удаляемого объекта", "Системная ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
