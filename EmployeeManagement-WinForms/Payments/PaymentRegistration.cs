using EmployeeManagement.App;
using EmployeeManagement.Model;
using EmployeeManagement.Services;
using System.Data;

namespace EmployeeManagement_WinForms.Payments
{
    public partial class PaymentRegistration : Form
    {
        private Payment payment;

        private BasicService<Employee> employeeService = new();
        private BasicService<Deduction> deductionService = new();
        private PaymentService paymentService = new();
        private PaymentDeductionService paymentDeductionService = new();

        private List<Deduction> taxes = new();
        private List<Deduction> bonuses = new();
        private List<Deduction> selectedDeductions = new();

        private bool suppressCheckBoxEvents = false;

        private decimal defaultValue = 0;
        private decimal taxValue = 0;
        private decimal bonusValue = 0;
        private decimal finalValue = 0;

        public PaymentRegistration()
        {
            InitializeComponent();
        }

        public PaymentRegistration(Payment payment)
        {
            InitializeComponent();
            this.payment = payment;
        }

        #region Filter
        private void RefreshDeductionList()
        {
            listBoxDeductions.DataSource = null;
            listBoxSelectedDeductions.DataSource = null;

            if (checkBoxTaxes.Checked && checkBoxBonuses.Checked)
            {
                listBoxDeductions.DataSource = taxes.Concat(bonuses).ToList();
            }
            else if (checkBoxTaxes.Checked)
            {
                listBoxDeductions.DataSource = taxes;
            }
            else if (checkBoxBonuses.Checked)
            {
                listBoxDeductions.DataSource = bonuses;
            }
            else
            {
                listBoxDeductions.DataSource = taxes.Concat(bonuses).ToList();
            }

            listBoxSelectedDeductions.DataSource = selectedDeductions;
            UpdateTaxAndBonusLabels();
        }

        private void checkBoxTaxes_CheckedChanged(object sender, EventArgs e)
        {
            if (!suppressCheckBoxEvents)
            {
                RefreshDeductionList();
            }
        }

        private void checkBoxBonuses_CheckedChanged(object sender, EventArgs e)
        {
            if (!suppressCheckBoxEvents)
            {
                RefreshDeductionList();
            }
        }
        #endregion

        private void PaymentAddition_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            LoadDeductions();
        }

        #region Load
        private void LoadEmployees()
        {
            listBoxEmployees.DataSource = employeeService.GetElements()
                .Where(emp => !emp.IsDismissed).ToList();

            if (payment != null)
            {
                var employee = employeeService.GetElementById(payment.EmployeeID);

                if (employee != null && !employee.IsDismissed) 
                {
                    listBoxEmployees.SelectedItem = employee;
                }
            }
        }

        private void LoadDeductions()
        {
            var allDeductions = deductionService.GetElements().Where(d => d.IsActive).ToList();
            taxes = allDeductions.Where(d => d.Value < 0).ToList();
            bonuses = allDeductions.Where(d => d.Value > 0).ToList();
            selectedDeductions.Clear();

            if (payment != null)
            {
                var connectedPD = paymentDeductionService.GetPaymentDeductionsByPaymentID(payment.ID);
                var connectedDeductions = connectedPD.Select(pd => deductionService.GetElementById(pd.DeductionID));
                connectedDeductions = connectedDeductions.Where(d => d.IsActive);

                taxes = taxes.Where(d => !connectedDeductions.Any(cd => cd.ID == d.ID)).ToList();
                bonuses = bonuses.Where(d => !connectedDeductions.Any(cd => cd.ID == d.ID)).ToList();

                selectedDeductions.AddRange(connectedDeductions);
            }

            RefreshDeductionList();
        }
        #endregion

        #region Selection
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (listBoxDeductions.SelectedIndex >= 0)
            {
                var selectedDeduction = (Deduction)listBoxDeductions.SelectedItem;
                selectedDeductions.Add(selectedDeduction);
                RemoveFromAvailableLists(selectedDeduction);

                RefreshDeductionList();
            }
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            if (checkBoxTaxes.Checked && checkBoxBonuses.Checked)
            {
                selectedDeductions.AddRange(taxes);
                selectedDeductions.AddRange(bonuses);
                taxes.Clear();
                bonuses.Clear();
            }
            else if (checkBoxTaxes.Checked)
            {
                selectedDeductions.AddRange(taxes);
                taxes.Clear();
            }
            else if (checkBoxBonuses.Checked)
            {
                selectedDeductions.AddRange(bonuses);
                bonuses.Clear();
            }
            else
            {
                selectedDeductions.AddRange(taxes);
                selectedDeductions.AddRange(bonuses);
                taxes.Clear();
                bonuses.Clear();
            }

