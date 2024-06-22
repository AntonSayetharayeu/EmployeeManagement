using EmployeeManagement.Model;
using EmployeeManagement.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeManagement_WinForms.Roles
{
    public partial class RoleList : Form
    {
        private BasicService<Role> roleService = new BasicService<Role>();
        private EmployeeService employeeService = new EmployeeService();

        public RoleList()
        {
            InitializeComponent();
        }

        private void RoleList_Load(object sender, EventArgs e)
        {
            LoadRoles();
        }

        private void LoadRoles()
        {
            dataGridViewRoles.DataSource = roleService.GetElements().ToList();

            if (dataGridViewRoles.Columns["ID"] != null)
            {
                dataGridViewRoles.Columns["ID"].Visible = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var roleAddition = new RoleAddition();
            roleAddition.ShowDialog();
            LoadRoles();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewRoles.SelectedRows.Count > 0)
            {
                var selectedRole = (Role)dataGridViewRoles.SelectedRows[0].DataBoundItem;
                var roleModification = new RoleModification(selectedRole);
                roleModification.ShowDialog();
                LoadRoles();
            }
            else
            {
                MessageBox.Show("Please select a role to edit.", "Edit Role", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewRoles.SelectedRows.Count > 0)
            {
                var selectedRole = (Role)dataGridViewRoles.SelectedRows[0].DataBoundItem;

                if (employeeService.CheckAreEmployeesWithRoleID(selectedRole.ID))
                {
                    MessageBox.Show("This role is assigned to one or more employees and cannot be deleted.", "Delete Role", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure to delete this role?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    roleService.DeleteElement(selectedRole.ID);
                    LoadRoles();
                }
            }
            else
            {
                MessageBox.Show("Please select a role to delete.", "Delete Role", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
