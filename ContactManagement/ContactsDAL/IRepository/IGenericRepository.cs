using System.Collections.Generic;

namespace ContactsDAL.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetByID(int id);

        int Insert(T entity);

        void Update(T entity);

        T Delete(T entity);
    }
}
