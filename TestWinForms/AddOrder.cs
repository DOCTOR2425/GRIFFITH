using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class AddOrder : Form// TODO Сделать отображение инфы о выбранных в комбо боксах объектах
    {
        Client clientToAdd = null;

        public AddOrder()
        {
            InitializeComponent();

            FillComboBoxes();
        }

        private void GetServiceID(Order order)
        {
            order.ServiceID = (from service in Algorithms.Notary.Service
                               where service.Name == ServiceCB.Text
                               where service.NewFlag == 1
                               select service).ToList().First().ServiceID;
        }
        private void GetDiscountID(Order order)
        {
            if (AddDiscountChB.Checked == false)
            {
                order.DiscountID = Guid.Parse("00000000-0000-0000-0000-000000000000");
                return;
            }

            order.DiscountID = (from disc in Algorithms.Notary.Discount
                                where disc.Name == DiscountCB.Text
                                where disc.NewFlag == 1
                                select disc).ToList().First().DiscountID;
        }
        private void GetEmployeeID(Order order)
        {
            order.EmployeeID = (from emp in Algorithms.Notary.Employee
                                where emp.Name == EmployeeCB.Text
                                where emp.DismissalDate == null
                                select emp).ToList().First().EmployeeID;
        }
        private void GetClientID(Order order)
        {
            order.ClientID = (from emp in Algorithms.Notary.Client
                              where emp.Name == ClientCB.Text
                              select emp).ToList().First().ClientID;
        }

        private void FillComboBoxes()
        {
            ClientCB.DataSource = (from cl in Algorithms.Notary.Client select cl.Name).ToList();

            ServiceCB.DataSource = (from serv in Algorithms.Notary.Service
                                    where serv.NewFlag == 1
                                    select serv.Name).ToList();

            EmployeeCB.DataSource = (from emp in Algorithms.Notary.Employee
                                     where emp.DismissalDate == null
                                     select emp.Name).ToList();

            DiscountCB.DataSource = (from disc in Algorithms.Notary.Discount
                                     where disc.NewFlag == 1
                                     select disc.Name).ToList();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (AddNewClientChB.Checked == true)
            {
                AddNewClientB.Enabled = true;

                ClientL.Enabled = false;
                ClientCB.Enabled = false;
            }
            else
            {
                AddNewClientB.Enabled = false;

                ClientL.Enabled = true;
                ClientCB.Enabled = true;
            }
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            Order order = new Order
            {
                Date = DateTime.Now,
                OrderID = Guid.NewGuid()
            };

            if (AddNewClientChB.Checked == true)
            {
                if (clientToAdd == null)
                {
                    MessageBox.Show("Новый клиент не добавлен.\nЖелаете добавить нового?", "Нет данных о клиенте",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    return;
                }

                Algorithms.Notary.Client.InsertOnSubmit(clientToAdd);

                order.ClientID = clientToAdd.ClientID;
            }
            else
            {
                GetClientID(order);
            }

            GetServiceID(order);
            GetDiscountID(order);
            GetEmployeeID(order);

            Algorithms.Notary.Order.InsertOnSubmit(order);
            Algorithms.Notary.SubmitChanges();

            this.Close();
        }

        private void AddNewClientB_Click(object sender, EventArgs e)
        {
            clientToAdd = new Client();
            AddClientToOrder window = new AddClientToOrder(clientToAdd);
            window.ShowDialog();

            if (clientToAdd.BirthDate == DateTime.MinValue)
                clientToAdd = null;
        }

        private void AddDiscountChB_CheckedChanged(object sender, EventArgs e)
        {
            if(AddDiscountChB.Checked == true)
            {
                DiscountCB.Enabled = true;
                DiscountL.Enabled = true;
            }
            else
            {
                DiscountCB.Enabled = false;
                DiscountL.Enabled = false;
            }
        }
    }
}
