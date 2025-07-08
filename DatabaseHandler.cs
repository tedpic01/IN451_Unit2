using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IN451_Unit2_Ted_Picou
{

    //This class handles operations involving the database. The connection string is located here.
    internal class DatabaseHandler
    {
        public static string DatabaseLocation { get; set; } = "";
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

        //This holds the name of the database being accessed, so that queries can be run on more than Northwind.
        public static string CurrentDatabase { get; set; } = null;

        public static void ConnectionStringConstructor(string ServerName, string DatabaseName, string Username, string Password)
        {
            if (string.IsNullOrEmpty(ServerName) || string.IsNullOrEmpty(DatabaseName) || string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                throw new ArgumentException("Please verify login information.");
            }
            else
            {
                DatabaseLocation = $"Persist Security Info=False;User ID={Username};Password={Password};Initial Catalog={DatabaseName};Data Source= {ServerName};MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=True";
            }
        }

        /*This method tests the login information provided by the user.*/
        public static bool TestSQLLogin(string ServerName, string DatabaseName, string Username, string Password)
        {
            try
            {
                ConnectionStringConstructor(ServerName, DatabaseName, Username, Password);
                using (var connection = OpenSQLConnection())
                {
                    CurrentDatabase = DatabaseName;
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        //This method uses the stored query to retrieve the contact names as a list of strings.
        public static List<string> GetContactNames()
        {
            List<string> results = new List<string>();
            string query = $"SELECT [ContactName] FROM [{CurrentDatabase}].[dbo].[Customers]";
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
            string query = $"SELECT COUNT(*) FROM [{CurrentDatabase}].[dbo].[Customers]";
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

        //Method to retrieve the names of employees from the database.
        public static List<string> GetEmployeeNames()
        {
            List<string> results = new List<string>();
            string query = $"SELECT CONCAT(FirstName, ' ', LastName) AS Names FROM [{CurrentDatabase}].[dbo].[Employees]";
            using (var connection = OpenSQLConnection())
            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(reader["Names"].ToString());
                        Debug.Write(query);
                    }
                    return results;
                }
            }
        }

        //Method to retrieve the count of orders from the database.
        public static int GetOrderCount()
        {
            int count = 0;
            string query = $"SELECT COUNT(*) FROM [{CurrentDatabase}].[dbo].[Orders]";
            using (var connection = OpenSQLConnection())
            using (var command = new SqlCommand(query, connection))
            {
                count = (int)command.ExecuteScalar();
            }
            return count;
        }

    }
}