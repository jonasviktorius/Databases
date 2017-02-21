namespace SaleOrder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Orders = new HashSet<Order>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeID { get; set; }

        [StringLength(25)]
        public string EmpFirstName { get; set; }

        [StringLength(25)]
        public string EmpLastName { get; set; }

        [StringLength(50)]
        public string EmpStreetAddress { get; set; }

        [StringLength(30)]
        public string EmpCity { get; set; }

        [StringLength(2)]
        public string EmpState { get; set; }

        [StringLength(10)]
        public string EmpZipCode { get; set; }

        public short? EmpAreaCode { get; set; }

        [StringLength(8)]
        public string EmpPhoneNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EmpBirthDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
