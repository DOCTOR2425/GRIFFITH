using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class AddService : Form
    {
        private NotaryBaseDataContext Notary = new NotaryBaseDataContext();

        public AddService()
        {
            InitializeComponent();
        }

        private void DownNewFlag(Service service)
        {
            (from serv in Notary.Service
             where serv.Name == service.Name
             select serv).ToList().ForEach(x => x.NewFlag = 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "" || PriceTextBox.Text == "" || DescriptionTextBox.Text == "")
                return;

            double price;
            if (double.TryParse(PriceTextBox.Text, out price) == false)
                return;

            Service service = new Service();
            service.Name = NameTextBox.Text;
            service.Price = price;
            service.Description = DescriptionTextBox.Text;
            service.ServiceID = Guid.NewGuid();
            service.NewFlag = 1;

            DownNewFlag(service);

            Notary.Service.InsertOnSubmit(service);
            Notary.SubmitChanges();

            this.Close();
        }
    }
}
