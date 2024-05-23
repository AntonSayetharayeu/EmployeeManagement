using EmployeeManagement.Model;
using EmployeeManagement.Services;

namespace EmployeeManagement_WinForms.Payments
{
    public partial class ResolvedPaymentsList : Form
    {
        private BasicService<Payment> paymentService = new BasicService<Payment>();

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
            var resolvedPayments = paymentService.GetElements().Where(p => p.Status == 2 || p.Status == 3).ToList();
            dataGridViewResolvedPayments.DataSource = resolvedPayments;
        }
    }
}
