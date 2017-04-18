using ProductStore.Data;
using ProductStore.Interface.Repository;
using ProductStore.Interface.UnitOfWork;
using ProductStore.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
namespace ProductStore.Repository.UnitOfWork
{
    public class EF_Configuration : DbConfiguration
    {
        public EF_Configuration()
        {
            SetProviderServices(
                SqlProviderServices.ProviderInvariantName,
                SqlProviderServices.Instance);
        }
    }
    public  class UnitOfWork:IUnitOfWork
    {
        private  ProductStoreContext dbcontext;
        public UnitOfWork(ProductStoreContext context)
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
