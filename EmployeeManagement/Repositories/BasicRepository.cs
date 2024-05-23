using EmployeeManagement.Model;
using Microsoft.Data.SqlClient;
using System.Data;

namespace EmployeeManagement.Repositories
{
    public class BasicRepository<T> : BaseRepository where T : BasicModel<T>, new()
    {
        protected readonly Dictionary<Type, string> TablesMap = new Dictionary<Type, string>();

        public BasicRepository() 
        {
            TablesMap.Add(typeof(Role), "Roles");
            TablesMap.Add(typeof(Deduction), "Deductions");
            TablesMap.Add(typeof(Employee), "Employees");
            TablesMap.Add(typeof(Payment), "Payments");
            TablesMap.Add(typeof(PaymentDeduction), "PaymentDeductions");
        }

        public List<T> GetElements()
        {
            SqlCommand sqlcommand = new SqlCommand($"SELECT * FROM {TablesMap[typeof(T)]}");
            
            PrepareData(sqlcommand);

            List<T> elements = new List<T>();

            foreach (DataRow dataRow in Data.Tables[0].Rows)
            {
                elements.Add(new T().CreateModel(dataRow));
            }

            return elements;
        }

        public T GetElementById(int id)
        {
            SqlCommand sqlcommand = new SqlCommand($"SELECT * FROM {TablesMap[typeof(T)]} WHERE ID = {id}");

            PrepareData(sqlcommand);

            DataRow dataRow = Data.Tables[0].Rows[0];
            return new T().CreateModel(dataRow);
        }

        public void AddElement(T element)
        {
            SqlCommand sqlcommand = new SqlCommand($"SELECT * FROM {TablesMap[typeof(T)]}");

            PrepareData(sqlcommand);

            Data.Tables[0].Rows.Add(element.GetElementProperties());

            UpdateData();
        }

        public void UpdateElement(T element)
        {
            SqlCommand sqlcommand = new SqlCommand($"SELECT * FROM {TablesMap[typeof(T)]} WHERE ID = {element.ID}");

            PrepareData(sqlcommand);

            element.UpdateDbModel(Data.Tables[0].Rows[0]);

            UpdateData();
        }

        public void DeleteElement(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand sqlcommand = new SqlCommand($"DELETE FROM {TablesMap[typeof(T)]} WHERE ID = {id}", connection);
                sqlcommand.ExecuteNonQuery();
            }
        }
    }
}
