namespace SaleOrder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order_Details
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? QuotedPrice { get; set; }

        public short? QuantityOrdered { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
