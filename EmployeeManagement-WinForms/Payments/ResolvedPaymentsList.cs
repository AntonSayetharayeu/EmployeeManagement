using EmployeeManagement.App;
using EmployeeManagement.Model;
using EmployeeManagement.Services;
using System.Windows.Forms;

namespace EmployeeManagement_WinForms.Payments
{
    public partial class ResolvedPaymentsList : Form
    {
        private BasicService<Payment> paymentService = new BasicService<Payment>();
        private BasicService<Employee> employeeService = new BasicService<Employee>();

        public ResolvedPaymentsList()
        {
            InitializeComponent();
        }

        private void ResolvedPaymentsList_Load(object sender, EventArgs e)
        {
            LoadResolvedPayments();
        }

        private void LoadResolvedPayments()
        {
            var resolvedPayments = paymentService.GetElements()
                .Where(p => p.Status == AppConstants.DONE_STATUS_NUMBER || p.Status == AppConstants.CANCELED_STATUS_NUMBER)
                .ToList();
            var employees = employeeService.GetElements().ToList();

            var paymentDetails = from pay in resolvedPayments
                                 join emp in employees on pay.EmployeeID equals emp.ID
                                 select new
                                 {
                                     pay.ID,
                                     Employee = $"[{emp.ID}]{emp.Name} {emp.Surname}",
                                     pay.DateOfCreation,
                                     pay.DateOfClosing,
                                     pay.DefaultValue,
                                     pay.TaxValue,
                                     pay.BonusValue,
                                     pay.FinalValue,
                                     Status = GetStatusDescription(pay.Status)
                                 };

            dataGridViewResolvedPayments.DataSource = paymentDetails.ToList();

            if (dataGridViewResolvedPayments.Columns["ID"] != null)
            {
                dataGridViewResolvedPayments.Columns["ID"].Visible = false;
            }
        }

        private string GetStatusDescription(int status)
        {
            switch (status)
            {
                case AppConstants.DONE_STATUS_NUMBER:
                    return "Done";
                case AppConstants.CANCELED_STATUS_NUMBER:
                    return "Canceled";
                default:
                    return "Unknown";
            }
        }

        private void DataGridViewPayments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewResolvedPayments.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                switch (e.Value.ToString())
                {
                    case "Done":
                        e.CellStyle.ForeColor = Color.Green;
                        break;
                    case "Canceled":
                        e.CellStyle.ForeColor = Color.Red;
                        break;
                }
            }

            if ((dataGridViewResolvedPayments.Columns[e.ColumnIndex].Name == "DateOfCreation" ||
                 dataGridViewResolvedPayments.Columns[e.ColumnIndex].Name == "DateOfClosing") && e.Value != null)
            {
                if (e.Value is DateTime dateTimeValue)
                {
                    e.Value = dateTimeValue.ToString("yyyy-MM-dd");
                    e.FormattingApplied = true;
                }
            }
        }

        private void buttonCopyPayment_Click(object sender, EventArgs e)
        {
            if (dataGridViewResolvedPayments.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewResolvedPayments.SelectedRows[0];
                var selectedPayment = paymentService.GetElementById((int)selectedRow.Cells["ID"].Value);

                var paymentCopy = new PaymentRegistration(selectedPayment);
                paymentCopy.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a payment to copy.", "Edit Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
