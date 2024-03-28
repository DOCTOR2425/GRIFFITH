using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class MainWindow : Form// TODO изменение удаление заказа в течение дня, поиск с начала строки
    {
        private Algorithms.Type CurrentTable;

        public MainWindow()
        {
            InitializeComponent();

            Grid.DataSource = Algorithms.GetVisibleOrders();

            MoneyTextBox.Text = Algorithms.CalculateLastMonthlyProfit().ToString();
            ChangeCurrentTable(Algorithms.Type.Order);
        }

        private void Grid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string toView = "";

            for (int i = 0; i < Grid.Columns.Count; i++)
                toView += Grid.Columns[i].Name + ":  " +
                          Grid.Rows[e.RowIndex].Cells[i].Value + "\n";

            MessageBox.Show(toView, "Выбранные элемент");
        }

        private void ShowClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeCurrentTable(Algorithms.Type.Client);
        }

        private void ShowOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeCurrentTable(Algorithms.Type.Order);
        }

        private void ShowServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeCurrentTable(Algorithms.Type.Service);
        }

        private void ShowDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeCurrentTable(Algorithms.Type.Discount);
        }

        private void ShowEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeCurrentTable(Algorithms.Type.Employee);
        }

        private void AddOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrder AddOrder = new AddOrder();
            AddOrder.ShowDialog();

            ChangeCurrentTable(Algorithms.Type.Order);

            MoneyTextBox.Text = Algorithms.CalculateLastMonthlyProfit().ToString();
        }

        private void AddServiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddServiceDiscount addService = new AddServiceDiscount(Algorithms.Type.Service);
            addService.ShowDialog();

            ChangeCurrentTable(Algorithms.Type.Service);
        }

        private void AddDiscountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddServiceDiscount addDiscount = new AddServiceDiscount(Algorithms.Type.Discount);
            addDiscount.ShowDialog();

            ChangeCurrentTable(Algorithms.Type.Discount);
        }

        private void AddEmployeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();

            ChangeCurrentTable(Algorithms.Type.Employee);
        }

        private void SearchB_Click(object sender, EventArgs e)
        {
            if (TableSelectCB.Text == "" || SearchFieldTB.Text == "")
            {
                MessageBox.Show("Вы не ввели параметры фильтрации", "Нет данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            object[] list = new object[0];
            switch (CurrentTable)
            {
                case Algorithms.Type.Client:
                    list = Algorithms.GetVisibleClients().ToArray();
                    break;
                case Algorithms.Type.Order:
                    list = Algorithms.GetVisibleOrders().ToArray();
                    break;
                case Algorithms.Type.Service:
                    list = Algorithms.GetVisibleServices().ToArray();
                    break;
                case Algorithms.Type.Discount:
                    list = Algorithms.GetVisibleDiscounts().ToArray();
                    break;
                case Algorithms.Type.Employee:
                    list = Algorithms.GetVisibleEmployees().ToArray();
                    break;
            }

            PropertyInfo field = list[0].GetType().GetProperty(TableSelectCB.Text);

            Grid.DataSource = (from obj in list
                               where field.GetValue(obj).ToString().ToLower()
                               .Contains(SearchFieldTB.Text.ToLower())
                               select obj).ToList();
        }

        private void DropFiltresB_Click(object sender, EventArgs e)
        {
            ChangeCurrentTable(CurrentTable);
        }

        public void ChangeCurrentTable(Algorithms.Type type)
        {
            CurrentTable = type;
            switch (type)
            {
                case Algorithms.Type.Client:
                    TableSelectCB.DataSource = VisibleClient.GetFieldsName();
                    Grid.DataSource = Algorithms.GetVisibleClients();
                    break;
                case Algorithms.Type.Service:
                    TableSelectCB.DataSource = VisibleService.GetFieldsName();
                    Grid.DataSource = Algorithms.GetVisibleServices();
                    break;
                case Algorithms.Type.Order:
                    TableSelectCB.DataSource = VisibleOrder.GetFieldsName();
                    Grid.DataSource = Algorithms.GetVisibleOrders();
                    break;
                case Algorithms.Type.Discount:
                    TableSelectCB.DataSource = VisibleDiscount.GetFieldsName();
                    Grid.DataSource = Algorithms.GetVisibleDiscounts();
                    break;
                case Algorithms.Type.Employee:
                    TableSelectCB.DataSource = VisibleEmployee.GetFieldsName();
                    Grid.DataSource = Algorithms.GetVisibleEmployees();
                    break;
            }
        }

        private void GenerateReportClick(object sender, EventArgs e)
        {
            GenerateExelReport window = new GenerateExelReport();
            window.ShowDialog();
        }

        private void GenerateContractClick(object sender, EventArgs e)
        {
            GenerateWordContractByOrder window = new GenerateWordContractByOrder();
            window.ShowDialog();
        }

        private void ChangeItemInLineTSMIClick(object sender, EventArgs e)
        {
            int index = Grid.CurrentCell.RowIndex;

            switch (CurrentTable)
            {
                case Algorithms.Type.Service:
                    {
                        ChangeElement changeElement = new ChangeElement(Algorithms.Notary.Service.FirstOrDefault(
                            x => x.Name == Grid.Rows[index].Cells[0].Value.ToString()));
                        changeElement.ShowDialog();

                        break;
                    }
                case Algorithms.Type.Discount:
                    {
                        ChangeElement changeElement = new ChangeElement(Algorithms.Notary.Discount.FirstOrDefault(
                            x => x.Name == Grid.Rows[index].Cells[0].Value.ToString()));
                        changeElement.ShowDialog();

                        break;
                    }
                case Algorithms.Type.Client:
                    {
                        ChangeElement changeElement = new ChangeElement(Algorithms.Notary.Client.FirstOrDefault(
                            x => x.Name == Grid.Rows[index].Cells[0].Value.ToString()));
                        changeElement.ShowDialog();

                        break;
                    }
                case Algorithms.Type.Employee:
                    {
                        ChangeElement changeElement = new ChangeElement(Algorithms.Notary.Employee.FirstOrDefault(
                            x => x.Name == Grid.Rows[index].Cells[0].Value.ToString()));
                        changeElement.ShowDialog();

                        break;
                    }
                case Algorithms.Type.Order:
                    {
                        if (Grid.Rows[index].Cells[3].Value.ToString() != DateTime.Now.ToString("dd.MM.yyyy"))
                        {
                            MessageBox.Show("");
                        }
                        //ChangeElement changeElement = new ChangeElement(Algorithms.Notary.Order.FirstOrDefault(x => 
                        //    x.Date.ToString("dd.MM.yyyy") == Grid.Rows[index].Cells[3].Value.ToString() &&
                        //    x.Cl.ToString("dd.MM.yyyy") == Grid.Rows[index].Cells[3].Value.ToString()));
                        //changeElement.ShowDialog();

                        break;
                    }
            }
            ChangeCurrentTable(CurrentTable);
        }

        private void DeleteItemInLineTSMIClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить этот объект из бд?\n" +
                "Для удаление нажмите \"Да\"", "Удаление объекта из базы",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Visible obj = (Grid.DataSource as IEnumerable<Visible>).ToList()[Grid.CurrentRow.Index];

                switch (obj.GetType().Name)
                {
                    case "VisibleService":
                        Algorithms.Notary.Service.FirstOrDefault(x =>
                        x.Name == (obj as VisibleService).Название && x.NewFlag == 1).NewFlag = 0;

                        break;
                    case "VisibleDiscount":
                        Algorithms.Notary.Discount.FirstOrDefault(x =>
                        x.Name == (obj as VisibleDiscount).Название && x.NewFlag == 1).NewFlag = 0;

                        break;
                    case "VisibleEmployee":
                        Algorithms.Notary.Employee.FirstOrDefault(x =>
                        x.Name == (obj as VisibleEmployee).Имя && x.DismissalDate == null).DismissalDate = DateTime.Now;

                        break;
                }
                Algorithms.Notary.SubmitChanges();
                ChangeCurrentTable(CurrentTable);
            }
        }
    }
}
