using EmployeeManagement.Model;
using EmployeeManagement.Services;

namespace EmployeeManagement_WinForms.Deductions
{
    public partial class DeductionModification : Form
    {
        private Deduction deduction;
        private BasicService<Deduction> deductionService = new BasicService<Deduction>();

        public DeductionModification(Deduction deduction)
        {
            InitializeComponent();
            this.deduction = deduction;
        }

        private void DeductionModification_Load(object sender, EventArgs e)
        {
            textBoxName.Text = deduction.Name;
            textBoxDescription.Text = deduction.Description;
            checkBoxIsPercentage.Checked = deduction.IsPercentage;
            checkBoxDeductionType.Checked = deduction.Value > 0;
            textBoxValue.Text = deduction.Value.ToString();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                deduction.Name = textBoxName.Text;
                deduction.Description = textBoxDescription.Text;
                deduction.IsPercentage = checkBoxIsPercentage.Checked;
                deduction.Value = Convert.ToDecimal(textBoxValue.Text);

                if ((checkBoxDeductionType.Checked && deduction.Value < 0) ||
                    (!checkBoxDeductionType.Checked && deduction.Value > 0))
                {
                    deduction.Value = -deduction.Value;
                }

                deductionService.UpdateElement(deduction);

                MessageBox.Show("Deduction updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Operation went wrong, try again later please!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
