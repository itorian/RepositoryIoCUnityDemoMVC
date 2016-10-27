using System.Collections.Generic;

namespace RepositoryDemo.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        T Get(string id);
        T Add(T item);
        bool Update(T item);
        bool Delete(int id);
        bool Delete(string id);
    }
}
