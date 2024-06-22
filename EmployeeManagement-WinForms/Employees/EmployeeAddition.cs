using EmployeeManagement.App;
using EmployeeManagement.Model;
using EmployeeManagement.Services;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement_WinForms.Employees
{
    public partial class EmployeeAddition : Form
    {
        BasicService<Role> roleService = new();
        EmployeeService employeeService = new();

        public EmployeeAddition()
        {
            InitializeComponent();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxEmployeeRole.SelectedItem == null)
                {
                    MessageBox.Show("Please select a role for the employee.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var employee = new Employee()
                {
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text,
                    Age = int.Parse(textBoxAge.Text),
                    Email = textBoxEmail.Text,
                    IsDismissed = false,
                    DefaultSalary = AppConstants.EMPLOYEE_DEFAULT_SALARY,
                    RoleID = (comboBoxEmployeeRole.SelectedItem as Role).ID
                };
                employeeService.AddElement(employee);
                Close();
            }
            catch
            {
                MessageBox.Show("Operation went wrong, try again later please!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void EmployeeAddition_Load(object sender, EventArgs e)
        {
            comboBoxEmployeeRole.DataSource = roleService.GetElements();
        }
    }
}
