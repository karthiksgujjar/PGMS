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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.ComboBox_UN = new System.Windows.Forms.ComboBox();
            this.TextBox_PWD = new System.Windows.Forms.TextBox();
            this.Button_LogIn = new System.Windows.Forms.Button();
            this.Button_FormClose = new System.Windows.Forms.Button();
            this.Button_FormMinimize = new System.Windows.Forms.Button();
            this.LinkLabel_ForgotPWD = new System.Windows.Forms.LinkLabel();
            this.CheckBox_RememberMe = new System.Windows.Forms.CheckBox();
            this.ErrorProvider_LogInForm = new System.Windows.Forms.ErrorProvider(this.components);
            this.Label_UsernameUnderbar = new System.Windows.Forms.Label();
            this.Label_PasswordUnderbar = new System.Windows.Forms.Label();
            this.Button_Show_Hide_Pwd = new System.Windows.Forms.Button();
            this.Label_FormTitle = new System.Windows.Forms.Label();
            this.PictureBox_PGMS = new System.Windows.Forms.PictureBox();
            this.Label_PWD = new System.Windows.Forms.Label();
            this.Label_UN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_LogInForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_PGMS)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBox_UN
            // 
            this.ComboBox_UN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBox_UN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBox_UN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBox_UN.BackColor = System.Drawing.Color.White;
            this.ComboBox_UN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_UN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_UN.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_UN.FormattingEnabled = true;
            this.ComboBox_UN.Location = new System.Drawing.Point(161, 292);
            this.ComboBox_UN.MaxDropDownItems = 3;
            this.ComboBox_UN.Name = "ComboBox_UN";
            this.ComboBox_UN.Size = new System.Drawing.Size(139, 23);
            this.ComboBox_UN.TabIndex = 0;
            this.ComboBox_UN.SelectedIndexChanged += new System.EventHandler(this.ComboBox_UN_SelectedIndexChanged);
            // 
            // TextBox_PWD
            // 
            this.TextBox_PWD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_PWD.BackColor = System.Drawing.Color.White;
            this.TextBox_PWD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_PWD.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_PWD.Location = new System.Drawing.Point(161, 341);
            this.TextBox_PWD.Name = "TextBox_PWD";
            this.TextBox_PWD.Size = new System.Drawing.Size(119, 16);
            this.TextBox_PWD.TabIndex = 1;
            this.TextBox_PWD.UseSystemPasswordChar = true;
            // 
            // Button_LogIn
            // 
            this.Button_LogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_LogIn.BackColor = System.Drawing.Color.Transparent;
            this.Button_LogIn.Cursor = System.Windows.Forms.Cursors.Default;
            this.Button_LogIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_LogIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_LogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_LogIn.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_LogIn.Location = new System.Drawing.Point(133, 424);
            this.Button_LogIn.Name = "Button_LogIn";
            this.Button_LogIn.Size = new System.Drawing.Size(75, 30);
            this.Button_LogIn.TabIndex = 2;
            this.Button_LogIn.Text = "LOGIN";
            this.Button_LogIn.UseVisualStyleBackColor = false;
            this.Button_LogIn.Click += new System.EventHandler(this.Button_LogIn_Click);
            // 
            // Button_FormClose
            // 
            this.Button_FormClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_FormClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_FormClose.FlatAppearance.BorderSize = 0;
            this.Button_FormClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_FormClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Button_FormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_FormClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_FormClose.Location = new System.Drawing.Point(320, 0);
            this.Button_FormClose.Name = "Button_FormClose";
            this.Button_FormClose.Size = new System.Drawing.Size(20, 20);
            this.Button_FormClose.TabIndex = 5;
            this.Button_FormClose.TabStop = false;
            this.Button_FormClose.Text = "X";
            this.Button_FormClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_FormClose.UseVisualStyleBackColor = false;
            this.Button_FormClose.Click += new System.EventHandler(this.Button_FormClose_Click);
            // 
            // Button_FormMinimize
            // 
            this.Button_FormMinimize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_FormMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_FormMinimize.FlatAppearance.BorderSize = 0;
            this.Button_FormMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_FormMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Button_FormMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_FormMinimize.Font = new System.Drawing.Font("Wide Latin", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_FormMinimize.Location = new System.Drawing.Point(300, 0);
            this.Button_FormMinimize.Name = "Button_FormMinimize";
            this.Button_FormMinimize.Size = new System.Drawing.Size(20, 20);
            this.Button_FormMinimize.TabIndex = 6;
            this.Button_FormMinimize.TabStop = false;
            this.Button_FormMinimize.Text = "-";
            this.Button_FormMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_FormMinimize.UseVisualStyleBackColor = false;
            this.Button_FormMinimize.Click += new System.EventHandler(this.Button_FormMinimize_Click);
            // 
            // LinkLabel_ForgotPWD
            // 
            this.LinkLabel_ForgotPWD.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LinkLabel_ForgotPWD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LinkLabel_ForgotPWD.BackColor = System.Drawing.Color.Transparent;
            this.LinkLabel_ForgotPWD.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel_ForgotPWD.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LinkLabel_ForgotPWD.LinkColor = System.Drawing.Color.Navy;
            this.LinkLabel_ForgotPWD.Location = new System.Drawing.Point(198, 368);
            this.LinkLabel_ForgotPWD.Name = "LinkLabel_ForgotPWD";
            this.LinkLabel_ForgotPWD.Size = new System.Drawing.Size(105, 18);
            this.LinkLabel_ForgotPWD.TabIndex = 15;
            this.LinkLabel_ForgotPWD.TabStop = true;
            this.LinkLabel_ForgotPWD.Text = "Forgot Password?";
            this.LinkLabel_ForgotPWD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LinkLabel_ForgotPWD.VisitedLinkColor = System.Drawing.Color.Navy;
            this.LinkLabel_ForgotPWD.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_ForgotPWD_LinkClicked);
            // 
            // CheckBox_RememberMe
            // 
            this.CheckBox_RememberMe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CheckBox_RememberMe.BackColor = System.Drawing.Color.Transparent;
            this.CheckBox_RememberMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBox_RememberMe.FlatAppearance.BorderSize = 0;
            this.CheckBox_RememberMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBox_RememberMe.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_RememberMe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CheckBox_RememberMe.Location = new System.Drawing.Point(34, 368);
            this.CheckBox_RememberMe.Name = "CheckBox_RememberMe";
            this.CheckBox_RememberMe.Size = new System.Drawing.Size(100, 19);
            this.CheckBox_RememberMe.TabIndex = 2;
            this.CheckBox_RememberMe.TabStop = false;
            this.CheckBox_RememberMe.Text = "Remember Me";
            this.CheckBox_RememberMe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBox_RememberMe.UseVisualStyleBackColor = false;
            // 
            // ErrorProvider_LogInForm
            // 
            this.ErrorProvider_LogInForm.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider_LogInForm.ContainerControl = this;
            this.ErrorProvider_LogInForm.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProvider_LogInForm.Icon")));
            this.ErrorProvider_LogInForm.RightToLeft = true;
            // 
            // Label_UsernameUnderbar
            // 
            this.Label_UsernameUnderbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_UsernameUnderbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_UsernameUnderbar.Location = new System.Drawing.Point(161, 317);
            this.Label_UsernameUnderbar.Name = "Label_UsernameUnderbar";
            this.Label_UsernameUnderbar.Size = new System.Drawing.Size(139, 1);
            this.Label_UsernameUnderbar.TabIndex = 16;
            // 
            // Label_PasswordUnderbar
            // 
            this.Label_PasswordUnderbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_PasswordUnderbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_PasswordUnderbar.Location = new System.Drawing.Point(161, 360);
            this.Label_PasswordUnderbar.Name = "Label_PasswordUnderbar";
            this.Label_PasswordUnderbar.Size = new System.Drawing.Size(139, 1);
            this.Label_PasswordUnderbar.TabIndex = 17;
            // 
            // Button_Show_Hide_Pwd
            // 
            this.Button_Show_Hide_Pwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Show_Hide_Pwd.BackColor = System.Drawing.Color.Transparent;
            this.Button_Show_Hide_Pwd.Cursor = System.Windows.Forms.Cursors.Default;
            this.Button_Show_Hide_Pwd.FlatAppearance.BorderSize = 0;
            this.Button_Show_Hide_Pwd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_Show_Hide_Pwd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Show_Hide_Pwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Show_Hide_Pwd.Image = global::PG_Management_System.Properties.Resources.Show_Password;
            this.Button_Show_Hide_Pwd.Location = new System.Drawing.Point(279, 339);
            this.Button_Show_Hide_Pwd.Name = "Button_Show_Hide_Pwd";
            this.Button_Show_Hide_Pwd.Size = new System.Drawing.Size(21, 19);
            this.Button_Show_Hide_Pwd.TabIndex = 8;
            this.Button_Show_Hide_Pwd.TabStop = false;
            this.Button_Show_Hide_Pwd.UseVisualStyleBackColor = false;
            this.Button_Show_Hide_Pwd.Click += new System.EventHandler(this.Button_Show_Hide_Pwd_Click);
            // 
            // Label_FormTitle
            // 
            this.Label_FormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_FormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_FormTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_FormTitle.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FormTitle.Image = ((System.Drawing.Image)(resources.GetObject("Label_FormTitle.Image")));
            this.Label_FormTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Label_FormTitle.Location = new System.Drawing.Point(0, 0);
            this.Label_FormTitle.Name = "Label_FormTitle";
            this.Label_FormTitle.Size = new System.Drawing.Size(340, 20);
            this.Label_FormTitle.TabIndex = 4;
            this.Label_FormTitle.Text = "PGMS - Log In";
            this.Label_FormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox_PGMS
            // 
            this.PictureBox_PGMS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBox_PGMS.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_PGMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox_PGMS.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_PGMS.Image")));
            this.PictureBox_PGMS.Location = new System.Drawing.Point(78, 50);
            this.PictureBox_PGMS.Name = "PictureBox_PGMS";
            this.PictureBox_PGMS.Size = new System.Drawing.Size(184, 194);
            this.PictureBox_PGMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_PGMS.TabIndex = 3;
            this.PictureBox_PGMS.TabStop = false;
            // 
            // Label_PWD
            // 
            this.Label_PWD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_PWD.BackColor = System.Drawing.Color.Transparent;
            this.Label_PWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_PWD.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PWD.Image = global::PG_Management_System.Properties.Resources.Password_Image;
            this.Label_PWD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_PWD.Location = new System.Drawing.Point(16, 339);
            this.Label_PWD.Name = "Label_PWD";
            this.Label_PWD.Size = new System.Drawing.Size(127, 22);
            this.Label_PWD.TabIndex = 0;
            this.Label_PWD.Text = "Password :";
            this.Label_PWD.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Label_UN
            // 
            this.Label_UN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_UN.BackColor = System.Drawing.Color.Transparent;
            this.Label_UN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_UN.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_UN.Image = global::PG_Management_System.Properties.Resources.Username_Image;
            this.Label_UN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_UN.Location = new System.Drawing.Point(17, 291);
            this.Label_UN.Name = "Label_UN";
            this.Label_UN.Size = new System.Drawing.Size(127, 26);
            this.Label_UN.TabIndex = 0;
            this.Label_UN.Text = "Username :";
            this.Label_UN.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(340, 475);
            this.Controls.Add(this.Label_PasswordUnderbar);
            this.Controls.Add(this.Label_UsernameUnderbar);
            this.Controls.Add(this.Button_Show_Hide_Pwd);
            this.Controls.Add(this.CheckBox_RememberMe);
            this.Controls.Add(this.LinkLabel_ForgotPWD);
            this.Controls.Add(this.Button_FormMinimize);
            this.Controls.Add(this.Button_FormClose);
            this.Controls.Add(this.Label_FormTitle);
            this.Controls.Add(this.PictureBox_PGMS);
            this.Controls.Add(this.Button_LogIn);
            this.Controls.Add(this.TextBox_PWD);
            this.Controls.Add(this.ComboBox_UN);
            this.Controls.Add(this.Label_PWD);
            this.Controls.Add(this.Label_UN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_LogInForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_PGMS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_UN;
        private System.Windows.Forms.Label Label_PWD;
        private System.Windows.Forms.ComboBox ComboBox_UN;
        private System.Windows.Forms.TextBox TextBox_PWD;
        private System.Windows.Forms.Button Button_LogIn;
        private System.Windows.Forms.PictureBox PictureBox_PGMS;
        private System.Windows.Forms.Label Label_FormTitle;
        private System.Windows.Forms.Button Button_FormClose;
        private System.Windows.Forms.Button Button_FormMinimize;
        private System.Windows.Forms.LinkLabel LinkLabel_ForgotPWD;
        private System.Windows.Forms.CheckBox CheckBox_RememberMe;
        private System.Windows.Forms.Button Button_Show_Hide_Pwd;
        private System.Windows.Forms.ErrorProvider ErrorProvider_LogInForm;
        private System.Windows.Forms.Label Label_UsernameUnderbar;
        private System.Windows.Forms.Label Label_PasswordUnderbar;
    }
}

