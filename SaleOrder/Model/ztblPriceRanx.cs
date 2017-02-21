namespace SaleOrder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ztblPriceRanx
    {
        [Key]
        [StringLength(20)]
        public string PriceCategory { get; set; }

        [Column(TypeName = "money")]
        public decimal? LowPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? HighPrice { get; set; }
    }
}
