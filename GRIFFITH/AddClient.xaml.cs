using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace GRIFFITH
{
    /// <summary>
    /// Логика взаимодействия для AddClient.xaml
    /// </summary>
    public partial class AddClient : Window
    {
        DataClasses1DataContext Notary = new DataClasses1DataContext();
        List<RadioButton> radiobuttons;
        
        public AddClient()
        {
            InitializeComponent();
            var services = (from service in Notary.Services select service).ToList();
            radiobuttons = new List<RadioButton>(services.Count);
            GroupServices.DataContext = radiobuttons;

            for (int i = 0; i < services.Count; i++)
            {
                radiobuttons.Add(new RadioButton());
                radiobuttons[i].Content = services[i].Name;
            }
        }

        private void AddClientButton_Click(object sender, RoutedEventArgs e)
        {
            if (ClientNameTB.Text == "" || ClientTelTB.Text == "" || ClientActivTB.Text == "")
                return;

            Clients client = new Clients();
            Orders order = new Orders();

            client.Name = ClientNameTB.Text;
            client.Telephone = ClientTelTB.Text;
            client.Activity = ClientActivTB.Text;
            client.ClientID = Guid.NewGuid();
            Notary.Clients.InsertOnSubmit(client);

            order.Date = DateTime.Now;
            order.OrderID = Guid.NewGuid();
            order.ClientID = client.ClientID;
            order.ServiceID = GetSelectedService();
            Notary.Orders.InsertOnSubmit(order);

            Notary.SubmitChanges();
        }

        private Guid GetSelectedService()
        {
            Guid id = new Guid();

            foreach (var checkbox in radiobuttons)
            {
                if ((bool)checkbox.IsChecked)
                {
                    id = (from service in Notary.Services
                          where service.Name == checkbox.Name
                          select service).ToList().First().ServiceID;
                }
            }
            return id;
        }
    }
}
