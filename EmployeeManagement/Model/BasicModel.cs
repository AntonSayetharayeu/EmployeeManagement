using System.Data;

namespace EmployeeManagement.Model
{
    public abstract class BasicModel<T>
    {
        public int ID { get; set; }

        public abstract T CreateModel(DataRow dataRow);

        public abstract object[] GetElementProperties();

        public abstract void UpdateDbModel(DataRow dataRow);
    }
}
