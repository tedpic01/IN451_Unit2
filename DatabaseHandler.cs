using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IN451_Unit2_Ted_Picou
{

    //This class handles operations involving the database. The connection string is located here.
    internal class DatabaseHandler
    {
        public static string DatabaseLocation { get; set; } = "Data Source=ZONA\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
        public static string GetConnectionString()
        {
            return $"{DatabaseLocation}";
        }


        public static SqlConnection OpenSQLConnection()
        {
            var connection = new SqlConnection(GetConnectionString());
            connection.Open();
            return connection;
        }

        //This method uses the stored query to retrieve the contact names as a list of strings.
        public static List<string> GetContactNames()
        {
            List<string> results = new List<string>();
            string query = "SELECT [ContactName] FROM [Northwind].[dbo].[Customers]";
            using (var connection = OpenSQLConnection())
            using (var command = new SqlCommand(query, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    results.Add(reader["ContactName"].ToString());
                }
            }
            return results;
        }

        //This method uses the stored query to retrieve the contact count as an integer.
        public static int GetContactCount()
        {
            int count = 0;
            string query = "SELECT COUNT(*) FROM [Northwind].[dbo].[Customers]";
            using (var connection = OpenSQLConnection())
            using (var command = new SqlCommand(query, connection))
            {
                count = (int)command.ExecuteScalar();
            }
            return count;
        }

        //This method executes a stored procedure to retrieve last names from the database, returning a list of strings. 
        public static List<string> GetStoredProcedureNames()
        {
            List<string> results = new List<string>();
            string query = "EXEC Northwind.dbo.GetContactLastNames";
            using (var connection = OpenSQLConnection())
            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(reader["LastNames"].ToString());
                    }
                }
                return results;
            }
        }

        //This method executes a stored procedure to retrieve the count of contacts, returning an integer.
        public static int GetStoredProcedureCount()
        {
            int count = 0;
            string query = "EXEC Northwind.dbo.GetContactCount";
            using (var connection = OpenSQLConnection())
            using (var command = new SqlCommand(query, connection))
            {
                count = (int)command.ExecuteScalar();
            }
            return count;
        }

    }
}