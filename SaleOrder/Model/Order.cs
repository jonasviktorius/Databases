namespace SaleOrder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            Order_Details = new HashSet<Order_Details>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OrderDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ShipDate { get; set; }

        public int? CustomerID { get; set; }

        public int? EmployeeID { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Details> Order_Details { get; set; }
    }
}
