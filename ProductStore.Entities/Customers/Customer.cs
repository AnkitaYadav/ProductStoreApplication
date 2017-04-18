using ProductStore.Entities.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Entities.Customers
{
    [Table("Customer")]
    public class Customer
    {

        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; }

        [Required]
        [StringLength(250)]
        public string FirstName { get; set; }

        [StringLength(250)]
        public string LastName { get; set; }

        [StringLength(1000)]
        public string Address { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [StringLength(100)]
        public string State { get; set; }

        [StringLength(150)]
        public string Country { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        [Column(TypeName = "money")]
        public decimal? Total { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
