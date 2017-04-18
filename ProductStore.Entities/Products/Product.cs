using ProductStore.Entities.Carts;
using ProductStore.Entities.Orders;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductStore.Entities.Products
{
    [Table("Product")]
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Category { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
