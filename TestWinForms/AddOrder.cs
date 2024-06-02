using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class AddOrder : Form
    {
        Client clientToAdd = null;

        public AddOrder()
        {
            InitializeComponent();

            FillComboBoxes();
        }

        private void GetDiscountID(Order order)
        {
            if (AddDiscountChB.Checked == false)
            {
                order.DiscountID = Guid.Parse("00000000-0000-0000-0000-000000000000");
                return;
            }

            order.DiscountID = Algorithms.Notary.Discount.FirstOrDefault(
                x => x.Name == DiscountCB.Text && x.NewFlag == 1).DiscountID;
        }

        private void FillComboBoxes()
        {
            ClientCB.DataSource = (from cl in Algorithms.Notary.Client select cl.Name + ": " + cl.Telephone).ToList();

            ServiceCB.DataSource = (from serv in Algorithms.Notary.Service
                                    where serv.NewFlag == 1
                                    select serv.Name).ToList();

            EmployeeCB.DataSource = (from emp in Algorithms.Notary.Employee
                                     where emp.DismissalDate == null
                                     where emp.Post == "Нотариус"
                                     select emp.Name).ToList();

            DiscountCB.DataSource = (from disc in Algorithms.Notary.Discount
                                     where disc.NewFlag == 1
                                     select disc.Name).ToList();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            AddNewClientB.Enabled = !AddNewClientB.Enabled;

            ClientL.Enabled = !ClientL.Enabled;
            ClientCB.Enabled = !ClientCB.Enabled;
            ClientInfoL.Enabled = !ClientInfoL.Enabled;
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            AddOrderB.Cursor = Cursors.WaitCursor;
            this.Cursor = Cursors.WaitCursor;

            Order order = new Order
            {
                Date = DateTime.Now,
                OrderID = Guid.NewGuid()
            };

            if (AddNewClientChB.Checked == true)
            {
                if (clientToAdd == null)
                {
                    if (MessageBox.Show("Новый клиент не добавлен.\nЖелаете добавить нового?", "Нет данных о клиенте",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        AddNewClientB_Click(sender, e);
                        return;
                    }

                    return;
                }

                Algorithms.Notary.Client.InsertOnSubmit(clientToAdd);

                order.ClientID = clientToAdd.ClientID;
            }
            else
            {
                order.ClientID = Algorithms.Notary.Client.FirstOrDefault(
                x => x.Name + ": " + x.Telephone == ClientCB.Text).ClientID;
            }

            order.ServiceID = Algorithms.Notary.Service.FirstOrDefault(
                x => x.Name == ServiceCB.Text && x.NewFlag == 1).ServiceID;

            order.EmployeeID = Algorithms.Notary.Employee.FirstOrDefault(
                x => x.Name == EmployeeCB.Text && x.DismissalDate == null).EmployeeID;

            GetDiscountID(order);

            Algorithms.Notary.Order.InsertOnSubmit(order);
            Algorithms.Notary.SubmitChanges();

            ReportCreator.GenerateContract(GetPairsToChange(order));

            this.Close();
        }

        private static Dictionary<string, string> GetPairsToChange(Order order)
        {
            return new Dictionary<string, string>
            {
                {"<client>", order.Client.Name },
                { "<service>", order.Service.Name },
                { "<employee>", order.Employee.Name },
                { "<price>", order.Service.Price.ToString() },
                { "<discount>", order.Discount.Percent.ToString() },
                { "<telephone>", order.Client.Telephone },

                { "<day>", order.Date.Day.ToString() },
                { "<month>", order.Date.ToString("MMMM") },
                { "<year>", order.Date.Year.ToString() }
            };
        }


        private void AddNewClientB_Click(object sender, EventArgs e)
        {
            clientToAdd = new Client();
            AddClientToOrder window = new AddClientToOrder(clientToAdd);
            window.ShowDialog();

            if (clientToAdd.BirthDate == DateTime.MinValue)
            {
                clientToAdd = null;
                return;
            }

            Client toCheckRecentlyAdded = Algorithms.Notary.Client.FirstOrDefault(x =>
            x.Name == clientToAdd.Name &&
            x.BirthDate == clientToAdd.BirthDate &&
            x.Telephone == clientToAdd.Telephone &&
            x.Activity.ToString().ToLower() == clientToAdd.Activity.ToLower());

            if (toCheckRecentlyAdded != null)
            {
                if (MessageBox.Show("Такой клиент уже есть в базе и его нельзя добавить повторно." +
                    "\nВыбрать его для оказания услуги?", "Клиент существует",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ClientCB.Text = clientToAdd.Name + ": " + clientToAdd.Telephone;
                    AddNewClientChB.Checked = !AddNewClientChB.Checked;
                }
                clientToAdd = null;
            }
        }

        private void AddDiscountChB_CheckedChanged(object sender, EventArgs e)
        {
            if (AddDiscountChB.Checked == true)
            {
                DiscountCB.Enabled = true;
                DiscountL.Enabled = true;
                DiscountInfoL.Enabled = true;
            }
            else
            {
                DiscountCB.Enabled = false;
                DiscountL.Enabled = false;
                DiscountInfoL.Enabled = false;
            }
        }

        private void ClientCB_SelectedValueChanged(object sender, EventArgs e)
        {
            ClientInfoL.Text = "Сфера детельности клиента: " + Algorithms.Notary.Client.FirstOrDefault(
                x => x.Name + ": " + x.Telephone == ClientCB.Text).Activity;
        }

        private void ServiceCB_SelectedValueChanged(object sender, EventArgs e)
        {
            ServiceInfoL.Text = "Цена услуги: " + Algorithms.Notary.Service.FirstOrDefault(
                x => x.Name == ServiceCB.Text && x.NewFlag == 1).Price.ToString();
        }

        private void EmployeeCB_SelectedValueChanged(object sender, EventArgs e)
        {
            EmployeeInfoL.Text = "Опыт работы в годах: " + (DateTime.Now.Year - Algorithms.Notary.Employee.FirstOrDefault(
                x => x.Name == EmployeeCB.Text && x.DismissalDate == null).HireDate.Year).ToString();
        }

        private void DiscountCB_SelectedValueChanged(object sender, EventArgs e)
        {
            DiscountInfoL.Text = "Процент скидки : " + Algorithms.Notary.Discount.FirstOrDefault(
                x => x.Name == DiscountCB.Text).Percent.ToString();
        }
    }
}
