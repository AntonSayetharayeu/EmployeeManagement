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
        BasicService<Role> roleService = new BasicService<Role>();
        LoginService loginService = new LoginService();

        public EmployeeAddition()
        {
            InitializeComponent();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPassword.Text.IsNullOrEmpty() || textBoxRepeatPassword.Text.IsNullOrEmpty() || !textBoxPassword.Text.Equals(textBoxRepeatPassword.Text)) 
                {
                    MessageBox.Show("Please, provide proper data for password!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                loginService.RegisterNewEmployee(new Employee 
                { 
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text,
                    Age = Convert.ToInt32(textBoxAge.Text),
                    Email = textBoxEmail.Text,
                    Password = textBoxPassword.Text,
                    IsDismissed = false,
                    RoleID = (comboBoxEmployeeRole.SelectedItem as Role).ID
                });

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
