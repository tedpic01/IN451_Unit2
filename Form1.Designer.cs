namespace IN451_Unit2_Ted_Picou
{
    partial class Form1
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
            this.ResultsBox = new System.Windows.Forms.TextBox();
            this.DatabaseLocation = new System.Windows.Forms.TextBox();
            this.LabelDatabaseLocation = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.StartButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultsBox
            // 
            this.ResultsBox.BackColor = System.Drawing.SystemColors.Window;
            this.ResultsBox.Location = new System.Drawing.Point(19, 12);
            this.ResultsBox.Multiline = true;
            this.ResultsBox.Name = "ResultsBox";
            this.ResultsBox.ReadOnly = true;
            this.ResultsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultsBox.Size = new System.Drawing.Size(439, 215);
            this.ResultsBox.TabIndex = 0;
            this.ResultsBox.TextChanged += new System.EventHandler(this.ResultsBox_TextChanged);
            // 
            // DatabaseLocation
            // 
            this.DatabaseLocation.Location = new System.Drawing.Point(19, 282);
            this.DatabaseLocation.Name = "DatabaseLocation";
            this.DatabaseLocation.Size = new System.Drawing.Size(439, 20);
            this.DatabaseLocation.TabIndex = 1;
            this.DatabaseLocation.TextChanged += new System.EventHandler(this.DatabaseLocation_TextChanged);
            // 
            // LabelDatabaseLocation
            // 
            this.LabelDatabaseLocation.AutoSize = true;
            this.LabelDatabaseLocation.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelDatabaseLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelDatabaseLocation.Location = new System.Drawing.Point(16, 255);
            this.LabelDatabaseLocation.Name = "LabelDatabaseLocation";
            this.LabelDatabaseLocation.Size = new System.Drawing.Size(91, 13);
            this.LabelDatabaseLocation.TabIndex = 2;
            this.LabelDatabaseLocation.Text = "Connection String";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(19, 328);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(241, 23);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Return Names Using C# Methods";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartButton2
            // 
            this.StartButton2.Location = new System.Drawing.Point(19, 367);
            this.StartButton2.Name = "StartButton2";
            this.StartButton2.Size = new System.Drawing.Size(241, 23);
            this.StartButton2.TabIndex = 4;
            this.StartButton2.Text = "Return Last Names Using Stored Procedures";
            this.StartButton2.UseVisualStyleBackColor = true;
            this.StartButton2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartButton2_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.StartButton2);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.LabelDatabaseLocation);
            this.Controls.Add(this.DatabaseLocation);
            this.Controls.Add(this.ResultsBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultsBox;
        private System.Windows.Forms.Label LabelDatabaseLocation;
        private System.Windows.Forms.Button StartButton;
        public System.Windows.Forms.TextBox DatabaseLocation;
        private System.Windows.Forms.Button StartButton2;
    }
}

