namespace SaleOrder
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Entity : DbContext
    {
        public Entity()
            : base("name=Entity")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Order_Details> Order_Details { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product_Vendors> Product_Vendors { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<ztblMonth> ztblMonths { get; set; }
        public virtual DbSet<ztblPriceRanx> ztblPriceRanges { get; set; }
        public virtual DbSet<ztblPurchaseCoupon> ztblPurchaseCoupons { get; set; }
        public virtual DbSet<ztblSeqNumber> ztblSeqNumbers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order_Details>()
                .Property(e => e.QuotedPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.Order_Details)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product_Vendors>()
                .Property(e => e.WholesalePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.RetailPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Order_Details)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Product_Vendors)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.Product_Vendors)
                .WithRequired(e => e.Vendor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ztblPriceRanx>()
                .Property(e => e.LowPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ztblPriceRanx>()
                .Property(e => e.HighPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ztblPurchaseCoupon>()
                .Property(e => e.LowSpend)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ztblPurchaseCoupon>()
                .Property(e => e.HighSpend)
                .HasPrecision(19, 4);
        }
    }
}
