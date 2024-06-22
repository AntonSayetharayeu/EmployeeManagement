using System.Data;

namespace EmployeeManagement.Model
{
    public class Employee : BasicModel<Employee>
    { 
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public bool IsDismissed { get; set; }
        public decimal DefaultSalary { get; set; }

        //Navigation
        public int RoleID { get; set; }

        public override Employee CreateModel(DataRow dataRow)
        {
            return new Employee
            {
                ID = (int)dataRow["ID"],
                Name = (string)dataRow["Name"],
                Surname = (string)dataRow["Surname"],
                Age = (int)dataRow["Age"],
                Email = (string)dataRow["Email"],
                IsDismissed = (bool)dataRow["IsDismissed"],
                DefaultSalary = (decimal)dataRow["DefaultSalary"],
                RoleID = (int)dataRow["RoleID"]
            };
        }

        public override object[] GetElementProperties()
        {
            return [null, Name, Surname, Age, Email, IsDismissed, RoleID, DefaultSalary];
        }

        public override void UpdateDbModel(DataRow dataRow)
        {
            dataRow["Name"] = Name;
            dataRow["Surname"] = Surname;
            dataRow["Age"] = Age;
            dataRow["Email"] = Email;
            dataRow["IsDismissed"] = IsDismissed;
            dataRow["DefaultSalary"] = DefaultSalary;
            dataRow["RoleID"] = RoleID;
        }

        public override string ToString()
        {
            return $"{Name} {Surname} {DefaultSalary} $";
        }
    }
}
