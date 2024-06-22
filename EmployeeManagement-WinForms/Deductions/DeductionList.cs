using EmployeeManagement.Model;
using EmployeeManagement.Services;

namespace EmployeeManagement_WinForms.Deductions
{
    public partial class DeductionList : Form
    {
        private BasicService<Deduction> deductionService = new BasicService<Deduction>();
        private PaymentDeductionService paymentDeductionService = new PaymentDeductionService();
        private PaymentService paymentService = new PaymentService();

        public DeductionList()
        {
            InitializeComponent();
            dataGridViewDeductions.CellFormatting += DataGridViewDeductions_CellFormatting;
        }

        private void DeductionList_Load(object sender, EventArgs e)
        {
            LoadDeductions();
        }

        private void LoadDeductions()
        {
            dataGridViewDeductions.DataSource = deductionService.GetElements().Where(d => d.IsActive).ToList();

            if (dataGridViewDeductions.Columns["ID"] != null)
            {
                dataGridViewDeductions.Columns["ID"].Visible = false;
            }

            if (dataGridViewDeductions.Columns["IsActive"] != null)
            {
                dataGridViewDeductions.Columns["IsActive"].Visible = false;
            }
        }

        private void DataGridViewDeductions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewDeductions.Columns[e.ColumnIndex].Name == "Name" && e.RowIndex >= 0)
            {
                var value = (decimal)dataGridViewDeductions.Rows[e.RowIndex].Cells["Value"].Value;

                if (value < 0)
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else if (value > 0)
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
            }
        }

        #region CRUD
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var deductionAddition = new DeductionAddition();
            deductionAddition.ShowDialog();
            LoadDeductions();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewDeductions.SelectedRows.Count > 0)
            {
                var selectedDeduction = (Deduction)dataGridViewDeductions.SelectedRows[0].DataBoundItem;
                var deductionModification = new DeductionModification(selectedDeduction);
                deductionModification.ShowDialog();
                LoadDeductions();
            }
            else
            {
                MessageBox.Show("Please select a deduction to edit.", "Edit Deduction", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewDeductions.SelectedRows.Count > 0)
            {         
                var selectedDeduction = (Deduction)dataGridViewDeductions.SelectedRows[0].DataBoundItem;

                var paymentDeductions = paymentDeductionService.GetPaymentDeductionsByDeductionID(selectedDeduction.ID);
                var hasPendingOrCreatedPayments = paymentService.CheckArePaymentsByPaymentDeductions(paymentDeductions);

                if (hasPendingOrCreatedPayments)
                {
                    MessageBox.Show("This deduction is assigned to a payment with status Created or Pending and cannot be deleted.", "Delete Deduction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure to delete this deduction?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    selectedDeduction.IsActive = false;
                    deductionService.UpdateElement(selectedDeduction);
                    LoadDeductions();
                }
            }
            else
            {
                MessageBox.Show("Please select a deduction to delete.", "Delete Deduction", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
