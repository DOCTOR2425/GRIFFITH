﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.IO;

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

        private void GenerateContractB_Click(object sender, EventArgs e)
        {
            if (File.Exists(fileTeplate) == false)
            {
                MessageBox.Show("Не удалось найти шаблон файла для составления договора", "Ошибка файла",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedRow = Grid.CurrentRow.Index;

            KeyValuePair<string, string>[] pairsToChange = new KeyValuePair<string, string>[6]
            {
                new KeyValuePair<string, string>( "<client>", Grid.Rows[selectedRow].Cells[0].Value.ToString() ),
                new KeyValuePair<string, string>( "<service>", Grid.Rows[selectedRow].Cells[1].Value.ToString() ),
                new KeyValuePair<string, string>( "<employee>", Grid.Rows[selectedRow].Cells[2].Value.ToString() ),
                new KeyValuePair<string, string>( "<date>", Grid.Rows[selectedRow].Cells[3].Value.ToString() ),
                new KeyValuePair<string, string>( "<price>", Grid.Rows[selectedRow].Cells[4].Value.ToString() ),
                new KeyValuePair<string, string>( "<discount>", Grid.Rows[selectedRow].Cells[5].Value.ToString() )
            };

            DisplayInWord(pairsToChange);

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
