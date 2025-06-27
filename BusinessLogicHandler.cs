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
    }
}
