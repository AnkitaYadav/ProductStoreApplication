using ProductStore.DependencyInjection.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace ProductStore.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RegisterApiDI.Register();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
