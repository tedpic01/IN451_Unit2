using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IN451_Unit2_Ted_Picou
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void ServerNameBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DatabaseNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                var businessLogicHandler = new BusinessLogicHandler
                {
                    ServerName = ServerNameBox.Text,
                    DatabaseName = DatabaseNameBox.Text,
                    Username = UsernameBox.Text,
                    Password = PasswordBox.Text
                };

                bool isValidLogin = businessLogicHandler.VerifyLogin();
                if (!isValidLogin)
                {
                    throw new Exception("Invalid login credentials. Please try again.");
                }

                if (isValidLogin)
                {
                    businessLogicHandler.SetConnectionString();
                }

                this.Hide();
                using (var mainForm = new TableViewer())
                {
                    mainForm.ShowDialog();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                ErrorLabel.Text = $"Error: {ex.Message}";
                ErrorLabel.Visible = true;

            }
        }
    }
}
