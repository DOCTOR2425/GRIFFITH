using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class AddOrder : Form
    {
        readonly NotaryBaseDataContext Notary = new NotaryBaseDataContext();
        List<RadioButton> ServiceRadiobuttons;
        List<RadioButton> ClientRadiobuttons;
        List<RadioButton> DiscountRadiobuttons;
        List<RadioButton> EmployeeRadiobuttons;

        private List<RadioButton> FillGroupBox(GroupBox groupBox, List<string> names)
        {
            groupBox.Controls.Clear();

            var list = new List<RadioButton>(names.Count);

            Point GBLoc = groupBox.Location;

            for (int i = 0; i < names.Count; i++)
            {
                list.Add(new RadioButton());
                list[i].Text = names[i];
                list[i].Parent = groupBox;
                list[i].Location = new Point(5, GBLoc.Y + 20 * (i + 1));
            }

            return list;
        }

        private List<RadioButton> FillServiceGroupBox()
        {
            ServiceGroupBox.Parent = panel1;
            panel1.AutoScroll = true;

            var services = (from service in Notary.Service
                            where service.NewFlag == 1
                            select service.Name).ToList();

            return FillGroupBox(ServiceGroupBox, services);
        }
        private List<RadioButton> FillClientGroupBox()
        {
            ClientGroupBox.Parent = panel2;
            panel2.AutoScroll = true;

            var clients = (from client in Notary.Client select client.Name).ToList();

            return FillGroupBox(ClientGroupBox, clients);
        }
        private List<RadioButton> FillDiscountGroupBox()
        {
            DiscountGroupBox.Parent = panel3;
            panel3.AutoScroll = true;

            var discount = (from disc in Notary.Discount
                            where disc.NewFlag == 1
                            select disc.Name).ToList();

            return FillGroupBox(DiscountGroupBox, discount);
        }
        private List<RadioButton> FillEmployeeGroupBox()
        {
            EmployeeGroupBox.Parent = panel4;
            panel4.AutoScroll = true;

            var employee = (from emp in Notary.Employee
                            where emp.Post.Contains("Нотариус")
                            where emp.DismissalDate == null
                            select emp.Name).ToList();

            return FillGroupBox(EmployeeGroupBox, employee);
        }
        private bool HasCheced(List<RadioButton> radioButtons)
        {
            foreach (var radiobutton in radioButtons)
                if (radiobutton.Checked)
                    return true;

            return false;
        }
        private void FillService(Order order)
        {
            foreach (var radioButton in ServiceRadiobuttons)
                if (radioButton.Checked)
                    order.ServiceID = (from service in Notary.Service
                                       where service.Name == radioButton.Text
                                       where service.NewFlag == 1
                                       select service).ToList().First().ServiceID;
        }
        private void FillDiscount(Order order)
        {
            foreach (var radioButton in DiscountRadiobuttons)
                if (radioButton.Checked)
                    order.DiscountID = (from disc in Notary.Discount
                                        where disc.Name == radioButton.Text
                                        where disc.NewFlag == 1
                                        select disc).ToList().First().DiscountID;
        }
        private void FillEmployee(Order order)
        {
            foreach (var radioButton in EmployeeRadiobuttons)
                if (radioButton.Checked)
                    order.EmployeeID = (from emp in Notary.Employee
                                        where emp.Name == radioButton.Text
                                        select emp).ToList().First().EmployeeID;
        }

        public AddOrder()
        {
            InitializeComponent();

            ServiceRadiobuttons = FillServiceGroupBox();
            ClientRadiobuttons = FillClientGroupBox();
            DiscountRadiobuttons = FillDiscountGroupBox();
            EmployeeRadiobuttons = FillEmployeeGroupBox();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ClientCheckBox.Checked == true)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;

                ClientTextBox.Enabled = true;

                ClientGroupBox.Enabled = true;
            }
            else
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;

                ClientTextBox.Enabled = false;

                ClientGroupBox.Enabled = false;
            }
        }

        private void ServiceTextBox_TextChanged(object sender, EventArgs e)
        {
            var service = (from serv in Notary.Service
                           where serv.NewFlag == 1
                           where serv.Name.Contains(ServiceTextBox.Text)
                           select serv.Name ).ToList();

            ServiceRadiobuttons = FillGroupBox(ServiceGroupBox, service);
        }

        private void ClientTextBox_TextChanged(object sender, EventArgs e)
        {
            var clients = (from client in Notary.Client
                           where client.Name.Contains(ClientTextBox.Text)
                           select client.Name).ToList();

            ClientRadiobuttons = FillGroupBox(ClientGroupBox, clients);
        }

        private void DiscountTextBox_TextChanged(object sender, EventArgs e)
        {
            var discounts = (from disc in Notary.Discount
                             where disc.NewFlag == 1
                             where disc.Name.Contains(DiscountTextBox.Text)
                             select disc.Name).ToList();

            DiscountRadiobuttons = FillGroupBox(DiscountGroupBox, discounts);
        }

        private void EmployeeTextBox_TextChanged(object sender, EventArgs e)
        {
            var employee = (from emp in Notary.Employee
                            where emp.DismissalDate == null
                            where emp.Post.Contains("Нотариус")
                            where emp.Name.Contains(EmployeeTextBox.Text)
                            select emp.Name).ToList();

            EmployeeRadiobuttons = FillGroupBox(EmployeeGroupBox, employee);
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            if (HasCheced(ServiceRadiobuttons) == false)
                return;
            if (HasCheced(EmployeeRadiobuttons) == false)
                return;

            Order order = new Order();
            order.Date = DateTime.Now;
            order.OrderID = Guid.NewGuid();

            if (ClientCheckBox.Checked == false)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    return;

                Client client = new Client();

                client.Name = textBox1.Text;
                client.Telephone = textBox2.Text;
                client.Activity = textBox3.Text;
                client.ClientID = Guid.NewGuid();
                Notary.Client.InsertOnSubmit(client);

                order.ClientID = client.ClientID;
            }
            else
            {
                if (HasCheced(ClientRadiobuttons) == false)
                    return;

                foreach (var radioButton in ClientRadiobuttons)
                    if (radioButton.Checked)
                        order.ClientID = (from client in Notary.Client
                                          where client.Name == radioButton.Text
                                          select client).ToList().First().ClientID;
            }

            FillService(order);
            FillDiscount(order);
            FillEmployee(order);

            Notary.Order.InsertOnSubmit(order);

            Notary.SubmitChanges();
            this.Close();
        }
    }
}
