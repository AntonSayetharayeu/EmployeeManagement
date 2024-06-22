using EmployeeManagement.App;
using EmployeeManagement.Model;
using EmployeeManagement.Services;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace EmployeeManagement_WinForms.Payments
{
    public partial class PaymentList : Form
    {
        private BasicService<Payment> paymentService = new BasicService<Payment>();
        private BasicService<Employee> employeeService = new BasicService<Employee>();

        public PaymentList()
        {
            InitializeComponent();
        }

        private void PaymentsList_Load(object sender, EventArgs e)
        {
            LoadPayments();
        }

        private void LoadPayments()
        {
            var payments = paymentService.GetElements()
                .Where(p => new[] { AppConstants.CREATED_STATUS_NUMBER, AppConstants.PENDING_STATUS_NUMBER }
                .Contains(p.Status)).ToList();
            var employees = employeeService.GetElements().ToList();

            var paymentDetails = from pay in payments
                                 join emp in employees on pay.EmployeeID equals emp.ID
                                 select new
                                 {
                                     pay.ID,
                                     Employee = $"[{emp.ID}]{emp.Name} {emp.Surname}",
                                     pay.DateOfCreation,
                                     pay.DateOfLatestModification,
                                     pay.DefaultValue,
                                     pay.TaxValue,
                                     pay.BonusValue,
                                     pay.FinalValue,
                                     Status = GetStatusDescription(pay.Status)
                                 };

            dataGridViewPayments.DataSource = paymentDetails.ToList();

            if (dataGridViewPayments.Columns["ID"] != null)
            {
                dataGridViewPayments.Columns["ID"].Visible = false;
            }
        }

        private void LoadPayments(Payment payment)
        {
            LoadPayments();

            foreach (DataGridViewRow row in dataGridViewPayments.Rows)
            {
                if ((int)row.Cells["ID"].Value == payment.ID)
                {
                    row.Selected = true;
                    dataGridViewPayments.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        #region Status
        private string GetStatusDescription(int status)
        {
            switch (status)
            {
                case AppConstants.CREATED_STATUS_NUMBER:
                    return "Created";
                case AppConstants.PENDING_STATUS_NUMBER:
                    return "Pending";
                case AppConstants.DONE_STATUS_NUMBER:
                    return "Done";
                case AppConstants.CANCELED_STATUS_NUMBER:
                    return "Canceled";
                default:
                    return "Unknown";
            }
        }

        private void dataGridViewPayments_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewPayments.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                switch (e.Value.ToString())
                {
                    case "Created":
                        e.CellStyle.ForeColor = Color.Gray;
                        break;
                    case "Pending":
                        e.CellStyle.ForeColor = Color.DarkOrange;
                        break;
                    case "Done":
                        e.CellStyle.ForeColor = Color.Green;
                        break;
                    case "Canceled":
                        e.CellStyle.ForeColor = Color.Red;
                        break;
                }
            }

            if ((dataGridViewPayments.Columns[e.ColumnIndex].Name == "DateOfCreation" ||
                 dataGridViewPayments.Columns[e.ColumnIndex].Name == "DateOfLatestModification" ||
                 dataGridViewPayments.Columns[e.ColumnIndex].Name == "DateOfClosing") && e.Value != null)
            {
                if (e.Value is DateTime dateTimeValue)
                {
                    e.Value = dateTimeValue.ToString("yyyy-MM-dd");
                    e.FormattingApplied = true;
                }
            }
        }

        private void buttonCommit_Click(object sender, EventArgs e)
        {
            if (dataGridViewPayments.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewPayments.SelectedRows[0];
                var selectedPayment = paymentService.GetElementById((int)selectedRow.Cells["ID"].Value);

                if (selectedPayment.Status == AppConstants.CREATED_STATUS_NUMBER)
                {
                    selectedPayment.Status++;
                    selectedPayment.DateOfLatestModification = DateTime.Now;
                    paymentService.UpdateElement(selectedPayment);
                    LoadPayments(selectedPayment);
                }
                else
                {
                    MessageBox.Show("Only payments with status 'Created' can be committed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a payment to commit.", "Edit Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonResolve_Click(object sender, EventArgs e)
        {
            if (dataGridViewPayments.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewPayments.SelectedRows[0];
                var selectedPayment = paymentService.GetElementById((int)selectedRow.Cells["ID"].Value);

                if (selectedPayment.Status == AppConstants.PENDING_STATUS_NUMBER)
                {
                    selectedPayment.Status++;
                    selectedPayment.DateOfClosing = DateTime.Now;
                    paymentService.UpdateElement(selectedPayment);
                    LoadPayments(selectedPayment);
                }
                else
                {
                    MessageBox.Show("Only payments with status 'Pending' can be resolved.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a payment to resolve.", "Edit Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonRevert_Click(object sender, EventArgs e)
        {
            if (dataGridViewPayments.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewPayments.SelectedRows[0];
                var selectedPayment = paymentService.GetElementById((int)selectedRow.Cells["ID"].Value);

                if (selectedPayment.Status == AppConstants.PENDING_STATUS_NUMBER)
                {
                    selectedPayment.Status--;
                    selectedPayment.DateOfLatestModification = DateTime.Now;
                    paymentService.UpdateElement(selectedPayment);
                    LoadPayments(selectedPayment);
                }
                else
                {
                    MessageBox.Show("Only payments with status 'Pending' can be reverted to 'Created'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a payment to revert status.", "Edit Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        private void buttonShowResolved_Click(object sender, EventArgs e)
        {
            var resolvedPayments = new ResolvedPaymentsList();
            resolvedPayments.ShowDialog();
            LoadPayments();
        }

        private void buttonCreatePayment_Click(object sender, EventArgs e)
        {
            var createPayment = new PaymentRegistration();
            createPayment.ShowDialog();
            LoadPayments();
        }

        #region CRUD
        private void buttonEditPayment_Click(object sender, EventArgs e)
        {
            if (dataGridViewPayments.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewPayments.SelectedRows[0];
                var selectedPayment = paymentService.GetElementById((int)selectedRow.Cells["ID"].Value);

                if (selectedPayment.Status != AppConstants.CREATED_STATUS_NUMBER)
                {
                    MessageBox.Show("Only payments with status 'Created' can be deleted.", "Delete Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var paymentModification = new PaymentRegistration(selectedPayment);
                paymentModification.ShowDialog();
                LoadPayments(selectedPayment);
            }
            else
            {
                MessageBox.Show("Please select a payment to edit.", "Edit Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonRemovePayment_Click(object sender, EventArgs e)
        {
            if (dataGridViewPayments.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewPayments.SelectedRows[0];
                var selectedPayment = paymentService.GetElementById((int)selectedRow.Cells["ID"].Value);

                if (selectedPayment.Status != AppConstants.CREATED_STATUS_NUMBER)
                {
                    MessageBox.Show("Only payments with status 'Created' can be deleted.", "Delete Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure to delete this payment?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    selectedPayment.Status = AppConstants.CANCELED_STATUS_NUMBER;
                    paymentService.UpdateElement(selectedPayment);
                    LoadPayments();
                }
            }
            else
            {
                MessageBox.Show("Please select a payment to delete.", "Delete Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
    }
}
