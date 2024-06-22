using EmployeeManagement.App;
using EmployeeManagement.Model;
using EmployeeManagement.Repositories;
using System.Data;

namespace EmployeeManagement.Services
{
    public class PaymentService : BasicService<Payment>
    {
        private readonly PaymentRepository paymentRepository = new();

        public List<Payment> GetPaymentsWithEmployeeID(int employeeID)
        {
            return paymentRepository.GetPaymentsByEmployeeID(employeeID);
        }

        public bool CheckArePaymentsByPaymentDeductions(List<PaymentDeduction> paymentDeductions)
        {
            var paymentIDs = paymentDeductions.Select(pd => pd.PaymentID).Distinct().ToList();
            var payments = paymentIDs.Select(paymentRepository.GetElementById).ToList();
            return payments.Any(payment => payment.Status == AppConstants.CREATED_STATUS_NUMBER || payment.Status == AppConstants.PENDING_STATUS_NUMBER);
        }

        public void RegisterNewPayment(Dictionary<string, decimal> values, int employeeID, List<Deduction> deductions)
        {
            paymentRepository.AddNewPayment(new Payment
            {
                Status = AppConstants.CREATED_STATUS_NUMBER,
                DateOfCreation = DateTime.Now,
                DateOfLatestModification = DateTime.Now,
                DefaultValue = values["DefaultValue"],
                TaxValue = values["TaxValue"],
                BonusValue = values["BonusValue"],
                FinalValue = values["FinalValue"],
                EmployeeID = employeeID
            }, deductions);
        }

        public void UpdateCreatedPayment(Payment payment, Dictionary<string, decimal> values, int employeeID, List<Deduction> deductions)
        {
            payment.DefaultValue = values["DefaultValue"];
            payment.TaxValue = values["TaxValue"];
            payment.BonusValue = values["BonusValue"];
            payment.FinalValue = values["FinalValue"];
            payment.EmployeeID = employeeID;
            payment.DateOfLatestModification = DateTime.Now;

            paymentRepository.UpdatePayment(payment, deductions);
        }
    }
}
