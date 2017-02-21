namespace SaleOrder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vendor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vendor()
        {
            Product_Vendors = new HashSet<Product_Vendors>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VendorID { get; set; }

        [StringLength(25)]
        public string VendName { get; set; }

        [StringLength(50)]
        public string VendStreetAddress { get; set; }

        [StringLength(30)]
        public string VendCity { get; set; }

        [StringLength(2)]
        public string VendState { get; set; }

        [StringLength(10)]
        public string VendZipCode { get; set; }

        [StringLength(15)]
        public string VendPhoneNumber { get; set; }

        [StringLength(15)]
        public string VendFaxNumber { get; set; }

        [Column(TypeName = "ntext")]
        public string VendWebPage { get; set; }

        [StringLength(50)]
        public string VendEMailAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Vendors> Product_Vendors { get; set; }
    }
}
