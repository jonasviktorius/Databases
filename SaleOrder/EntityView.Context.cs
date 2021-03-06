﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaleOrder
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SalesOrderEntities : DbContext
    {
        public SalesOrderEntities()
            : base("name=SalesOrderEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CH04_Employee_Information> CH04_Employee_Information { get; set; }
        public virtual DbSet<CH05_Adjusted_Wholesale_Prices> CH05_Adjusted_Wholesale_Prices { get; set; }
        public virtual DbSet<CH05_Orders_By_Customer_And_Date> CH05_Orders_By_Customer_And_Date { get; set; }
        public virtual DbSet<CH05_Shipping_Days_Analysis> CH05_Shipping_Days_Analysis { get; set; }
        public virtual DbSet<CH06_Orders_for_Customer_1001> CH06_Orders_for_Customer_1001 { get; set; }
        public virtual DbSet<CH08_Orders_With_Products> CH08_Orders_With_Products { get; set; }
        public virtual DbSet<CH09_All_Products_Any_Order_Dates> CH09_All_Products_Any_Order_Dates { get; set; }
        public virtual DbSet<CH09_Customers_No_Helmets> CH09_Customers_No_Helmets { get; set; }
        public virtual DbSet<CH09_Customers_No_Rep_Same_Zip> CH09_Customers_No_Rep_Same_Zip { get; set; }
        public virtual DbSet<CH09_Products_Never_Ordered> CH09_Products_Never_Ordered { get; set; }
        public virtual DbSet<CH10_Customer_Helmets_Vendor_Helmets> CH10_Customer_Helmets_Vendor_Helmets { get; set; }
        public virtual DbSet<CH10_Customer_Order_Bikes_UNION_Customer_Order_Helmets> CH10_Customer_Order_Bikes_UNION_Customer_Order_Helmets { get; set; }
        public virtual DbSet<CH11_Customers_Clothing_OR_Accessories> CH11_Customers_Clothing_OR_Accessories { get; set; }
        public virtual DbSet<CH11_Customers_Clothing_OR_Accessories_EXISTS> CH11_Customers_Clothing_OR_Accessories_EXISTS { get; set; }
        public virtual DbSet<CH11_Customers_Clothing_OR_Accessories_IN> CH11_Customers_Clothing_OR_Accessories_IN { get; set; }
        public virtual DbSet<CH11_Customers_Ordered_Bikes_EXISTS> CH11_Customers_Ordered_Bikes_EXISTS { get; set; }
        public virtual DbSet<CH11_Customers_Ordered_Bikes_IN> CH11_Customers_Ordered_Bikes_IN { get; set; }
        public virtual DbSet<CH11_Customers_Ordered_Bikes_JOIN> CH11_Customers_Ordered_Bikes_JOIN { get; set; }
        public virtual DbSet<CH11_Products_Last_Date> CH11_Products_Last_Date { get; set; }
        public virtual DbSet<CH12_Quoted_Price_vs_Average_Retail_Price> CH12_Quoted_Price_vs_Average_Retail_Price { get; set; }
        public virtual DbSet<CH18_Cust_Bikes_And_Helmets_EXISTS> CH18_Cust_Bikes_And_Helmets_EXISTS { get; set; }
        public virtual DbSet<CH18_Cust_Bikes_No_Helmets_EXISTS> CH18_Cust_Bikes_No_Helmets_EXISTS { get; set; }
        public virtual DbSet<CH18_Customer_Bikes_No_Helmets> CH18_Customer_Bikes_No_Helmets { get; set; }
        public virtual DbSet<CH18_Customers_Bikes_And_Helmets_Same_Order> CH18_Customers_Bikes_And_Helmets_Same_Order { get; set; }
        public virtual DbSet<CH18_Customers_No_Orders_JOIN> CH18_Customers_No_Orders_JOIN { get; set; }
        public virtual DbSet<CH18_Customers_No_Orders_NOT_IN> CH18_Customers_No_Orders_NOT_IN { get; set; }
        public virtual DbSet<CH18_Customers_Not_Bikes_Or_Tires_NOTIN_1> CH18_Customers_Not_Bikes_Or_Tires_NOTIN_1 { get; set; }
        public virtual DbSet<CH18_Customers_Not_Bikes_Or_Tires_NOTIN_2> CH18_Customers_Not_Bikes_Or_Tires_NOTIN_2 { get; set; }
        public virtual DbSet<CH18_Orders_Bikes_No_Helmet_EXISTS> CH18_Orders_Bikes_No_Helmet_EXISTS { get; set; }
        public virtual DbSet<CH18_Vendors_Accessories_CarRacks_Clothing> CH18_Vendors_Accessories_CarRacks_Clothing { get; set; }
        public virtual DbSet<CH19_Customers_Ordered_FirstWeek_Dec2012> CH19_Customers_Ordered_FirstWeek_Dec2012 { get; set; }
        public virtual DbSet<CH19_Customers_State_Names> CH19_Customers_State_Names { get; set; }
        public virtual DbSet<CH19_Employee_Age_Feb152014> CH19_Employee_Age_Feb152014 { get; set; }
        public virtual DbSet<CH19_Products_And_SalesQuality> CH19_Products_And_SalesQuality { get; set; }
        public virtual DbSet<CH19_Products_Ordered_Dec_2012> CH19_Products_Ordered_Dec_2012 { get; set; }
        public virtual DbSet<CH20_Customer_All_Products_PurchasedStatus> CH20_Customer_All_Products_PurchasedStatus { get; set; }
        public virtual DbSet<CH20_Customer_Catalog> CH20_Customer_Catalog { get; set; }
        public virtual DbSet<CH20_Employees_Same_State_Customers> CH20_Employees_Same_State_Customers { get; set; }
        public virtual DbSet<CH20_Product_Price_Ranges> CH20_Product_Price_Ranges { get; set; }
        public virtual DbSet<CH20_Product_Sales_All_Months_2012_2013> CH20_Product_Sales_All_Months_2012_2013 { get; set; }
        public virtual DbSet<CH20_Product_Sales_ByMonth> CH20_Product_Sales_ByMonth { get; set; }
        public virtual DbSet<CH20_Product_Stock_Labels> CH20_Product_Stock_Labels { get; set; }
    }
}
