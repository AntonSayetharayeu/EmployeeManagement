using EmployeeManagement.Model;
using Microsoft.Data.SqlClient;
using System.Data;

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

        public List<Employee> GetEmployeesByRoleID(int roleID) 
        {
            SqlCommand cmd = new SqlCommand($"SELECT * FROM {TablesMap[typeof(Employee)]} WHERE RoleID = @roleID");
            SqlParameter roleIDParameter = new SqlParameter("@roleID", roleID);
            cmd.Parameters.Add(roleIDParameter);

            PrepareData(cmd);

            List<Employee> employees = new List<Employee>();
            foreach (DataRow row in Data.Tables[0].Rows)
            {
                employees.Add(new Employee().CreateModel(row));
            }
            
            return employees;
        }
    }
}
