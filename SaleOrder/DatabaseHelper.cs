using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SaleOrder
{
    public class DatabaseHelper
    {

        private string connectionString =
            @"Data Source=JONAS;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Customer> GetAllCustomers()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    List<Customer> customerList = new List<Customer>();
                    connect.Open();

                    string sql = "Select * from Customer";
                    //SqlCommand cmd = new SqlCommand(sql, connect);
                    //cmd.ExecuteNonQuery();
                    return customerList;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Something went wrong with getting all customers" + ex);
                    throw;
                }
            }
        }
    }
}
