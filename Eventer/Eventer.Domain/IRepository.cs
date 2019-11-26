using System;
using System.Collections.Generic;
using System.Text;

namespace Eventer.Domain
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get();
        T Add(T entity);
        T Update(T entity);
        bool Delete(int entity);
    }
}
