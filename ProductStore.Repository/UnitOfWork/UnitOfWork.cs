using ProductStore.Interface.Repository;
using ProductStore.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
namespace ProductStore.Repository.UnitOfWork
{
   public  class UnitOfWork
    {
        private  DbContext dbcontext;
        public UnitOfWork(DbContext context)
        {
            dbcontext = context;
        }

        public Dictionary<Type, object> Repositories = new Dictionary<Type, object>();
        public IRepository<T> Repository<T>() where T : class
        {
            if (Repositories.Keys.Contains(typeof(T)) == true)
            {
                return Repositories[typeof(T)] as IRepository<T>;
            }
            var repository = new Repository<T>(dbcontext);
            Repositories.Add(typeof(T),repository);
            return repository;
        }
        public int Save()
        {
           return dbcontext.SaveChanges();
        }
        public void Dispose()
        {
            if (dbcontext != null)
            {
                dbcontext.Dispose();
                dbcontext = null;
               
            }
            GC.SuppressFinalize(this);
        }
      

    }
}
