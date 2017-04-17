using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ProductStore.Interface.Repository
{
   public interface IRepository<T> where T:class
    {
        IEnumerable<T> GetAll();
        IQueryable<T> Get();
        IEnumerable<T> Get(Func<T, Boolean> predicate);
        T Get(object id);
        void Add(T entity);
        void Update(T entity);
        void Delete(object id);
        void Delete(T entity);
        void Delete(Func<T, Boolean> predicate);
        T Find(object id);
        T Find(Expression<Func<T, Boolean>> predicate);
        bool Any(Expression<Func<T, Boolean>> predicate);
        bool Contain(Expression<Func<T, Boolean>> predicate);
    }
}
