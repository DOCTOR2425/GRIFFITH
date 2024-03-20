using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using Word = Microsoft.Office.Interop.Word;
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

        private void DisplayInWord(KeyValuePair<string, string>[] pairsToChange)
        {
            var wordApp = new Word.Application();
            object mis = Type.Missing;
            wordApp.Documents.Open(fileTeplate);

            Word.Find find = wordApp.Selection.Find;

            for (int i = 0; i < pairsToChange.Length; i++)
            {
                try
                {
                    find.Text = pairsToChange[i].Key;
                    find.Replacement.Text = pairsToChange[i].Value;

                    object wrap = Word.WdFindWrap.wdFindContinue;
                    object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: mis, MatchSoundsLike: mis, Forward: true,
                        Wrap: wrap, ReplaceWith: mis, Replace: replace);
                }
                catch { i--; }
            }

            wordApp.Visible = true;
        }

        private void GenerateContract_Click(object sender, EventArgs e)
        {
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
                new KeyValuePair<string, string>( "<date>", Calendar.SelectionStart.ToString("dd.MM.yyyy") ),
                new KeyValuePair<string, string>( "<price>", (from serv in Algorithms.Notary.Service
                                                             where serv.NewFlag == 1
                                                             where serv.Name == ServiceCB.Text
                                                             select serv.Price).ToList().First().ToString())
            };

            DisplayInWord(pairsToChange);

            this.Close();
        }
    }
}
