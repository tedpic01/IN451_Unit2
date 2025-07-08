namespace IN451_Unit2_Ted_Picou
{
    partial class TableViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResultsBox = new System.Windows.Forms.RichTextBox();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultsBox
            // 
            this.ResultsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultsBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ResultsBox.Location = new System.Drawing.Point(16, 12);
            this.ResultsBox.Name = "ResultsBox";
            this.ResultsBox.ReadOnly = true;
            this.ResultsBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ResultsBox.Size = new System.Drawing.Size(324, 214);
            this.ResultsBox.TabIndex = 0;
            this.ResultsBox.Text = "";
            this.ResultsBox.TextChanged += new System.EventHandler(this.ResultsBox_TextChanged);
            // 
            // CustomersButton
            // 
            this.CustomersButton.Location = new System.Drawing.Point(16, 241);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(217, 23);
            this.CustomersButton.TabIndex = 1;
            this.CustomersButton.Text = "Customers";
            this.CustomersButton.UseVisualStyleBackColor = true;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.Location = new System.Drawing.Point(16, 282);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(217, 23);
            this.EmployeeButton.TabIndex = 2;
            this.EmployeeButton.Text = "Employees";
            this.EmployeeButton.UseVisualStyleBackColor = true;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // OrdersButton
            // 
            this.OrdersButton.Location = new System.Drawing.Point(16, 320);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(217, 23);
            this.OrdersButton.TabIndex = 3;
            this.OrdersButton.Text = "Orders";
            this.OrdersButton.UseVisualStyleBackColor = true;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(13, 358);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(162, 13);
            this.ErrorLabel.TabIndex = 4;
            this.ErrorLabel.Text = "Error Message Here *Not Visible*";
            this.ErrorLabel.Visible = false;
            // 
            // TableViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 450);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.OrdersButton);
            this.Controls.Add(this.EmployeeButton);
            this.Controls.Add(this.CustomersButton);
            this.Controls.Add(this.ResultsBox);
            this.MinimumSize = new System.Drawing.Size(372, 489);
            this.Name = "TableViewer";
            this.Text = "TableViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ResultsBox;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Button EmployeeButton;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Label ErrorLabel;
    }
}