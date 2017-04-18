using ProductStore.Entities.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Entities.Carts
{
   
   public class Cart
    {
        [Key]
        public int RecordId { get; set; }

        public int CartId { get; set; }

        public int ProductId { get; set; }

        public int? Quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }

        public virtual Product Product { get; set; }
    }
}
