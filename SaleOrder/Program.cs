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
            int userInput = 0;
            do
            {
                userInput = DisplayMenu();
                if (userInput == 1)
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
                }
                else if (userInput == 2)
                {
                    using (SalesOrderEntities soe = new SalesOrderEntities())
                    {
                        var empInfo = from inf in soe.CH04_Employee_Information
                            select inf;
                        foreach (var inf in empInfo)
                        {
                            Console.WriteLine("Employee ID: " + inf.EmployeeID + "\r\n" + "Name: " + inf.EmpFirstName +
                                              " " + inf.EmpLastName + "\r\n");
                        }
                    }
                }
                else if (userInput == 3)
                {
                    // All products any order dates
                    using (SalesOrderEntities soe = new SalesOrderEntities())
                    {
                        var allProd = from prod in soe.CH09_All_Products_Any_Order_Dates
                            select prod;
                        foreach (var prod in allProd)
                        {
                            Console.WriteLine("Product Number: " +
                                              prod.ProductNumber + "\r\n" + "Product name: " + prod.ProductName + "\r\n");
                        }
                    }
                }

            } while (userInput != 4)
            ;
            Console.ReadLine();
        }

        static public int DisplayMenu()
        {
            Console.WriteLine("Sale/order bicycles");
            Console.WriteLine();
            Console.WriteLine("1.  Get all customers ");
            Console.WriteLine("2.  Get all employees");
            Console.WriteLine("3.  Get all products");
            Console.WriteLine("4.  Exit ");
            var result = Console.ReadLine();
            return Convert.ToInt32(result);
        }
    }
}
