using EmployeeManagement.Model;
using EmployeeManagement.Repositories;

namespace EmployeeManagement.Services
{
    public class EmployeeService : BasicService<Employee>
    {
        private readonly EmployeeRepository employeeRepository = new();

        public bool CheckAreEmployeesWithRoleID(int roleID)
        {
            return employeeRepository.GetEmployeesByRoleID(roleID).Count > 0;
        }
    }
}
