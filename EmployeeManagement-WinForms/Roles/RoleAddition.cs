using EmployeeManagement.Model;
using EmployeeManagement.Services;
using System;
using System.Windows.Forms;

namespace EmployeeManagement_WinForms.Roles
{
    public partial class RoleAddition : Form
    {
        BasicService<Role> roleService = new BasicService<Role>();

        public RoleAddition()
        {
            InitializeComponent();
        }

        private void buttonAddRole_Click(object sender, EventArgs e)
        {
            try
            {
                Role newRole = new Role
                {
                    Name = textBoxRoleName.Text
                };

                roleService.AddElement(newRole);
                MessageBox.Show("Role added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Operation went wrong, try again later please!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
