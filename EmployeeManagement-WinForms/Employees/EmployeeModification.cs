using EmployeeManagement.Model;
using EmployeeManagement.Services;
using System;
using System.Windows.Forms;

namespace EmployeeManagement_WinForms.Employees
{
    public partial class EmployeeModification : Form
    {
        private Employee employee;
        private BasicService<Role> roleService = new BasicService<Role>();
        private BasicService<Employee> employeeService = new BasicService<Employee>();

        public EmployeeModification(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void EmployeeModification_Load(object sender, EventArgs e)
        {
            comboBoxEmployeeRole.DataSource = roleService.GetElements();
            textBoxName.Text = employee.Name;
            textBoxSurname.Text = employee.Surname;
            textBoxAge.Text = employee.Age.ToString();
            textBoxEmail.Text = employee.Email;
            comboBoxEmployeeRole.SelectedItem = roleService.GetElementById(employee.RoleID);
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                employee.Name = textBoxName.Text;
                employee.Surname = textBoxSurname.Text;
                employee.Age = Convert.ToInt32(textBoxAge.Text);
                employee.Email = textBoxEmail.Text;
                employee.RoleID = (comboBoxEmployeeRole.SelectedItem as Role).ID;

                employeeService.UpdateElement(employee);

                MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Operation went wrong, try again later please!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
