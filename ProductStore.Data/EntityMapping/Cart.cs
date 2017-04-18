//namespace ProductStore.Data
//{
//    using System;
//    using System.Collections.Generic;
//    using System.ComponentModel.DataAnnotations;
//    using System.ComponentModel.DataAnnotations.Schema;
//    using System.Data.Entity.Spatial;

//    [Table("Cart")]
//    public partial class Cart
//    {
//        [Key]
//        public int RecordId { get; set; }

//        public int CartId { get; set; }

//        public int ProductId { get; set; }

//        public int? Quantity { get; set; }

//        [Column(TypeName = "date")]
//        public DateTime? DateCreated { get; set; }

//        public virtual Product Product { get; set; }
//    }
//}
