using EmployeeManagement.Model;
using EmployeeManagement.Services;

namespace EmployeeManagement_WinForms.Deductions
{
    public partial class DeductionList : Form
    {
        private BasicService<Deduction> deductionService = new BasicService<Deduction>();

        public DeductionList()
        {
            InitializeComponent();
        }

        private void DeductionList_Load(object sender, EventArgs e)
        {
            LoadDeductions();
        }

        private void LoadDeductions()
        {
            dataGridViewDeductions.DataSource = deductionService.GetElements().ToList();
        }

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
                var confirmResult = MessageBox.Show("Are you sure to delete this deduction?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    deductionService.DeleteElement(selectedDeduction.ID);
                    LoadDeductions();
                }
            }
            else
            {
                MessageBox.Show("Please select a deduction to delete.", "Delete Deduction", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
