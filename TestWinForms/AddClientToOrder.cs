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
            if (ValidateInput() == false)
                return;

            this.client.Name = NameTB.Text;
            this.client.Telephone = TelephoneTB.Text;
            this.client.Activity = Algorithms.ToUpperFirstLetter(ActivityTB.Text);
            this.client.ClientID = Guid.NewGuid();
            this.client.BirthDate = DateTime.Parse(BirthDateTB.Text);

            this.Close();
        }

        private bool ValidateInput()
        {
            MessageBox.Show(BirthDateTB.Text);
            MessageBox.Show(TelephoneTB.Text);
            if (NameTB.Text == "" || ActivityTB.Text == "")
            {
                MessageBox.Show("Вы не ввели все данные в поля", "Ошибка данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (TelephoneTB.Text.Contains("_"))
            {
                BirthDateTB.Text = "";
                MessageBox.Show("Неверно введённая данные номера телефона\nПроверьте правильность введённого номера телефона",
                                "Ошибка формата данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            if (BirthDateTB.Text.Contains("_"))
            {
                BirthDateTB.Text = "";
                MessageBox.Show("Неверно введённая данные даты рождения\nПроверьте правильность введённой даты",
                                "Ошибка формата данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }
    }
}
