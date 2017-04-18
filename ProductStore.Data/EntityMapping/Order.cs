//namespace ProductStore.Data
//{
//    using System;
//    using System.Collections.Generic;
//    using System.ComponentModel.DataAnnotations;
//    using System.ComponentModel.DataAnnotations.Schema;
//    using System.Data.Entity.Spatial;

//    [Table("Order")]
//    public partial class Order
//    {
//        public int Id { get; set; }

//        public int CustomerId { get; set; }

//        public int ProductId { get; set; }

//        public int? Quantity { get; set; }

//        [Column(TypeName = "money")]
//        public decimal? Price { get; set; }

//        public virtual Customer Customer { get; set; }

//        public virtual Product Product { get; set; }
//    }
//}
