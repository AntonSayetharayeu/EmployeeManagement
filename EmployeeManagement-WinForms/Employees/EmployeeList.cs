using EmployeeManagement.Model;
using EmployeeManagement.Services;

namespace EmployeeManagement_WinForms.Employees
{
    public partial class EmployeeList : Form
    {
        private BasicService<Employee> employeeService = new BasicService<Employee>();
        private BasicService<Role> roleService = new BasicService<Role>();

        public EmployeeList()
        {
            InitializeComponent();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            comboBoxRoleFilter.DataSource = roleService.GetElements().ToList();
        }

        private void LoadEmployees()
        {
            dataGridViewEmployees.DataSource = employeeService.GetElements().ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var employeeAddition = new EmployeeAddition();
            employeeAddition.ShowDialog();
            LoadEmployees();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                var selectedEmployee = (Employee)dataGridViewEmployees.SelectedRows[0].DataBoundItem;
                var employeeModification = new EmployeeModification(selectedEmployee);
                employeeModification.ShowDialog();
                LoadEmployees();
            }
            else
            {
                MessageBox.Show("Please select an employee to edit.", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                var selectedEmployee = (Employee)dataGridViewEmployees.SelectedRows[0].DataBoundItem;
                var confirmResult = MessageBox.Show("Are you sure to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    employeeService.DeleteElement(selectedEmployee.ID);
                    LoadEmployees();
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonApplyFilters_Click(object sender, EventArgs e)
        {
            var employees = employeeService.GetElements().AsQueryable();

            if (!string.IsNullOrEmpty(textBoxNameFilter.Text))
            {
                if (checkBoxExactName.Checked)
                {
                    employees = employees.Where(emp => emp.Name.Equals(textBoxNameFilter.Text, StringComparison.OrdinalIgnoreCase));
                }
                else
                {
                    employees = employees.Where(emp => emp.Name.Contains(textBoxNameFilter.Text, StringComparison.OrdinalIgnoreCase));
                }
            }

            if (!string.IsNullOrEmpty(textBoxSurnameFilter.Text))
            {
                if (checkBoxExactSurname.Checked)
                {
                    employees = employees.Where(emp => emp.Surname.Equals(textBoxSurnameFilter.Text, StringComparison.OrdinalIgnoreCase));
                }
                else
                {
                    employees = employees.Where(emp => emp.Surname.Contains(textBoxSurnameFilter.Text, StringComparison.OrdinalIgnoreCase));
                }
            }

            if (comboBoxRoleFilter.SelectedItem != null)
            {
                var selectedRole = (Role)comboBoxRoleFilter.SelectedItem;
                employees = employees.Where(emp => emp.RoleID == selectedRole.ID);
            }

            if (!string.IsNullOrEmpty(textBoxAgeFilter.Text) && int.TryParse(textBoxAgeFilter.Text, out int age))
            {
                switch (comboBoxAgeFilterCondition.SelectedItem)
                {
                    case "More":
                        employees = employees.Where(emp => emp.Age > age);
                        break;
                    case "Less":
                        employees = employees.Where(emp => emp.Age < age);
                        break;
                    case "Equals":
                        employees = employees.Where(emp => emp.Age == age);
                        break;
                }
            }

            dataGridViewEmployees.DataSource = employees.ToList();
        }
    }
}
