using ProductStore.Bll.Products;
using ProductStore.Data;
using ProductStore.Interface.BaseLogic;
using ProductStore.Interface.UnitOfWork;
using ProductStore.Repository.UnitOfWork;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System.Web.Http;

namespace ProductStore.DependencyInjection.Api
{
   public static class RegisterApiDI
    {
        public static void Register()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new SimpleInjector.Lifestyles.AsyncScopedLifestyle();
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<IProductLogic, ProductLogic>(Lifestyle.Scoped);
            container.Register<ProductStoreContext>(Lifestyle.Scoped);
            container.Verify();
            GlobalConfiguration.Configuration.DependencyResolver =
               new SimpleInjectorWebApiDependencyResolver(container);
           
        }
    }

}
