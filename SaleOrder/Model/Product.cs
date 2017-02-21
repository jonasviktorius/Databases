namespace SaleOrder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Order_Details = new HashSet<Order_Details>();
            Product_Vendors = new HashSet<Product_Vendors>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductNumber { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        [StringLength(100)]
        public string ProductDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? RetailPrice { get; set; }

        public short? QuantityOnHand { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Details> Order_Details { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Vendors> Product_Vendors { get; set; }
    }
}
