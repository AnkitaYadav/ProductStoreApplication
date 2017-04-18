using ProductStore.Interface.BaseLogic;
using System.Web.Http;

namespace ProductStore.Api.Controllers
{
    public class ProductController : ApiController
    {
      private readonly  IProductLogic _productLogic;
        public ProductController(IProductLogic productLogic)
        {
            this._productLogic = productLogic;
        }
        public IHttpActionResult Get()
        {
           return Ok(_productLogic.GetAllProduct());
        }
    }
}
