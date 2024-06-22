using EmployeeManagement.App;
using EmployeeManagement.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Repositories
{
    public class PaymentRepository : BasicRepository<Payment>
    {
        private BasicRepository<PaymentDeduction> paymentDeductionRepository;

        public List<Payment> GetPaymentsByEmployeeID(int employeeID)
        {
            SqlCommand cmd = new SqlCommand($"SELECT * FROM {TablesMap[typeof(Payment)]} WHERE EmployeeID = @employeeID");
            SqlParameter employeeIDParameter = new SqlParameter("@employeeID", employeeID);
            cmd.Parameters.Add(employeeIDParameter);

            PrepareData(cmd);

            List<Payment> payments = new();
            foreach (DataRow row in Data.Tables[0].Rows)
            {
                payments.Add(new Payment().CreateModel(row));
            }

            return payments;
        }

        public void AddNewPayment(Payment payment, List<Deduction> deductions)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var command = new SqlCommand(
                            @"INSERT INTO Payments (DateOfCreation, DateOfLatestModification, DefaultValue, TaxValue, BonusValue, FinalValue, Status, EmployeeID) 
                            OUTPUT INSERTED.ID 
                            VALUES (@DateOfCreation, @DateOfLatestModification, @DefaultValue, @TaxValue, @BonusValue, @FinalValue, @Status, @EmployeeID)",
                            connection, transaction);

                        command.Parameters.AddWithValue("@DateOfCreation", payment.DateOfCreation);
                        command.Parameters.AddWithValue("@DateOfLatestModification", payment.DateOfLatestModification);
                        command.Parameters.AddWithValue("@DefaultValue", payment.DefaultValue);
                        command.Parameters.AddWithValue("@TaxValue", payment.TaxValue);
                        command.Parameters.AddWithValue("@BonusValue", payment.BonusValue);
                        command.Parameters.AddWithValue("@FinalValue", payment.FinalValue);
                        command.Parameters.AddWithValue("@Status", payment.Status);
                        command.Parameters.AddWithValue("@EmployeeID", payment.EmployeeID);

                        var paymentId = (int)command.ExecuteScalar();

                        foreach (var deduction in deductions)
                        {
                            var pdCommand = new SqlCommand(
                                "INSERT INTO PaymentDeductions (PaymentID, DeductionID) VALUES (@PaymentID, @DeductionID)",
                                connection, transaction);
                            pdCommand.Parameters.AddWithValue("@PaymentID", paymentId);
                            pdCommand.Parameters.AddWithValue("@DeductionID", deduction.ID);
                            pdCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        public void UpdatePayment(Payment payment, List<Deduction> newDeductions)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var updateCommand = new SqlCommand(
                            @"UPDATE Payments
                            SET DateOfLatestModification = @DateOfLatestModification,
                                DefaultValue = @DefaultValue,
                                TaxValue = @TaxValue,
                                BonusValue = @BonusValue,
                                FinalValue = @FinalValue,
                                Status = @Status,
                                EmployeeID = @EmployeeID
                            WHERE ID = @PaymentID",
                            connection, transaction);

                        updateCommand.Parameters.AddWithValue("@DateOfLatestModification", payment.DateOfLatestModification);
                        updateCommand.Parameters.AddWithValue("@DefaultValue", payment.DefaultValue);
                        updateCommand.Parameters.AddWithValue("@TaxValue", payment.TaxValue);
                        updateCommand.Parameters.AddWithValue("@BonusValue", payment.BonusValue);
                        updateCommand.Parameters.AddWithValue("@FinalValue", payment.FinalValue);
                        updateCommand.Parameters.AddWithValue("@Status", payment.Status);
                        updateCommand.Parameters.AddWithValue("@EmployeeID", payment.EmployeeID);
                        updateCommand.Parameters.AddWithValue("@PaymentID", payment.ID);

                        updateCommand.ExecuteNonQuery();

                        var existingPaymentDeductions = new List<int>();
                        var selectCommand = new SqlCommand(
                            "SELECT DeductionID FROM PaymentDeductions WHERE PaymentID = @PaymentID",
                            connection, transaction);

                        selectCommand.Parameters.AddWithValue("@PaymentID", payment.ID);

                        using (var reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                existingPaymentDeductions.Add(reader.GetInt32(0));
                            }
                        }

                        foreach (var deductionId in existingPaymentDeductions)
                        {
                            if (!newDeductions.Any(d => d.ID == deductionId))
                            {
                                var deleteCommand = new SqlCommand(
                                    "DELETE FROM PaymentDeductions WHERE PaymentID = @PaymentID AND DeductionID = @DeductionID",
                                    connection, transaction);
                                deleteCommand.Parameters.AddWithValue("@PaymentID", payment.ID);
                                deleteCommand.Parameters.AddWithValue("@DeductionID", deductionId);
                                deleteCommand.ExecuteNonQuery();
                            }
                        }

                        foreach (var deduction in newDeductions)
                        {
                            if (!existingPaymentDeductions.Contains(deduction.ID))
                            {
                                var insertCommand = new SqlCommand(
                                    "INSERT INTO PaymentDeductions (PaymentID, DeductionID) VALUES (@PaymentID, @DeductionID)",
                                    connection, transaction);
                                insertCommand.Parameters.AddWithValue("@PaymentID", payment.ID);
                                insertCommand.Parameters.AddWithValue("@DeductionID", deduction.ID);
                                insertCommand.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
