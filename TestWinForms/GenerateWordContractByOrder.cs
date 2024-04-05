using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace TestWinForms
{
    public partial class GenerateWordContractByOrder : Form// TODO Оформить договор нормально с шаблоном
    {
        string fileTeplate = "D:\\Project\\Course_3\\Проект GRIFFITH\\GRIFFITH\\TestWinForms\\Template.docx";

        public GenerateWordContractByOrder()
        {
            InitializeComponent();

            Grid.DataSource = Algorithms.GetVisibleOrders();
        }

        private void GenerateContractB_Click(object sender, EventArgs e)
        {
            GenerateContractB.Cursor = Cursors.WaitCursor;

            if (File.Exists(fileTeplate) == false)
            {
                MessageBox.Show("Не удалось найти шаблон файла для составления договора", "Ошибка файла",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedRow = Grid.CurrentRow.Index;

            KeyValuePair<string, string>[] pairsToChange = new KeyValuePair<string, string>[9]
            {
                new KeyValuePair<string, string>( "<client>", Grid.Rows[selectedRow].Cells[0].Value.ToString() ),
                new KeyValuePair<string, string>( "<service>", Grid.Rows[selectedRow].Cells[1].Value.ToString() ),
                new KeyValuePair<string, string>( "<employee>", Grid.Rows[selectedRow].Cells[2].Value.ToString() ),
                new KeyValuePair<string, string>( "<price>", Grid.Rows[selectedRow].Cells[4].Value.ToString() ),
                new KeyValuePair<string, string>( "<discount>", Grid.Rows[selectedRow].Cells[5].Value.ToString() ),

                new KeyValuePair<string, string>("<day>", ((DateTime)Grid.Rows[selectedRow].Cells[3].Value).Day.ToString()),
                new KeyValuePair<string, string>("<month>", ((DateTime)Grid.Rows[selectedRow].Cells[3].Value).ToString("MMMM")),
                new KeyValuePair<string, string>("<year>", ((DateTime)Grid.Rows[selectedRow].Cells[3].Value).Year.ToString()),

                new KeyValuePair<string, string>( "<activity>", Algorithms.Notary.Client.FirstOrDefault(
                    x=> x.Name == Grid.Rows[selectedRow].Cells[0].Value.ToString()).Activity),
            };

            ReportCreator.GenerateContract(pairsToChange);

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            GenerateCustomWordContract window = new GenerateCustomWordContract();
            window.ShowDialog();
        }

        private void GenerateWordContractByOrder_Load(object sender, EventArgs e)
        {
            Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
