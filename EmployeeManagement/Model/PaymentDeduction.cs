using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Model
{
    public class PaymentDeduction : BasicModel<PaymentDeduction>
    { 
        //Navigation
        public int PaymentID { get; set; }
        public int DeductionID { get; set; }

        public override PaymentDeduction CreateModel(DataRow dataRow)
        {
            return new PaymentDeduction
            {
                ID = (int)dataRow["ID"],
                PaymentID = (int)dataRow["PaymentID"],
                DeductionID = (int)dataRow["DeductionID"]
            };
        }

        public override object[] GetElementProperties()
        {
            return [null, PaymentID, DeductionID];
        }

        public override void UpdateDbModel(DataRow dataRow)
        {
            dataRow["PaymentID"] = PaymentID;
            dataRow["DeductionID"] = DeductionID;
        }
    }
}
