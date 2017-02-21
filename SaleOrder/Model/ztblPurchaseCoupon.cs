namespace SaleOrder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ztblPurchaseCoupon
    {
        [Key]
        [Column(TypeName = "money")]
        public decimal LowSpend { get; set; }

        [Column(TypeName = "money")]
        public decimal? HighSpend { get; set; }

        public short? NumCoupons { get; set; }
    }
}
