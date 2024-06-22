using EmployeeManagement.App;
using EmployeeManagement.Model;
using EmployeeManagement.Services;

namespace EmployeeManagement_WinForms.Employees
{
    public partial class EmployeeList : Form
    {
        private BasicService<Employee> employeeService = new BasicService<Employee>();
        private BasicService<Role> roleService = new BasicService<Role>();
        private PaymentService paymentService = new PaymentService();

        public EmployeeList()
        {
            InitializeComponent();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            var employees = employeeService.GetElements()
                .Where(emp => !emp.IsDismissed).ToList();
            var roles = roleService.GetElements().ToList();

            var employeeRoles = from emp in employees
                                join role in roles on emp.RoleID equals role.ID
                                select new
                                {
                                    emp.ID,
                                    emp.Name,
                                    emp.Surname,
                                    emp.Age,
                                    emp.Email,
                                    Role = role.Name,
                                    emp.RoleID,
                                    emp.IsDismissed
                                };

            dataGridViewEmployees.DataSource = employeeRoles.ToList();

            if (dataGridViewEmployees.Columns["ID"] != null)
            {
                dataGridViewEmployees.Columns["ID"].Visible = false;
            }

            if (dataGridViewEmployees.Columns["RoleID"] != null)
            {
                dataGridViewEmployees.Columns["RoleID"].Visible = false;
            }
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
                var selectedEmployeeID = (int)dataGridViewEmployees.SelectedRows[0].Cells["ID"].Value;
                var selectedEmployee = employeeService.GetElementById(selectedEmployeeID);

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
                var selectedRow = dataGridViewEmployees.SelectedRows[0];

                var payments = paymentService.GetPaymentsWithEmployeeID((int)selectedRow.Cells["ID"].Value);
                var hasPendingOrCreatedPayments = payments.Any(p => p.Status == AppConstants.CREATED_STATUS_NUMBER || p.Status == AppConstants.PENDING_STATUS_NUMBER);

                if (hasPendingOrCreatedPayments)
                {
                    MessageBox.Show("This employee has payments that are not Done or Canceled and cannot be deleted.", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    var selectedEmployee = employeeService.GetElementById((int)selectedRow.Cells["ID"].Value);
                    selectedEmployee.IsDismissed = true;
                    employeeService.UpdateElement(selectedEmployee);
                    LoadEmployees();
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
