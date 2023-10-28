using System;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class AddEmployee : Form
    {
        NotaryBaseDataContext Notary = new NotaryBaseDataContext();

        public AddEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SalaryTextBox.Text == "" || NameTextBox.Text == "")
                return;

            double salary;
            if (double.TryParse(SalaryTextBox.Text, out salary) == false)
                return;

            Employee emp = new Employee();
            emp.Name = NameTextBox.Text;
            emp.Salary = salary;
            emp.Post = PostTextBox.Text;
            emp.HireDate = DateTime.Now;
            emp.EmployeeID = Guid.NewGuid();

            Notary.Employee.InsertOnSubmit(emp);
            Notary.SubmitChanges();

            this.Close();
        }
    }
}
