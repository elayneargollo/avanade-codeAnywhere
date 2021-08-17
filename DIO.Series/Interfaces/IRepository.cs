using System.Collections.Generic;

namespace DIO.Series
{
    public interface IRepository<T>
    {
        List<T> List();
        T GetById(int id);
        void Insert(T entity);
        void Delet(int id);
        int NextId();
        void Update(int id, T entidade);
    }
}