using System.Collections.Generic;

namespace RepositoryDemo.Repository
{
    public interface IRepository<TEnt, in TPk> where TEnt : class
    {
        IEnumerable<TEnt> GetAll();
        TEnt Get(TPk id);
        TEnt Add(TEnt item);
        void Remove(TPk id);
        bool Update(TEnt item);
    }
}
