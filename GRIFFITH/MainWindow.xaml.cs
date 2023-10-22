using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Data;

namespace GRIFFITH
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DataClasses1DataContext Notary = new DataClasses1DataContext();

        public MainWindow()
        {
            InitializeComponent();

            var query = from Client in Notary.Clients select Client;
            Grid.ItemsSource = query.ToList();
        }

        private void ViewClientMI_Click(object sender, RoutedEventArgs e)
        {
            var query = from Client in Notary.Clients select Client;
            Grid.ItemsSource = query.ToList();
        }

        private void ViewServiceMI_Click(object sender, RoutedEventArgs e)
        {
            var query = from service in Notary.Services select service;
            Grid.ItemsSource = query.ToList();
        }

        private void ViewDiscountMI_Click(object sender, RoutedEventArgs e)
        {
            var query = from discount in Notary.Discount select discount;
            Grid.ItemsSource = query.ToList();
        }

        private void ViewOrderMI_Click(object sender, RoutedEventArgs e)
        {
            //var query = from order in Notary.Orders select order;
            var query = from order in Notary.Orders
                        join serv in Notary.Services on order.ServiceID equals serv.ServiceID
                        select new
                        {
                            ClientID = order.ClientID,
                            OrderID = order.OrderID,
                            Service = serv.Name,
                            Price = serv.Price
                        };

            Grid.ItemsSource = query.ToList();
        }

        private void AddClientMI_Click(object sender, RoutedEventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.ShowDialog();

            Grid.ItemsSource = from Client in Notary.Clients select Client;
        }

        private void AddServiceMI_Click(object sender, RoutedEventArgs e)
        {
            AddService addService = new AddService();
            addService.ShowDialog();

            var query = from service in Notary.Services select service;
            Grid.ItemsSource = query.ToList();
        }
    }
}
