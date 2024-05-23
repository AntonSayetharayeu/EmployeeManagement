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
            dataGridViewPayments.DataSource = paymentService.GetElements().ToList();
        }

        private void buttonChangeStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewPayments.SelectedRows.Count > 0)
            {
                var selectedPayment = (Payment)dataGridViewPayments.SelectedRows[0].DataBoundItem;

                switch (comboBoxStatus.SelectedItem)
                {
                    case "Created to Pending":
                        if (selectedPayment.Status == 0)
                        {
                            selectedPayment.Status = 1;
                            selectedPayment.DateOfLatestModification = DateTime.Now;
                            paymentService.UpdateElement(selectedPayment);
                        }
                        else
                        {
                            MessageBox.Show("Payment must be in 'Created' status to change to 'Pending'.", "Invalid Status Change", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    case "Pending to Done":
                        if (selectedPayment.Status == 1)
                        {
                            selectedPayment.Status = 2;
                            selectedPayment.DateOfEnd = DateTime.Now;
                            paymentService.UpdateElement(selectedPayment);
                        }
                        else
                        {
                            MessageBox.Show("Payment must be in 'Pending' status to change to 'Done'.", "Invalid Status Change", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    case "Cancel Payment":
                        selectedPayment.Status = 3;
                        selectedPayment.DateOfLatestModification = DateTime.Now;
                        paymentService.UpdateElement(selectedPayment);
                        break;
                }

                LoadPayments();
            }
            else
            {
                MessageBox.Show("Please select a payment to change status.", "Select Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonShowResolved_Click(object sender, EventArgs e)
        {
            var resolvedPayments = new ResolvedPaymentsList();
            resolvedPayments.ShowDialog();
        }
    }
}
