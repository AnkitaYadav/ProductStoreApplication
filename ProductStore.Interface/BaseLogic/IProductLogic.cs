using ProductStore.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Interface.BaseLogic
{
  public  interface IProductLogic
    {
        IEnumerable<Product> GetAllProduct();
    }
}
