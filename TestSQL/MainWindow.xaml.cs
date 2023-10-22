using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace TestSQL
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TestDataBase testDataBase = new TestDataBase();
        Table_1 table_1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            var query = from tab in testDataBase.Table_1 select tab;
            Grid.ItemsSource = query.ToList();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            var query = from tab in testDataBase.Table_2 select tab;
            Grid.ItemsSource = query.ToList();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Table_1 tab1 = new Table_1();
            tab1.NumberID = Guid.NewGuid();
            tab1.Name = "Test" + tab1.NumberID;

            testDataBase.Table_1.InsertOnSubmit(tab1);
            testDataBase.SubmitChanges();

            var query = from tab in testDataBase.Table_1 select tab;
            Grid.ItemsSource = query.ToList();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            table_1 = (Table_1)Grid.SelectedItem;

            (from t in testDataBase.Table_1
             where t.NumberID == table_1.NumberID select t).ToList().ForEach(x => x.Name = "000");
        }
    }
}
