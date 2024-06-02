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
            if (SalaryTB.Text == "" || NameTB.Text == "")
            {
                MessageBox.Show("Вы не ввели все данные", "Нет данных", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(IsNameValid() == false)
            {
                MessageBox.Show("Неправильно введённые данные ФИО работника", "Ошибка формата данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double salary;
            if (double.TryParse(SalaryTB.Text, out salary) == false)
            {
                SalaryTB.Text = "";
                MessageBox.Show("Неверно введённые данные о зарплате\nПроверьте правильность формата введённых данных",
                                "Ошибка формата данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            if(salary < 600)
            {
                SalaryTB.Text = "";
                MessageBox.Show("Неверно введённые данные о зарплате\nВы ввели зарплату меньше минимальной (меньше 600)",
                                "Ошибка введённых данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            Employee emp = new Employee();
            emp.Name = NameTB.Text;
            emp.Salary = salary;
            emp.Post = PostTB.Text;
            emp.HireDate = DateTime.Now;
            emp.EmployeeID = Guid.NewGuid();

            Notary.Employee.InsertOnSubmit(emp);
            Notary.SubmitChanges();

            this.Close();
        }
        private bool IsNameValid()
        {
            if (NameTB.Text.Contains(" ") == false)
                return false;
            else if (NameTB.Text.Length < 6)
                return false;

            foreach (char s in NameTB.Text)
                if (Char.IsDigit(s))
                    return false;

            return true;
        }
    }
}
