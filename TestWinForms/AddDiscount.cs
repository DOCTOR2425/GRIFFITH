using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class AddDiscount : Form
    {
        private NotaryBaseDataContext Notary = new NotaryBaseDataContext();

        public AddDiscount()
        {
            InitializeComponent();
        }

        private void DownNewFlag(Discount discount)
        {
            (from disc in Notary.Discount
             where disc.Name == discount.Name
             select disc).ToList().ForEach(x => x.NewFlag = 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "" || PercentTextBox.Text == "" || DescriptionTextBox.Text == "")
                return;

            double percent;
            if (double.TryParse(PercentTextBox.Text, out percent) == false)
                return;

            Discount discount = new Discount();
            discount.Name = NameTextBox.Text;
            discount.Percent = percent;
            discount.Description = DescriptionTextBox.Text;
            discount.DiscountID = Guid.NewGuid();
            discount.NewFlag = 1;

            DownNewFlag(discount);

            Notary.Discount.InsertOnSubmit(discount);
            Notary.SubmitChanges();

            this.Close();
        }
    }
}
