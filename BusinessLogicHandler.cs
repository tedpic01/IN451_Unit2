using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IN451_Unit2_Ted_Picou
{

    //This class acts as the intermediary between the user interface and the database handler.
    internal class BusinessLogicHandler
    {
        public string ServerName { get; set; } = null;
        public string DatabaseName { get; set; } = null;
        public string Username { get; set; } = null;
        public string Password { get; set; } = null;
        public static string CurrentTable { get; set; } = null;

        public List<string> RetrieveNames()
        {
            return DatabaseHandler.GetContactNames();
        }

        public int RetrieveCount()
        {
            return DatabaseHandler.GetContactCount();
        }

        public List<string> RetrieveStoredProcedureNames()
        {
            return DatabaseHandler.GetStoredProcedureNames();
        }

        public int RetrieveStoredProcedureCount()
        {
            return DatabaseHandler.GetStoredProcedureCount();
        }

        public void SetConnectionString()
        {
            DatabaseHandler.ConnectionStringConstructor(ServerName, DatabaseName, Username, Password);
        }

        public bool VerifyLogin()
        {
            return DatabaseHandler.TestSQLLogin(ServerName, DatabaseName, Username, Password);
        }

        public List<string> RetrieveEmployeeNames()
        {
            return DatabaseHandler.GetEmployeeNames();
        }

        public int RetrieveOrderCount()
        {
            return DatabaseHandler.GetOrderCount();
        }
    }
}
