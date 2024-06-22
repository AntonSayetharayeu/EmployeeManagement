using EmployeeManagement.Model;
using EmployeeManagement.Services;

namespace EmployeeManagement_WinForms.Employees
{
    public partial class EmployeeSalaryModification : Form
    {
        private BasicService<Employee> employeeService = new BasicService<Employee>();
        private Employee employee;

        public EmployeeSalaryModification(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;

            if (employee != null)
            {
                numericUpDownSalary.Value = employee.DefaultSalary;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to modify the salary?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                employee.DefaultSalary = numericUpDownSalary.Value;

                MessageBox.Show("New mployee salary saved successfully! Save Employee modifications.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
