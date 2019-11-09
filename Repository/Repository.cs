using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Objects;

namespace Mindfulness_Hub_V3.Service
{
    public interface IRepository<T> where T : class
    {
        T GetById(object id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Query(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Remove(T entity);
    }

    public abstract class Repository<T> : IRepository<T>
        where T : class
    {
        protected IObjectSet<T> _objectSet;

        protected Repository(ObjectContext context)
        {
            _objectSet = context.CreateObjectSet<T>();
        }

        public abstract T GetById(object id);

        public IEnumerable<T> GetAll()
        {
            return _objectSet;
        }

        public IEnumerable<T> Query(Expression<Func<T, bool>> filter)
        {
            return _objectSet.Where(filter);
        }

        public void Add(T entity)
        {
            _objectSet.AddObject(entity);
        }

        public void Remove(T entity)
        {
            _objectSet.DeleteObject(entity);
        }
    }
}
