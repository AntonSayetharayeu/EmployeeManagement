using EmployeeManagement.Model;
using EmployeeManagement.Repositories;

namespace EmployeeManagement.Services
{
    public class PaymentDeductionService : BasicService<PaymentDeduction>
    {
        private readonly PaymentDeductionRepository repository = new();

        public List<PaymentDeduction> GetPaymentDeductionsByDeductionID(int deductionID)
        {
            return repository.GetPaymentDeductionsByDeductionID(deductionID);
        }

        public List<PaymentDeduction> GetPaymentDeductionsByPaymentID(int paymentID)
        {
            return repository.GetPaymentDeductionsByPaymentID(paymentID);
        }
    }
}
