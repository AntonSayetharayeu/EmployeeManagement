using EmployeeManagement.Model;
using Microsoft.Data.SqlClient;

namespace EmployeeManagement.Repositories
{
    public class EmployeeRepository: BasicRepository<Employee>
    {
        public Employee GetEmployeeByLogin(string login)
        {
            SqlCommand cmd = new SqlCommand($"SELECT * FROM {TablesMap[typeof(Employee)]} WHERE Email = @login");
            SqlParameter loginParameter = new SqlParameter("@login", login);
            cmd.Parameters.Add(loginParameter);

            PrepareData(cmd);

            return new Employee().CreateModel(Data.Tables[0].Rows[0]);
        }
    }
}
