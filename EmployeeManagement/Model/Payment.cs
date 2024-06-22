using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Model
{
    public class Payment : BasicModel<Payment>
    {
        public DateTime DateOfCreation { get; set; }
        public DateTime DateOfLatestModification { get; set; }
        public DateTime? DateOfClosing { get; set; }
        public decimal DefaultValue { get; set; }
        public decimal? TaxValue { get; set; }
        public decimal? BonusValue { get; set; }
        public decimal FinalValue { get; set; }
        public int Status { get; set; }

        //Navigation
        public int EmployeeID { get; set; }

        public override Payment CreateModel(DataRow dataRow)
        {
            return new Payment
            {
                ID = (int)dataRow["ID"],
                DateOfCreation = (DateTime)dataRow["DateOfCreation"],
                DateOfLatestModification = (DateTime)dataRow["DateOfLatestModification"],
                DateOfClosing = (dataRow["DateOfClosing"].GetType() == typeof(DBNull) ? null : (DateTime)dataRow["DateOfClosing"]),
                DefaultValue = (decimal)dataRow["DefaultValue"],
                TaxValue = (dataRow["TaxValue"].GetType() == typeof(DBNull) ? null : (decimal)dataRow["TaxValue"]),
                BonusValue = (dataRow["BonusValue"].GetType() == typeof(DBNull) ? null : (decimal)dataRow["BonusValue"]),
                FinalValue = (decimal)dataRow["FinalValue"],
                Status = (int)dataRow["Status"],
                EmployeeID = (int)dataRow["EmployeeID"]
            };
        }

        public override object[] GetElementProperties()
        {
            return [null, DateOfCreation, DateOfLatestModification, DefaultValue, TaxValue, BonusValue, FinalValue, Status, EmployeeID, DateOfClosing];
        }

        public override void UpdateDbModel(DataRow dataRow)
        {
            dataRow["DateOfCreation"] = DateOfCreation;
            dataRow["DateOfLatestModification"] = DateOfLatestModification;
            dataRow["DateOfClosing"] = DateOfClosing == null ? DBNull.Value : DateOfClosing;
            dataRow["DefaultValue"] = DefaultValue;
            dataRow["TaxValue"] = TaxValue == null ? DBNull.Value : TaxValue;
            dataRow["BonusValue"] = BonusValue == null ? DBNull.Value : BonusValue;
            dataRow["FinalValue"] = FinalValue;
            dataRow["Status"] = Status;
            dataRow["EmployeeID"] = EmployeeID;
        }
    }
}
