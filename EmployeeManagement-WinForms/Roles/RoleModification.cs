using EmployeeManagement.Model;
using EmployeeManagement.Services;
using System;
using System.Windows.Forms;

namespace EmployeeManagement_WinForms.Roles
{
    public partial class RoleModification : Form
    {
        private Role role;
        private BasicService<Role> roleService = new BasicService<Role>();

        public RoleModification(Role role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void RoleModification_Load(object sender, EventArgs e)
        {
            textBoxName.Text = role.Name;
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                role.Name = textBoxName.Text;

                roleService.UpdateElement(role);

                MessageBox.Show("Role updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Operation went wrong, try again later please!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
