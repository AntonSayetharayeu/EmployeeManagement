using EmployeeManagement.Model;
using EmployeeManagement.Repositories;

namespace EmployeeManagement.Services
{
    public class BasicService<T> where T : BasicModel<T>, new()
    {
        private BasicRepository<T> repository = new BasicRepository<T>();

        public List<T> GetElements()
        {
            return repository.GetElements();
        }

        public T GetElementById(int id)
        {
            return repository.GetElementById(id);
        }

        public void AddElement(T element)
        {
            repository.AddElement(element);
        }

        public void UpdateElement(T element)
        {
            repository.UpdateElement(element);
        }

        public void DeleteElement(int id)
        {
            repository.DeleteElement(id);
        }
    }
}
