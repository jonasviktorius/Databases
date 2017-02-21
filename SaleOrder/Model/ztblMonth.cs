namespace SaleOrder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ztblMonth
    {
        [Required]
        [StringLength(15)]
        public string MonthYear { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short YearNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short MonthNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime MonthStart { get; set; }

        [Column(TypeName = "date")]
        public DateTime MonthEnd { get; set; }

        public short January { get; set; }

        public short February { get; set; }

        public short March { get; set; }

        public short April { get; set; }

        public short May { get; set; }

        public short June { get; set; }

        public short July { get; set; }

        public short August { get; set; }

        public short September { get; set; }

        public short October { get; set; }

        public short November { get; set; }

        public short December { get; set; }
    }
}
