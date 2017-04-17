using ProductStore.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Repository.Repository
{
    public class Repository<T>  : IRepository<T> where T: class
    {
        private DbContext context;
        private DbSet<T> dbSet;
        public Repository(DbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public virtual IQueryable<T> Get()
        {
            return dbSet;
        }
        public virtual IEnumerable<T> Get(Func<T, Boolean> predicate)
        {
            return dbSet.Where(predicate);
        }
        public virtual T Get(object id)
        {
            return dbSet.Find(id);
        }
        public virtual void Add(T entity)
        {
            dbSet.Add(entity);
        }
        public virtual void Update(T entity)
        {
            AttachEntity(entity);
            context.Entry<T>(entity).State = EntityState.Modified;
        }

        private void AttachEntity(T entity)
        {
            var isEntityAttach = context.Entry<T>(entity).State == EntityState.Detached;
            if (!isEntityAttach)
            {
                dbSet.Attach(entity);
            }
        }
        public virtual void Delete(object id)
        {
            var entity = dbSet.Find(id);
            Delete(entity);
        }
        public virtual void Delete(T entity)
        {
            AttachEntity(entity);
            dbSet.Remove(entity);
        }
        public virtual void Delete(Func<T, Boolean> predicate)
        {
            IQueryable<T> entities = dbSet.Where(predicate).AsQueryable();
            foreach (T entity in entities)
                Delete(entity);
        }
        public virtual T Find(object id)
        {
            return dbSet.Find(id);
        }
        public virtual T Find(Expression<Func<T, Boolean>> predicate)
        {
           return dbSet.FirstOrDefault(predicate);
        }
        public virtual bool Any(Expression<Func<T, Boolean>> predicate)
        {
            return dbSet.Any(predicate);
        }
        public virtual bool Contain(Expression<Func<T, Boolean>> predicate)
        {
            return dbSet.Count(predicate) > 0;
        }
    }
}
