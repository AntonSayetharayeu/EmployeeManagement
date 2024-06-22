using System.Data;

namespace EmployeeManagement.Model
{
    public abstract class BasicModel<T> where T : BasicModel<T>, new()
    {
        public int ID { get; set; }

        public abstract T CreateModel(DataRow dataRow);

        public abstract object[] GetElementProperties();

        public abstract void UpdateDbModel(DataRow dataRow);

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }

            if (obj is T other)
            {
                return ID == other.ID;
            }

            return false;
        }
    }
}