            suppressCheckBoxEvents = true;
            checkBoxBonuses.Checked = false;
            checkBoxTaxes.Checked = false;
            suppressCheckBoxEvents = false;

            RefreshDeductionList();
        }

        private void buttonUnselectAll_Click(object sender, EventArgs e)
        {
            suppressCheckBoxEvents = true;
            checkBoxBonuses.Checked = false;
            checkBoxTaxes.Checked = false;
            suppressCheckBoxEvents = false;

            taxes.AddRange(selectedDeductions.Where(deduction => deduction.Value < 0));
            bonuses.AddRange(selectedDeductions.Where(deduction => deduction.Value > 0));
            selectedDeductions.Clear();

            RefreshDeductionList();
        }

        private void buttonUnselect_Click(object sender, EventArgs e)
        {
            if (listBoxSelectedDeductions.SelectedIndex >= 0)
            {
                var selectedDeduction = (Deduction)listBoxSelectedDeductions.SelectedItem;
                if (selectedDeduction.Value < 0)
                {
                    taxes.Add(selectedDeduction);
                }
                else
                {
                    bonuses.Add(selectedDeduction);
                }
                selectedDeductions.Remove(selectedDeduction);

                RefreshDeductionList();
            }
        }

        private void RemoveFromAvailableLists(Deduction deduction)
        {
            taxes.Remove(deduction);
            bonuses.Remove(deduction);
        }

        private void listBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDefaultValueLabel();
            UpdateTaxAndBonusLabels();
        }

        private void UpdateDefaultValueLabel()
        {
            var selectedEmployee = listBoxEmployees.SelectedItem as Employee;
            defaultValue = selectedEmployee?.DefaultSalary ?? 0m;
            labelDefaultValue.Text = $"{defaultValue.ToString("0.00")} $";
        }
        #endregion

        #region Tax and Bonus Value Calculation
        private void UpdateTaxAndBonusLabels()
        {
            var selectedEmployee = listBoxEmployees.SelectedItem as Employee;
            defaultValue = selectedEmployee?.DefaultSalary ?? 0m;

            taxValue = selectedDeductions
                .Where(d => d.Value < 0)
                .Sum(d => d.IsPercentage ? defaultValue * (d.Value / 100) : d.Value);

            bonusValue = selectedDeductions
                .Where(d => d.Value > 0)
                .Sum(d => d.IsPercentage ? defaultValue * (d.Value / 100) : d.Value);

            labelTaxValue.Text = $"{taxValue.ToString("0.00")} $";
            labelBonusValue.Text = $"{bonusValue.ToString("0.00")} $";

            finalValue = defaultValue + taxValue + bonusValue;
            labelTotalValue.Text = $"{finalValue.ToString("0.00")} $";
        }
        #endregion

        #region Payment Creation
        private void buttonCreatePayment_Click(object sender, EventArgs e)
        {
            var selectedEmployee = listBoxEmployees.SelectedItem as Employee;
            if (selectedEmployee == null)
            {
                MessageBox.Show("Please select an employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidatePayment(defaultValue, taxValue, bonusValue))
            {
                MessageBox.Show("The combined Tax and Bonus values cannot change the Default Value by more than 40%.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (payment != null && payment.Status == AppConstants.CREATED_STATUS_NUMBER)
                {
                    paymentService.UpdateCreatedPayment(payment, 
                        new Dictionary<string, decimal>
                        {
                            { "DefaultValue", defaultValue},
                            { "TaxValue", taxValue },
                            { "BonusValue", bonusValue },
                            { "FinalValue", finalValue }
                        }, selectedEmployee.ID, selectedDeductions);

                    MessageBox.Show($"Payment modified successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    return;
                }

                paymentService.RegisterNewPayment(new Dictionary<string, decimal>
                {
                    { "DefaultValue", defaultValue},
                    { "TaxValue", taxValue },
                    { "BonusValue", bonusValue },
                    { "FinalValue", finalValue }
                }, selectedEmployee.ID, selectedDeductions);

                MessageBox.Show($"Payment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while registrarion the payment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidatePayment(decimal defaultValue, decimal taxValue, decimal bonusValue)
        {
            decimal totalChange = Math.Abs(taxValue) + Math.Abs(bonusValue);
            decimal threshold = defaultValue * AppConstants.MAX_TOTAL_CHANGE;
            return totalChange <= threshold;
        }
        #endregion
    }
}
