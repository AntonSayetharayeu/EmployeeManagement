using EmployeeManagement.Model;
using Microsoft.Data.SqlClient;
using System.Data;

namespace EmployeeManagement.Repositories
{
    public class PaymentDeductionRepository : BasicRepository<PaymentDeduction>
    {
        public List<PaymentDeduction> GetPaymentDeductionsByDeductionID(int deductionID)
        {
            SqlCommand cmd = new SqlCommand($"SELECT * FROM {TablesMap[typeof(PaymentDeduction)]} WHERE DeductionID = @deductionID");
            SqlParameter deductionIDParameter = new SqlParameter("@deductionID", deductionID);
            cmd.Parameters.Add(deductionIDParameter);

            PrepareData(cmd);

            List<PaymentDeduction> paymentDeductions = new();
            foreach (DataRow row in Data.Tables[0].Rows)
            {
                paymentDeductions.Add(new PaymentDeduction().CreateModel(row));
            }

            return paymentDeductions;
        }

        public List<PaymentDeduction> GetPaymentDeductionsByPaymentID(int paymentID)
        {
            SqlCommand cmd = new SqlCommand($"SELECT * FROM {TablesMap[typeof(PaymentDeduction)]} WHERE PaymentID = @paymentID");
            SqlParameter paymentIDParameter = new SqlParameter("@paymentID", paymentID);
            cmd.Parameters.Add(paymentIDParameter);

            PrepareData(cmd);

            List<PaymentDeduction> paymentDeductions = new();
            foreach (DataRow row in Data.Tables[0].Rows)
            {
                paymentDeductions.Add(new PaymentDeduction().CreateModel(row));
            }

            return paymentDeductions;
        }
    }
}
