using System;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class AddClientToOrder : Form
    {
        private Client client;

        public AddClientToOrder(Client client)
        {
            InitializeComponent();

            this.client = client;
        }

        private void AddClientB_Click(object sender, EventArgs e)
        {
            if (NameTB.Text == "" || TelephoneTB.Text == "" ||
                ActivityTB.Text == "" || BirthDateTB.Text == "")
            {
                MessageBox.Show("Вы не ввели данные в поля о клиенте", "Нет данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DateTime.TryParse(BirthDateTB.Text, out DateTime birthDate) == false)
            {
                BirthDateTB.Text = "";
                MessageBox.Show("Неверно введённые данные\nПроверьте правильность формата введённой даты",
                                "Ошибка формата данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            this.client.Name = NameTB.Text;
            this.client.Telephone = TelephoneTB.Text;
            this.client.Activity = ActivityTB.Text;
            this.client.ClientID = Guid.NewGuid();
            this.client.BirthDate = birthDate;

            this.Close();
        }
    }
}
