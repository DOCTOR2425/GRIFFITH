using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace TestWinForms
{
    public partial class GenerateCustomWordContract : Form
    {
        public GenerateCustomWordContract()
        {
            InitializeComponent();

            FillComboBoxes();
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
                                     where disc.NewFlag == 1 || disc.Name == "ZERO"
                                     select disc.Name).ToList();
        }

        private void GenerateContract_Click(object sender, EventArgs e)
        {
            GenerateContractB.Cursor = Cursors.WaitCursor;

            Dictionary<string, string> pairsToChange = new Dictionary<string, string>()
            {
                { "<client>", ClientCB.Text.Substring(0, ClientCB.Text.IndexOf(':')) },
                { "<service>", ServiceCB.Text },
                { "<employee>", EmployeeCB.Text },
                { "<discount>", Algorithms.Notary.Discount.FirstOrDefault(
                    x=> x.Name == DiscountCB.Text && x.NewFlag == 1 ||
                    DiscountCB.Text == "ZERO" && x.Name == "ZERO").Percent.ToString()},
                { "<price>", Algorithms.Notary.Service.FirstOrDefault(
                    x=> x.NewFlag == 1 && x.Name == ServiceCB.Text).Price.ToString()},
                { "<telephone>", ClientCB.Text.Substring(ClientCB.Text.IndexOf(':'), 
                    ClientCB.Text.Length - ClientCB.Text.IndexOf(':')) },
                {"<day>", Calendar.SelectionStart.Day.ToString()},
                {"<month>", Calendar.SelectionStart.ToString("MMMM")},
                {"<year>", Calendar.SelectionStart.Year.ToString()},
            };

            ReportCreator.GenerateContract(pairsToChange);

            this.Close();
        }

        private void ClientCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClientInfoL.Text = "Сфера детельности клиента: " + Algorithms.Notary.Client.FirstOrDefault(
                x => x.Name + ": " + x.Telephone == ClientCB.Text).Activity;
        }

        private void ServiceCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceInfoL.Text = "Цена услуги: " + Algorithms.Notary.Service.FirstOrDefault(
                x => x.Name == ServiceCB.Text && x.NewFlag == 1).Price.ToString();
        }

        private void EmployeeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeInfoL.Text = "Опыт работы в годах: " + (DateTime.Now.Year - Algorithms.Notary.Employee.FirstOrDefault(
                x => x.Name == EmployeeCB.Text && x.DismissalDate == null).HireDate.Year).ToString();
        }

        private void DiscountCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DiscountInfoL.Text = "Процент скидки : " + Algorithms.Notary.Discount.FirstOrDefault(
                x => x.Name == DiscountCB.Text).Percent.ToString();
        }
    }
}
