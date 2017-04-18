//namespace ProductStore.Data
//{
//    using System;
//    using System.Collections.Generic;
//    using System.ComponentModel.DataAnnotations;
//    using System.ComponentModel.DataAnnotations.Schema;
//    using System.Data.Entity.Spatial;

//    [Table("Product")]
//    public partial class Product
//    {
//        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
//        public Product()
//        {
//            Carts = new HashSet<Cart>();
//            Orders = new HashSet<Order>();
//        }

//        public int Id { get; set; }

//        [Required]
//        [StringLength(500)]
//        public string Name { get; set; }

//        [StringLength(500)]
//        public string Category { get; set; }

//        [Column(TypeName = "money")]
//        public decimal? Price { get; set; }

//        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
//        public virtual ICollection<Cart> Carts { get; set; }

//        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
//        public virtual ICollection<Order> Orders { get; set; }
//    }
//}
