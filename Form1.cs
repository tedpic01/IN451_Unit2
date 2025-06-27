using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IN451_Unit2_Ted_Picou
{
    public partial class Form1 : Form
    {

        //Clears the ResultsBox and sets the DatabaseLocation text box to display the current database connection string.
        public Form1()
        {
            InitializeComponent();
            ResultsBox.Text = string.Empty;
            string connectionString = DatabaseHandler.GetConnectionString();
            DatabaseLocation.Text = connectionString;
        }

        //This allows the user to chnage the database connection string from the text box.
        private void DatabaseLocation_TextChanged(object sender, EventArgs e)
        {
            DatabaseHandler.DatabaseLocation = DatabaseLocation.Text;
        }

        /*This button activates the logic for the contact names and count by using the C# methods.
         * it starts up the BusinessLogicHandler class and places the results in the ResultsBox.*/
        private void button1_Click(object sender, EventArgs e)
        {
            BusinessLogicHandler businessLogicHandler = new BusinessLogicHandler();
            List<string> contactNames = businessLogicHandler.RetrieveNames();
            ResultsBox.Text = string.Join(Environment.NewLine, contactNames);
            int contactCount = businessLogicHandler.RetrieveCount();
            ResultsBox.AppendText(Environment.NewLine + $"Total Contacts: {contactCount}");
        }

        //This section scrolls the ResultsBox to the bottom when text is added or changed.
        private void ResultsBox_TextChanged(object sender, EventArgs e)
        {
            ResultsBox.SelectionStart = ResultsBox.Text.Length;
        }

        //This button activates the logic for retrieving the LAST names and count using stored procedures in the database.
        private void StartButton2_MouseClick(object sender, MouseEventArgs e)
        {
            BusinessLogicHandler businessLogicHandler = new BusinessLogicHandler();
            List<string> storedProcedureNames = businessLogicHandler.RetrieveStoredProcedureNames();
            ResultsBox.Text = string.Join(Environment.NewLine, storedProcedureNames);
            int storedProcedureCount = businessLogicHandler.RetrieveStoredProcedureCount();
            ResultsBox.AppendText(Environment.NewLine + $"Total Contacts: {storedProcedureCount}");
        }
    }
}
