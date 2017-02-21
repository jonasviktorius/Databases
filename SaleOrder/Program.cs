using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SaleOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Entity())
            {
                //Get all customers id and name

                var query = from c in db.Customers
                            orderby c.CustFirstName
                            select c;

                foreach (var custs in query)
                {
                    Console.WriteLine("Customer ID: " + custs.CustomerID + "\r\n" + " Name: " + custs.CustFirstName + " " + custs.CustLastName + "\r\n");
                }
            }
            // Get all employees id and name
            using (SalesOrderEntities soe = new SalesOrderEntities())
            {
                var empInfo = from inf in soe.CH04_Employee_Information
                    select inf;
                foreach (var inf in empInfo)
                {
                    Console.WriteLine("Employee ID: " + inf.EmployeeID+ "\r\n" + "Name: " + inf.EmpFirstName + " " + inf.EmpLastName + "\r\n");
                }
                // All products any order dates
                var allProd = from prod in soe.CH09_All_Products_Any_Order_Dates
                    select prod;
                foreach (var prod in allProd)
                {
                    Console.WriteLine("Order date: " + prod.OrderDate + "\r\n" + "Product Number: " + prod.ProductNumber + "\r\n" + "Product name: " + prod.ProductName + "\r\n");
                }
            }
            Console.ReadLine();
        }
    }
}
