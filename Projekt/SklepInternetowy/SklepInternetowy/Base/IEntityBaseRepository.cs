using System.Collections.Generic;

namespace SklepInternetowy.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        IEnumerable<T> GetAll();

        T GetByID(int id);

        void Add(T entity);

        void Update(int id, T entity);

        void Delete(int id);
    }
}
