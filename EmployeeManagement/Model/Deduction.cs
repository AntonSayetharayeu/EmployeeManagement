﻿
using System.Data;

namespace EmployeeManagement.Model
{
    public class Deduction : BasicModel<Deduction>
    { 
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsPercentage { get; set; }
        public decimal Value { get; set; }
        public bool IsActive { get; set; }

        public override Deduction CreateModel(DataRow dataRow)
        {
            return new Deduction
            {
                ID = (int)dataRow["ID"],
                Name = (string)dataRow["Name"],
                Description = (string)dataRow["Description"],
                IsPercentage = (bool)dataRow["IsPercentage"],
                Value = (decimal)dataRow["Value"],
                IsActive = (bool)dataRow["IsActive"]
            };
        }

        public override object[] GetElementProperties()
        {
            return [null, Name, Description, IsPercentage, Value, IsActive];
        }

        public override void UpdateDbModel(DataRow dataRow)
        {
            dataRow["Name"] = Name;
            dataRow["Description"] = Description;
            dataRow["IsPercentage"] = IsPercentage;
            dataRow["Value"] = Value;
            dataRow["IsActive"] = IsActive;
        }

        public override string ToString()
        {
            return $"{Name} {Value} {(IsPercentage ? "%" : "")}";
        }
    }
}
