using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IN451_Unit2_Ted_Picou
{
    public partial class TableViewer : Form
    {
        public TableViewer()
        {
            InitializeComponent();
            ResultsBox.Text = string.Empty;
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLogicHandler businessLogicHandler = new BusinessLogicHandler();
                List<string> contactNames = businessLogicHandler.RetrieveNames();
                ResultsBox.Text = string.Join(Environment.NewLine, contactNames);
                int contactCount = businessLogicHandler.RetrieveCount();
                ResultsBox.AppendText(Environment.NewLine + $"Total Contacts: {contactCount}");
                ErrorLabel.Visible = false;
            }
            catch (Exception)
            {
                ErrorLabel.Text = $"Error: Access Denied";
                ErrorLabel.Visible = true;
            }
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLogicHandler businessLogicHandler = new BusinessLogicHandler();
                List<string> employeeNames = businessLogicHandler.RetrieveEmployeeNames();
                ResultsBox.Text = string.Join(Environment.NewLine, employeeNames);
                int employeeCount = employeeNames.Count;
                ResultsBox.AppendText(Environment.NewLine + $"Total Employees: {employeeCount}");
                ErrorLabel.Visible = false;

            }
            catch (Exception)
            {
                ErrorLabel.Text = $"Error: Access Denied";
                ErrorLabel.Visible = true;
            }
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLogicHandler businessLogicHandler = new BusinessLogicHandler();
                int orderCount = businessLogicHandler.RetrieveOrderCount();
                ResultsBox.Text = $"Total Orders: {orderCount}";
                ErrorLabel.Visible = false;

            }
            catch (Exception)
            {
                ErrorLabel.Text = $"Error: Access Denied";
                ErrorLabel.Visible = true;
            }
        }

        private void ResultsBox_TextChanged(object sender, EventArgs e)
        {
            ResultsBox.SelectionStart = ResultsBox.Text.Length;
            ResultsBox.ScrollToCaret();
        }
    }
}
