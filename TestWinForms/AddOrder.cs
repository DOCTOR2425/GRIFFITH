﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class AddOrder : Form
    {
        List<RadioButton> ServiceRadiobuttons;
        List<RadioButton> ClientRadiobuttons;
        List<RadioButton> DiscountRadiobuttons;
        List<RadioButton> EmployeeRadiobuttons;

        private List<RadioButton> FillServiceGroupBox()
        {
            ServiceGroupBox.Parent = panel1;
            panel1.AutoScroll = true;

            var services = (from service in Algorithms.Notary.Service
                            where service.NewFlag == 1
                            select service.Name).ToList();

            return Algorithms.FillGroupBox(ServiceGroupBox, services);
        }
        private List<RadioButton> FillClientGroupBox()
        {
            ClientGroupBox.Parent = panel2;
            panel2.AutoScroll = true;

            var clients = (from client in Algorithms.Notary.Client select client.Name).ToList();

            return Algorithms.FillGroupBox(ClientGroupBox, clients);
        }
        private List<RadioButton> FillDiscountGroupBox()
        {
            DiscountGroupBox.Parent = panel3;
            panel3.AutoScroll = true;

            var discount = (from disc in Algorithms.Notary.Discount
                            where disc.NewFlag == 1
                            select disc.Name).ToList();

            return Algorithms.FillGroupBox(DiscountGroupBox, discount);
        }
        private List<RadioButton> FillEmployeeGroupBox()
        {
            EmployeeGroupBox.Parent = panel4;
            panel4.AutoScroll = true;

            var employee = (from emp in Algorithms.Notary.Employee
                            where emp.Post.Contains("Нотариус")
                            where emp.DismissalDate == null
                            select emp.Name).ToList();

            return Algorithms.FillGroupBox(EmployeeGroupBox, employee);
        }
        private void GetServiceID(Order order)
        {
            order.ServiceID = (from service in Algorithms.Notary.Service
                               where service.Name == Algorithms.GetCheckedName(ServiceRadiobuttons)
                               where service.NewFlag == 1
                               select service).ToList().First().ServiceID;
        }
        private void GetDiscountID(Order order)
        {
            foreach (var radioButton in DiscountRadiobuttons)
            {
                if (radioButton.Checked)
                {
                    order.DiscountID = (from disc in Algorithms.Notary.Discount
                                        where disc.Name == radioButton.Text
                                        where disc.NewFlag == 1
                                        select disc).ToList().First().DiscountID;
                    return;
                }
            }

            order.DiscountID = Guid.Parse("00000000-0000-0000-0000-000000000000");
        }
        private void GetEmployeeID(Order order)
        {
            order.EmployeeID = (from emp in Algorithms.Notary.Employee
                                where emp.Name == Algorithms.GetCheckedName(EmployeeRadiobuttons)
                                where emp.DismissalDate == null
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
                NameTextBox.Enabled = false;
                TelephoneTextBox.Enabled = false;
                ActivityTextBox.Enabled = false;

                ClientTextBox.Enabled = true;
                ClientGroupBox.Enabled = true;
            }
            else
            {
                NameTextBox.Enabled = true;
                TelephoneTextBox.Enabled = true;
                ActivityTextBox.Enabled = true;

                ClientTextBox.Enabled = false;
                ClientGroupBox.Enabled = false;
            }
        }

        private void ServiceTextBox_TextChanged(object sender, EventArgs e)
        {
            var service = (from serv in Algorithms.Notary.Service
                           where serv.NewFlag == 1
                           where serv.Name.Contains(ServiceTextBox.Text)
                           select serv.Name).ToList();

            ServiceRadiobuttons = Algorithms.FillGroupBox(ServiceGroupBox, service);
        }

        private void ClientTextBox_TextChanged(object sender, EventArgs e)
        {
            var clients = (from client in Algorithms.Notary.Client
                           where client.Name.Contains(ClientTextBox.Text)
                           select client.Name).ToList();

            ClientRadiobuttons = Algorithms.FillGroupBox(ClientGroupBox, clients);
        }

        private void DiscountTextBox_TextChanged(object sender, EventArgs e)
        {
            var discounts = (from disc in Algorithms.Notary.Discount
                             where disc.NewFlag == 1
                             where disc.Name.Contains(DiscountTextBox.Text)
                             select disc.Name).ToList();

            DiscountRadiobuttons = Algorithms.FillGroupBox(DiscountGroupBox, discounts);
        }

        private void EmployeeTextBox_TextChanged(object sender, EventArgs e)
        {
            var employee = (from emp in Algorithms.Notary.Employee
                            where emp.DismissalDate == null
                            where emp.Post.Contains("Нотариус")
                            where emp.Name.Contains(EmployeeTextBox.Text)
                            select emp.Name).ToList();

            EmployeeRadiobuttons = Algorithms.FillGroupBox(EmployeeGroupBox, employee);
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            if (Algorithms.HasCheced(ServiceRadiobuttons) == false)
                return;
            if (Algorithms.HasCheced(EmployeeRadiobuttons) == false)
                return;

            Order order = new Order
            {
                Date = DateTime.Now,
                OrderID = Guid.NewGuid()
            };

            if (ClientCheckBox.Checked == false)
            {
                if (NameTextBox.Text == "" || TelephoneTextBox.Text == "" ||
                    ActivityTextBox.Text == "" || BirthDateTextBox.Text == "")
                    return;

                if (DateTime.TryParse(BirthDateTextBox.Text, out DateTime birthDate) == false)
                {
                    BirthDateTextBox.Text = "";
                    MessageBox.Show("Неверно введённые данные\nПроверьте правильность формата введённой даты",
                                    "Ошибка формата данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }

                Client client = new Client
                {
                    Name = NameTextBox.Text,
                    Telephone = TelephoneTextBox.Text,
                    Activity = ActivityTextBox.Text,
                    ClientID = Guid.NewGuid(),
                    BirthDate = birthDate
                };
                Algorithms.Notary.Client.InsertOnSubmit(client);

                order.ClientID = client.ClientID;
            }
            else
            {
                if (Algorithms.HasCheced(ClientRadiobuttons) == false)
                    return;

                foreach (var radioButton in ClientRadiobuttons)
                    if (radioButton.Checked)
                        order.ClientID = (from client in Algorithms.Notary.Client
                                          where client.Name == radioButton.Text
                                          select client).ToList().First().ClientID;
            }

            GetServiceID(order);
            GetDiscountID(order);
            GetEmployeeID(order);

            Algorithms.Notary.Order.InsertOnSubmit(order);
            Algorithms.Notary.SubmitChanges();

            this.Close();
        }
    }
}
