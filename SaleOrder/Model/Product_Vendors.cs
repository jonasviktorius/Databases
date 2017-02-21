namespace SaleOrder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product_Vendors
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VendorID { get; set; }

        [Column(TypeName = "money")]
        public decimal? WholesalePrice { get; set; }

        public short? DaysToDeliver { get; set; }

        public virtual Product Product { get; set; }

        public virtual Vendor Vendor { get; set; }
    }
}
