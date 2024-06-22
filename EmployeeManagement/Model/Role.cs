using System.Data;

namespace EmployeeManagement.Model
{
    public class Role : BasicModel<Role>
    {
        public string Name { get; set; }

        public override Role CreateModel(DataRow roleRow)
        {
            return new Role
            {
                ID = (int)roleRow["ID"],
                Name = (string)roleRow["Name"]
            };
        }

        public override object[] GetElementProperties()
        {
            return [null, Name];
        }

        public override void UpdateDbModel(DataRow dataRow)
        {
            dataRow["Name"] = Name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
