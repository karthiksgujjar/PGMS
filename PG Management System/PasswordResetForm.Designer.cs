namespace PG_Management_System
{
    partial class PasswordResetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordResetForm));
            this.Button_FormClose = new System.Windows.Forms.Button();
            this.Label_MailIDUnderbar = new System.Windows.Forms.Label();
            this.TextBox_MailID = new System.Windows.Forms.TextBox();
            this.Label_OTP = new System.Windows.Forms.Label();
            this.TextBox_OTP = new System.Windows.Forms.TextBox();
            this.Label_OTPUnderbar = new System.Windows.Forms.Label();
            this.Label_MailSentSuccessfully = new System.Windows.Forms.Label();
            this.Label_MailID = new System.Windows.Forms.Label();
            this.PictureBox_PGMS = new System.Windows.Forms.PictureBox();
            this.Label_FormTitle = new System.Windows.Forms.Label();
            this.Label_NewPWD = new System.Windows.Forms.Label();
            this.TextBox_NewPWD = new System.Windows.Forms.TextBox();
            this.Label_NewPWDUnderbar = new System.Windows.Forms.Label();
            this.Label_ConfirmPWD = new System.Windows.Forms.Label();
            this.TextBox_ConfirmPWD = new System.Windows.Forms.TextBox();
            this.Label_ConfirmPWDUnderbar = new System.Windows.Forms.Label();
            this.Button_ResetPWD = new System.Windows.Forms.Button();
            this.ErrorProvider_PasswordResetForm = new System.Windows.Forms.ErrorProvider(this.components);
            this.Label_Separator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_PGMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_PasswordResetForm)).BeginInit();
            this.SuspendLayout();
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
            this.Button_FormClose.Location = new System.Drawing.Point(550, 0);
            this.Button_FormClose.Name = "Button_FormClose";
            this.Button_FormClose.Size = new System.Drawing.Size(20, 20);
            this.Button_FormClose.TabIndex = 8;
            this.Button_FormClose.TabStop = false;
            this.Button_FormClose.Text = "X";
            this.Button_FormClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_FormClose.UseVisualStyleBackColor = false;
            this.Button_FormClose.Click += new System.EventHandler(this.Button_FormClose_Click);
            // 
            // Label_MailIDUnderbar
            // 
            this.Label_MailIDUnderbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_MailIDUnderbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_MailIDUnderbar.Location = new System.Drawing.Point(319, 58);
            this.Label_MailIDUnderbar.Name = "Label_MailIDUnderbar";
            this.Label_MailIDUnderbar.Size = new System.Drawing.Size(238, 1);
            this.Label_MailIDUnderbar.TabIndex = 20;
            this.Label_MailIDUnderbar.Text = "label1";
            // 
            // TextBox_MailID
            // 
            this.TextBox_MailID.AcceptsReturn = true;
            this.TextBox_MailID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_MailID.BackColor = System.Drawing.Color.White;
            this.TextBox_MailID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_MailID.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_MailID.Location = new System.Drawing.Point(319, 38);
            this.TextBox_MailID.Name = "TextBox_MailID";
            this.TextBox_MailID.Size = new System.Drawing.Size(238, 16);
            this.TextBox_MailID.TabIndex = 0;
            this.TextBox_MailID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_MailID_KeyPress);
            // 
            // Label_OTP
            // 
            this.Label_OTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_OTP.BackColor = System.Drawing.Color.Transparent;
            this.Label_OTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_OTP.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_OTP.Image = global::PG_Management_System.Properties.Resources.OTP_Image;
            this.Label_OTP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_OTP.Location = new System.Drawing.Point(274, 97);
            this.Label_OTP.Name = "Label_OTP";
            this.Label_OTP.Size = new System.Drawing.Size(104, 25);
            this.Label_OTP.TabIndex = 18;
            this.Label_OTP.Text = "O  T   P :";
            this.Label_OTP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox_OTP
            // 
            this.TextBox_OTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_OTP.BackColor = System.Drawing.Color.White;
            this.TextBox_OTP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_OTP.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_OTP.Location = new System.Drawing.Point(381, 104);
            this.TextBox_OTP.Name = "TextBox_OTP";
            this.TextBox_OTP.Size = new System.Drawing.Size(147, 16);
            this.TextBox_OTP.TabIndex = 1;
            // 
            // Label_OTPUnderbar
            // 
            this.Label_OTPUnderbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_OTPUnderbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_OTPUnderbar.Location = new System.Drawing.Point(381, 123);
            this.Label_OTPUnderbar.Name = "Label_OTPUnderbar";
            this.Label_OTPUnderbar.Size = new System.Drawing.Size(147, 1);
            this.Label_OTPUnderbar.TabIndex = 20;
            this.Label_OTPUnderbar.Text = "label1";
            // 
            // Label_MailSentSuccessfully
            // 
            this.Label_MailSentSuccessfully.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_MailSentSuccessfully.BackColor = System.Drawing.Color.Transparent;
            this.Label_MailSentSuccessfully.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_MailSentSuccessfully.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MailSentSuccessfully.ForeColor = System.Drawing.Color.DarkGreen;
            this.Label_MailSentSuccessfully.Image = global::PG_Management_System.Properties.Resources.Mail_Sent_Green_Tick_Image;
            this.Label_MailSentSuccessfully.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_MailSentSuccessfully.Location = new System.Drawing.Point(413, 62);
            this.Label_MailSentSuccessfully.Name = "Label_MailSentSuccessfully";
            this.Label_MailSentSuccessfully.Size = new System.Drawing.Size(144, 18);
            this.Label_MailSentSuccessfully.TabIndex = 22;
            this.Label_MailSentSuccessfully.Text = "Mail Sent Successfully";
            this.Label_MailSentSuccessfully.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label_MailSentSuccessfully.Visible = false;
            // 
            // Label_MailID
            // 
            this.Label_MailID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_MailID.BackColor = System.Drawing.Color.Transparent;
            this.Label_MailID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_MailID.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MailID.Image = global::PG_Management_System.Properties.Resources.Mail_Image;
            this.Label_MailID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_MailID.Location = new System.Drawing.Point(202, 35);
            this.Label_MailID.Name = "Label_MailID";
            this.Label_MailID.Size = new System.Drawing.Size(108, 25);
            this.Label_MailID.TabIndex = 18;
            this.Label_MailID.Text = "Mail ID :";
            this.Label_MailID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PictureBox_PGMS
            // 
            this.PictureBox_PGMS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBox_PGMS.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_PGMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox_PGMS.Image = global::PG_Management_System.Properties.Resources.PGFMS_Logo;
            this.PictureBox_PGMS.Location = new System.Drawing.Point(12, 35);
            this.PictureBox_PGMS.Name = "PictureBox_PGMS";
            this.PictureBox_PGMS.Size = new System.Drawing.Size(184, 194);
            this.PictureBox_PGMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_PGMS.TabIndex = 21;
            this.PictureBox_PGMS.TabStop = false;
            // 
            // Label_FormTitle
            // 
            this.Label_FormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_FormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_FormTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_FormTitle.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FormTitle.Image = global::PG_Management_System.Properties.Resources.PGFMS_Logo_Small;
            this.Label_FormTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Label_FormTitle.Location = new System.Drawing.Point(0, 0);
            this.Label_FormTitle.Name = "Label_FormTitle";
            this.Label_FormTitle.Size = new System.Drawing.Size(570, 20);
            this.Label_FormTitle.TabIndex = 7;
            this.Label_FormTitle.Text = "PGMS - Password Reset";
            this.Label_FormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_NewPWD
            // 
            this.Label_NewPWD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_NewPWD.BackColor = System.Drawing.Color.Transparent;
            this.Label_NewPWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_NewPWD.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NewPWD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_NewPWD.Location = new System.Drawing.Point(233, 138);
            this.Label_NewPWD.Name = "Label_NewPWD";
            this.Label_NewPWD.Size = new System.Drawing.Size(145, 25);
            this.Label_NewPWD.TabIndex = 18;
            this.Label_NewPWD.Text = "New Password :";
            this.Label_NewPWD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox_NewPWD
            // 
            this.TextBox_NewPWD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_NewPWD.BackColor = System.Drawing.Color.White;
            this.TextBox_NewPWD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_NewPWD.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_NewPWD.Location = new System.Drawing.Point(381, 145);
            this.TextBox_NewPWD.Name = "TextBox_NewPWD";
            this.TextBox_NewPWD.Size = new System.Drawing.Size(147, 16);
            this.TextBox_NewPWD.TabIndex = 2;
            this.TextBox_NewPWD.UseSystemPasswordChar = true;
            // 
            // Label_NewPWDUnderbar
            // 
            this.Label_NewPWDUnderbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_NewPWDUnderbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_NewPWDUnderbar.Location = new System.Drawing.Point(381, 164);
            this.Label_NewPWDUnderbar.Name = "Label_NewPWDUnderbar";
            this.Label_NewPWDUnderbar.Size = new System.Drawing.Size(147, 1);
            this.Label_NewPWDUnderbar.TabIndex = 20;
            this.Label_NewPWDUnderbar.Text = "label1";
            // 
            // Label_ConfirmPWD
            // 
            this.Label_ConfirmPWD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_ConfirmPWD.BackColor = System.Drawing.Color.Transparent;
            this.Label_ConfirmPWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_ConfirmPWD.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ConfirmPWD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_ConfirmPWD.Location = new System.Drawing.Point(204, 179);
            this.Label_ConfirmPWD.Name = "Label_ConfirmPWD";
            this.Label_ConfirmPWD.Size = new System.Drawing.Size(174, 25);
            this.Label_ConfirmPWD.TabIndex = 18;
            this.Label_ConfirmPWD.Text = "Confirm Password :";
            this.Label_ConfirmPWD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox_ConfirmPWD
            // 
            this.TextBox_ConfirmPWD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_ConfirmPWD.BackColor = System.Drawing.Color.White;
            this.TextBox_ConfirmPWD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_ConfirmPWD.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_ConfirmPWD.Location = new System.Drawing.Point(381, 186);
            this.TextBox_ConfirmPWD.Name = "TextBox_ConfirmPWD";
            this.TextBox_ConfirmPWD.Size = new System.Drawing.Size(147, 16);
            this.TextBox_ConfirmPWD.TabIndex = 3;
            // 
            // Label_ConfirmPWDUnderbar
            // 
            this.Label_ConfirmPWDUnderbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_ConfirmPWDUnderbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_ConfirmPWDUnderbar.Location = new System.Drawing.Point(381, 205);
            this.Label_ConfirmPWDUnderbar.Name = "Label_ConfirmPWDUnderbar";
            this.Label_ConfirmPWDUnderbar.Size = new System.Drawing.Size(147, 1);
            this.Label_ConfirmPWDUnderbar.TabIndex = 20;
            this.Label_ConfirmPWDUnderbar.Text = "label1";
            // 
            // Button_ResetPWD
            // 
            this.Button_ResetPWD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_ResetPWD.BackColor = System.Drawing.Color.Transparent;
            this.Button_ResetPWD.Cursor = System.Windows.Forms.Cursors.Default;
            this.Button_ResetPWD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_ResetPWD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_ResetPWD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_ResetPWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ResetPWD.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ResetPWD.Location = new System.Drawing.Point(453, 227);
            this.Button_ResetPWD.Name = "Button_ResetPWD";
            this.Button_ResetPWD.Size = new System.Drawing.Size(75, 30);
            this.Button_ResetPWD.TabIndex = 4;
            this.Button_ResetPWD.Text = "RESET";
            this.Button_ResetPWD.UseVisualStyleBackColor = false;
            this.Button_ResetPWD.Click += new System.EventHandler(this.Button_ResetPWD_Click);
            // 
            // ErrorProvider_PasswordResetForm
            // 
            this.ErrorProvider_PasswordResetForm.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider_PasswordResetForm.ContainerControl = this;
            this.ErrorProvider_PasswordResetForm.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProvider_PasswordResetForm.Icon")));
            // 
            // Label_Separator
            // 
            this.Label_Separator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Separator.BackColor = System.Drawing.Color.Red;
            this.Label_Separator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Label_Separator.Location = new System.Drawing.Point(202, 85);
            this.Label_Separator.Name = "Label_Separator";
            this.Label_Separator.Size = new System.Drawing.Size(365, 1);
            this.Label_Separator.TabIndex = 24;
            this.Label_Separator.Text = "label1";
            // 
            // PasswordResetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(570, 269);
            this.Controls.Add(this.Label_Separator);
            this.Controls.Add(this.Button_ResetPWD);
            this.Controls.Add(this.Label_MailSentSuccessfully);
            this.Controls.Add(this.PictureBox_PGMS);
            this.Controls.Add(this.Label_ConfirmPWDUnderbar);
            this.Controls.Add(this.Label_NewPWDUnderbar);
            this.Controls.Add(this.Label_OTPUnderbar);
            this.Controls.Add(this.Label_MailIDUnderbar);
            this.Controls.Add(this.TextBox_ConfirmPWD);
            this.Controls.Add(this.Label_ConfirmPWD);
            this.Controls.Add(this.TextBox_NewPWD);
            this.Controls.Add(this.Label_NewPWD);
            this.Controls.Add(this.TextBox_OTP);
            this.Controls.Add(this.Label_OTP);
            this.Controls.Add(this.TextBox_MailID);
            this.Controls.Add(this.Label_MailID);
            this.Controls.Add(this.Button_FormClose);
            this.Controls.Add(this.Label_FormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PasswordResetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_PGMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_PasswordResetForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button_FormClose;
        private System.Windows.Forms.Label Label_FormTitle;
        private System.Windows.Forms.Label Label_MailIDUnderbar;
        private System.Windows.Forms.TextBox TextBox_MailID;
        private System.Windows.Forms.Label Label_MailID;
        private System.Windows.Forms.PictureBox PictureBox_PGMS;
        private System.Windows.Forms.Label Label_MailSentSuccessfully;
        private System.Windows.Forms.Label Label_OTP;
        private System.Windows.Forms.TextBox TextBox_OTP;
        private System.Windows.Forms.Label Label_OTPUnderbar;
        private System.Windows.Forms.Label Label_NewPWD;
        private System.Windows.Forms.TextBox TextBox_NewPWD;
        private System.Windows.Forms.Label Label_NewPWDUnderbar;
        private System.Windows.Forms.Label Label_ConfirmPWD;
        private System.Windows.Forms.TextBox TextBox_ConfirmPWD;
        private System.Windows.Forms.Label Label_ConfirmPWDUnderbar;
        private System.Windows.Forms.Button Button_ResetPWD;
        private System.Windows.Forms.ErrorProvider ErrorProvider_PasswordResetForm;
        private System.Windows.Forms.Label Label_Separator;
    }
}