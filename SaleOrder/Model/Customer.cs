namespace SaleOrder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [StringLength(25)]
        public string CustFirstName { get; set; }

        [StringLength(25)]
        public string CustLastName { get; set; }

        [StringLength(50)]
        public string CustStreetAddress { get; set; }

        [StringLength(30)]
        public string CustCity { get; set; }

        [StringLength(2)]
        public string CustState { get; set; }

        [StringLength(10)]
        public string CustZipCode { get; set; }

        public short? CustAreaCode { get; set; }

        [StringLength(8)]
        public string CustPhoneNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
