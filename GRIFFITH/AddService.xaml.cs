using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GRIFFITH
{
    /// <summary>
    /// Логика взаимодействия для AddService.xaml
    /// </summary>
    public partial class AddService : Window
    {
        public AddService()
        {
            InitializeComponent();
        }
        DataClasses1DataContext Notary = new DataClasses1DataContext();

        private void AddServiceB_Click(object sender, RoutedEventArgs e)
        {
            Services service = new Services();
            service.Name = ServiceNameTB.Text;
            service.Price = Convert.ToSingle(ServicePriceTB.Text);
            service.Description = ServiceDescriptionTB.Text;
            service.ServiceID = Guid.NewGuid();

            Notary.Services.InsertOnSubmit(service);
            Notary.SubmitChanges();

            this.Close();
        }
    }
}
