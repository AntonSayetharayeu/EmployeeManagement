using EmployeeManagement.Model;
using EmployeeManagement.Services;

namespace EmployeeManagement_WinForms.Deductions
{
    public partial class DeductionAddition : Form
    {
        private BasicService<Deduction> deductionService = new BasicService<Deduction>();

        public DeductionAddition()
        {
            InitializeComponent();
        }

        private void buttonAddDeduction_Click(object sender, EventArgs e)
        {
            try
            {
                var newDeduction = new Deduction
                {
                    Name = textBoxName.Text,
                    Description = textBoxDescription.Text,
                    IsPercentage = checkBoxIsPercentage.Checked,
                    Value = Convert.ToDecimal(textBoxValue.Text),
                    IsActive = true
                };

                if ((checkBoxDeductionType.Checked && newDeduction.Value < 0) ||
                    (!checkBoxDeductionType.Checked && newDeduction.Value > 0)) 
                { 
                    newDeduction.Value = -newDeduction.Value;
                }

                deductionService.AddElement(newDeduction);

                MessageBox.Show("Deduction added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Operation went wrong, try again later please!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
