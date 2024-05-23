using EmployeeManagement.Services;
using EmployeeManagement.Model;
using EmployeeManagement_WinForms.Employees;
using System.Security.Cryptography;
using EmployeeManagement_WinForms.Roles;
using EmployeeManagement_WinForms.Deductions;
using EmployeeManagement_WinForms.Payments;

namespace EmployeeManagement_WinForms
{
    public partial class MainMenu : Form
    {
        private BasicService<Employee> basicService = new BasicService<Employee>();
        private LoginService loginService = new LoginService();
        private Employee loggedInUser;

        public MainMenu()
        {
            InitializeComponent();
        }

        /*private void MainMenu_Load(object sender, EventArgs e)
        {
            dataGridViewRoles.DataSource = basicService.GetElements();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            dataGridViewRoles.DataSource = new List<Employee> { basicService.GetElementById((int)numericUpDownRoleID.Value) };
        }

        private void buttonCheckAll_Click(object sender, EventArgs e)
        {
            dataGridViewRoles.DataSource = basicService.GetElements();
        }

        private void buttonAddRole_Click(object sender, EventArgs e)
        {
            //service.AddRole(new Role { Name = textBoxRoleName.Text });
            //dataGridViewRoles.DataSource = service.GetRoles();

            basicService.AddElement(new Employee
            {
                Name = textBoxRoleName.Text
            });
            dataGridViewRoles.DataSource = basicService.GetElements();
            //dataGridViewRoles.DataSource = service.GetRoles();
        }

        private void buttonDeleteRole_Click(object sender, EventArgs e)
        {
            *//*Role? role = dataGridViewRoles.SelectedRows[0].DataBoundItem as Role;

            if (role == null)
            {
                return;
            }

            service.DeleteRole(role.ID);
            dataGridViewRoles.DataSource = service.GetRoles();*//*

            Employee? deduction = dataGridViewRoles.SelectedRows[0].DataBoundItem as Employee;

            if (deduction == null)
            {
                return;
            }

            basicService.DeleteElement(deduction.ID);
            dataGridViewRoles.DataSource = basicService.GetElements();
        }

        private void buttonEditRole_Click(object sender, EventArgs e)
        {
            *//*Role? role = dataGridViewRoles.SelectedRows[0].DataBoundItem as Role;

            if (role == null)
            {
                return;
            }

            role.Name = textBoxEditRole.Text;

            service.UpdateRole(role);
            dataGridViewRoles.DataSource = service.GetRoles();*//*

            Employee? deduction = dataGridViewRoles.SelectedRows[0].DataBoundItem as Employee;

            if (deduction == null)
            {
                return;
            }

            deduction.Name = textBoxEditRole.Text;

            basicService.UpdateElement(deduction);
            dataGridViewRoles.DataSource = basicService.GetElements();

            textBoxEditRole.Text = string.Empty;
        }*/

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            var employeeList = new EmployeeList();
            employeeList.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            /*try
            {
                loggedInUser = loginService.LogIn(textBoxLogin.Text, textBoxPassword.Text);

                if (loggedInUser != null)
                {
                    Hide();
                    MessageBox.Show($"Logged in as {loggedInUser.Name} {loggedInUser.Surname}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var employeeList = new EmployeeList();
                    employeeList.ShowDialog();
                    Close();
                    return;
                }

                MessageBox.Show("Did not managed to log in!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch 
            {
                MessageBox.Show("Operation went wrong, try again later please!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

            var employeeList = new EmployeeList();
            employeeList.ShowDialog();
        }

        private void buttonRoles_Click(object sender, EventArgs e)
        {
            var roleList = new RoleList();
            roleList.ShowDialog();
        }

        private void buttonDeductions_Click(object sender, EventArgs e)
        {
            var deductionList = new DeductionList();
            deductionList.ShowDialog();
        }

        private void buttonPayments_Click(object sender, EventArgs e)
        {
            var paymentList = new PaymentList();
            paymentList.ShowDialog();
        }
    }
}
