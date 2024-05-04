using System;
using System.Runtime.Remoting.Messaging;
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
            if (IsNameValid() == false)
            {
                NameTB.Text = "";
                MessageBox.Show("Неверно введённая данные ФИО клиента\nПроверьте правильность введённого ФИО клиента",
                                "Ошибка формата данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (IsTelephoneValid() == false)
            {
                BirthDateTB.Text = "";
                MessageBox.Show("Неверно введённая данные номера телефона\nПроверьте правильность введённого номера телефона",
                                "Ошибка формата данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ActivityTB.Text.Length < 4)
            {
                ActivityTB.Text = "";
                MessageBox.Show("Неверно введённая данные активности клиента\nПроверьте правильность введённой активности клиента",
                                "Ошибка формата данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (IsDateValid() == false)
            {
                BirthDateTB.Text = "";
                MessageBox.Show("Неверно введённая данные даты рождения\nПроверьте правильность введённой даты",
                                "Ошибка формата данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool IsDateValid()
        {
            if (BirthDateTB.Text.Contains("_"))
                return false;
            else if (DateTime.Parse(BirthDateTB.Text).Year - DateTime.Now.Year > 100)
                return false;

            return true;
        }

        private bool IsNameValid()
        {
            if (NameTB.Text.Contains(" ") == false)
                return false;
            else if (NameTB.Text.Length < 6)
                return false;

            foreach(char s in NameTB.Text)
                if (Char.IsDigit(s))
                    return false;

            return true;
        }

        private bool IsTelephoneValid()
        {
            if (TelephoneTB.Text.Contains("_"))
                return false;
            foreach (char s in NameTB.Text)
                if (Char.IsLetter(s))
                    return false;


            return true;
        }

        private void ActivityTB_Leave(object sender, EventArgs e)
        {
            if (ActivityTB.Text == "")
                return;

            ActivityTB.Text = Algorithms.ToUpperFirstLetter(ActivityTB.Text);
        }
    }
}
