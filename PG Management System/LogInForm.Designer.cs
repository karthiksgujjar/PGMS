namespace PG_Management_System
{
    partial class LoginForm
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
            this.Label_UN = new System.Windows.Forms.Label();
            this.Label_PWD = new System.Windows.Forms.Label();
            this.ComboBox_UN = new System.Windows.Forms.ComboBox();
            this.TextBox_PWD = new System.Windows.Forms.TextBox();
            this.Button_LogIn = new System.Windows.Forms.Button();
            this.Button_ForgotPWD = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_UN
            // 
            this.Label_UN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_UN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_UN.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_UN.Location = new System.Drawing.Point(38, 276);
            this.Label_UN.Name = "Label_UN";
            this.Label_UN.Size = new System.Drawing.Size(115, 23);
            this.Label_UN.TabIndex = 0;
            this.Label_UN.Text = "Username :";
            this.Label_UN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_PWD
            // 
            this.Label_PWD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_PWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_PWD.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PWD.Location = new System.Drawing.Point(38, 323);
            this.Label_PWD.Name = "Label_PWD";
            this.Label_PWD.Size = new System.Drawing.Size(115, 23);
            this.Label_PWD.TabIndex = 0;
            this.Label_PWD.Text = "Password :";
            this.Label_PWD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBox_UN
            // 
            this.ComboBox_UN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBox_UN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBox_UN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBox_UN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_UN.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_UN.FormattingEnabled = true;
            this.ComboBox_UN.Items.AddRange(new object[] {
            "Admin",
            "Staff1",
            "Staff2"});
            this.ComboBox_UN.Location = new System.Drawing.Point(161, 276);
            this.ComboBox_UN.MaxDropDownItems = 3;
            this.ComboBox_UN.Name = "ComboBox_UN";
            this.ComboBox_UN.Size = new System.Drawing.Size(139, 27);
            this.ComboBox_UN.TabIndex = 0;
            this.ComboBox_UN.Text = "-- Select --";
            // 
            // TextBox_PWD
            // 
            this.TextBox_PWD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_PWD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_PWD.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_PWD.Location = new System.Drawing.Point(161, 325);
            this.TextBox_PWD.Name = "TextBox_PWD";
            this.TextBox_PWD.Size = new System.Drawing.Size(139, 19);
            this.TextBox_PWD.TabIndex = 1;
            this.TextBox_PWD.UseSystemPasswordChar = true;
            // 
            // Button_LogIn
            // 
            this.Button_LogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_LogIn.FlatAppearance.BorderSize = 0;
            this.Button_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_LogIn.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_LogIn.Location = new System.Drawing.Point(126, 394);
            this.Button_LogIn.Name = "Button_LogIn";
            this.Button_LogIn.Size = new System.Drawing.Size(75, 30);
            this.Button_LogIn.TabIndex = 3;
            this.Button_LogIn.Text = "LOGIN";
            this.Button_LogIn.UseVisualStyleBackColor = true;
            // 
            // Button_ForgotPWD
            // 
            this.Button_ForgotPWD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_ForgotPWD.FlatAppearance.BorderSize = 0;
            this.Button_ForgotPWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ForgotPWD.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ForgotPWD.ForeColor = System.Drawing.Color.Blue;
            this.Button_ForgotPWD.Location = new System.Drawing.Point(188, 345);
            this.Button_ForgotPWD.Name = "Button_ForgotPWD";
            this.Button_ForgotPWD.Size = new System.Drawing.Size(112, 26);
            this.Button_ForgotPWD.TabIndex = 2;
            this.Button_ForgotPWD.Text = "Forgot Password?";
            this.Button_ForgotPWD.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(77, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 194);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 475);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Button_ForgotPWD);
            this.Controls.Add(this.Button_LogIn);
            this.Controls.Add(this.TextBox_PWD);
            this.Controls.Add(this.ComboBox_UN);
            this.Controls.Add(this.Label_PWD);
            this.Controls.Add(this.Label_UN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PGMS - Log In";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_UN;
        private System.Windows.Forms.Label Label_PWD;
        private System.Windows.Forms.ComboBox ComboBox_UN;
        private System.Windows.Forms.TextBox TextBox_PWD;
        private System.Windows.Forms.Button Button_LogIn;
        private System.Windows.Forms.Button Button_ForgotPWD;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

