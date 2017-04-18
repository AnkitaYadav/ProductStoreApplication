using ProductStore.Entities.Carts;
using ProductStore.Entities.Customers;
using ProductStore.Entities.Orders;
using ProductStore.Entities.Products;
using System.Data.Entity;

namespace ProductStore.Data
{
    public interface IProductStoreContext
    {
        DbSet< Cart> Carts { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Product> Products { get; set; }
    }
}