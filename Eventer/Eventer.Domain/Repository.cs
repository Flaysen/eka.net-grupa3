using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eventer.Domain
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext  _applicationContext;

        public Repository(ApplicationDbContext toDoContext)
        {
            _applicationContext = toDoContext;
        }


        public IEnumerable<T> Get()
        {
            return _applicationContext.Set<T>().ToList();
        }

        public T Add(T entity)
        {

            _applicationContext.Set<T>().Add(entity);
            _applicationContext.SaveChanges();

            return entity;
        }

        public T Update(T entity)
        {
            _applicationContext.Set<T>().Update(entity);
            _applicationContext.SaveChanges();

            return entity;
        }

        public bool Delete(int entity)
        {
            var task = _applicationContext.Events.FirstOrDefault(x => x.Id == entity);

            if (task == null)
            {
                return false;
            }

            _applicationContext.Events.Remove(task);
            var result = _applicationContext.SaveChanges();

            return result > 0;
        }

    }
}
