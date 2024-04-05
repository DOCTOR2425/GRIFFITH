using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace TestWinForms
{
    public partial class GenerateCustomWordContract : Form
    {
        string fileTeplate = "D:\\Project\\Course_3\\Проект GRIFFITH\\GRIFFITH\\TestWinForms\\Template.docx";

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
                                    where disc.NewFlag == 1
                                    select disc.Name;
        }

        private void GenerateContract_Click(object sender, EventArgs e)
        {
            GenerateContractB.Cursor = Cursors.WaitCursor;

            if (File.Exists(fileTeplate) == false)
            {
                MessageBox.Show("Не удалось найти шаблон файла для составления договора", "Ошибка файла",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            KeyValuePair<string, string>[] pairsToChange = new KeyValuePair<string, string>[]
            {
                new KeyValuePair<string, string>( "<client>", ClientCB.Text ),
                new KeyValuePair<string, string>( "<service>", ServiceCB.Text ),
                new KeyValuePair<string, string>( "<employee>", NotaryEmpCB.Text ),
                new KeyValuePair<string, string>( "<discount>", DiscountCB.Text ),
                new KeyValuePair<string, string>("<activity>", Algorithms.Notary.Client.FirstOrDefault(x=>
                                                               x.Name == ClientCB.Text).Activity),
                new KeyValuePair<string, string>( "<price>", (from serv in Algorithms.Notary.Service
                                                             where serv.NewFlag == 1
                                                             where serv.Name == ServiceCB.Text
                                                             select serv.Price).ToList().First().ToString()),
                new KeyValuePair<string, string>("<day>", Calendar.SelectionStart.Day.ToString()),
                new KeyValuePair<string, string>("<month>", Calendar.SelectionStart.ToString("MMMM")),
                new KeyValuePair<string, string>("<year>", Calendar.SelectionStart.Year.ToString()),
            };

            ReportCreator.GenerateContract(pairsToChange);

            this.Close();
        }
    }
}
