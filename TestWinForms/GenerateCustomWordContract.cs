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
            ClientCB.DataSource = from cl in Algorithms.Notary.Client select cl.Name;

            ServiceCB.DataSource = from serv in Algorithms.Notary.Service
                                   where serv.NewFlag == 1
                                   select serv.Name;

            NotaryEmpCB.DataSource = from emp in Algorithms.Notary.Employee
                                     where emp.DismissalDate == null
                                     where emp.Post == "Нотариус"
                                     select emp.Name;

            DiscountCB.DataSource = from disc in Algorithms.Notary.Discount
                                    where disc.NewFlag == 1 || disc.Name == "ZERO"
                                    select disc.Name;
        }

        private void GenerateContract_Click(object sender, EventArgs e)
        {
            GenerateContractB.Cursor = Cursors.WaitCursor;

            Dictionary<string, string> pairsToChange = new Dictionary<string, string>()
            {
                { "<client>", ClientCB.Text },
                { "<service>", ServiceCB.Text },
                { "<employee>", NotaryEmpCB.Text },
                { "<discount>", Algorithms.Notary.Discount.FirstOrDefault(
                    x=> x.Name == DiscountCB.Text && x.NewFlag == 1 ||
                    DiscountCB.Text == "ZERO" && x.Name == "ZERO").Percent.ToString()},
                { "<price>", Algorithms.Notary.Service.FirstOrDefault(
                    x=> x.NewFlag == 1 && x.Name == ServiceCB.Text).Price.ToString()},
                {"<day>", Calendar.SelectionStart.Day.ToString()},
                {"<month>", Calendar.SelectionStart.ToString("MMMM")},
                {"<year>", Calendar.SelectionStart.Year.ToString()},
            };

            ReportCreator.GenerateContract(pairsToChange);

            this.Close();
        }
    }
}
