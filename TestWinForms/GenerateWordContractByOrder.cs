using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class GenerateWordContractByOrder : Form
    {
        public GenerateWordContractByOrder()
        {
            InitializeComponent();

            Grid.DataSource = Algorithms.GetVisibleOrders();
        }

        private void GenerateContractB_Click(object sender, EventArgs e)
        {
            GenerateContractB.Cursor = Cursors.WaitCursor;

            int selectedRow = Grid.CurrentRow.Index;

            Dictionary<string, string> pairsToChange = new Dictionary<string, string>()
            {
                { "<client>", Grid.Rows[selectedRow].Cells[0].Value.ToString() },
                { "<service>", Grid.Rows[selectedRow].Cells[1].Value.ToString() },
                { "<employee>", Grid.Rows[selectedRow].Cells[2].Value.ToString() },
                { "<price>", Grid.Rows[selectedRow].Cells[4].Value.ToString() },
                { "<discount>", Grid.Rows[selectedRow].Cells[5].Value.ToString() },
                { "<telephone>", Algorithms.Notary.Client.FirstOrDefault(
                    x=> x.Name == Grid.Rows[selectedRow].Cells[0].Value.ToString()).Telephone },
                { "<day>", ((DateTime)Grid.Rows[selectedRow].Cells[3].Value).Day.ToString() },
                { "<month>", ((DateTime)Grid.Rows[selectedRow].Cells[3].Value).ToString("MMMM") },
                { "<year>", ((DateTime)Grid.Rows[selectedRow].Cells[3].Value).Year.ToString() }
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
