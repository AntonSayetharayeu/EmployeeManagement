using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.App
{
    public class AppConstants
    {
        #region Payment
        public const int CREATED_STATUS_NUMBER = 1;
        public const int PENDING_STATUS_NUMBER = 2;
        public const int DONE_STATUS_NUMBER = 3;
        public const int CANCELED_STATUS_NUMBER = 4;
        public const decimal MAX_TOTAL_CHANGE = 0.40m;
        #endregion

        #region Employee
        public const decimal EMPLOYEE_DEFAULT_SALARY = 4000m;
        #endregion
    }
}
