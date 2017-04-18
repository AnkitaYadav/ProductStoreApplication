using ProductStore.Interface.BaseLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductStore.Entities.Products;
using ProductStore.Interface.UnitOfWork;

namespace ProductStore.Bll.Products
{
    public class ProductLogic : IProductLogic
    {
        private IUnitOfWork _uow;
        public ProductLogic(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public IEnumerable<Product> GetAllProduct()
        {
            var product = _uow.Repository<Product>().GetAll();
            return product;
        }
    }
}
