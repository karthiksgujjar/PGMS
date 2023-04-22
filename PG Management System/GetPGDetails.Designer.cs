namespace PG_Management_System
{
    partial class GetPGDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetPGDetails));
            this.Button_Save = new System.Windows.Forms.Button();
            this.Label_PGDetailsTitle = new System.Windows.Forms.Label();
            this.Label_PGAddressUnderbar = new System.Windows.Forms.Label();
            this.Label_PGNameUnderbar = new System.Windows.Forms.Label();
            this.Label_PGName = new System.Windows.Forms.Label();
            this.Label_PGAddress = new System.Windows.Forms.Label();
            this.TextBox_PGAddress = new System.Windows.Forms.TextBox();
            this.TextBox_PGName = new System.Windows.Forms.TextBox();
            this.ErrorProvider_GetPGDetailsForm = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_GetPGDetailsForm)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Save
            // 
            this.Button_Save.BackColor = System.Drawing.Color.Transparent;
            this.Button_Save.Cursor = System.Windows.Forms.Cursors.Default;
            this.Button_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Save.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Save.Location = new System.Drawing.Point(143, 244);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(99, 31);
            this.Button_Save.TabIndex = 71;
            this.Button_Save.Text = "SAVE";
            this.Button_Save.UseVisualStyleBackColor = false;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Label_PGDetailsTitle
            // 
            this.Label_PGDetailsTitle.AutoSize = true;
            this.Label_PGDetailsTitle.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PGDetailsTitle.Location = new System.Drawing.Point(95, 18);
            this.Label_PGDetailsTitle.Name = "Label_PGDetailsTitle";
            this.Label_PGDetailsTitle.Size = new System.Drawing.Size(195, 25);
            this.Label_PGDetailsTitle.TabIndex = 72;
            this.Label_PGDetailsTitle.Text = "- Enter PG Details -";
            // 
            // Label_PGAddressUnderbar
            // 
            this.Label_PGAddressUnderbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_PGAddressUnderbar.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PGAddressUnderbar.Location = new System.Drawing.Point(151, 208);
            this.Label_PGAddressUnderbar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_PGAddressUnderbar.Name = "Label_PGAddressUnderbar";
            this.Label_PGAddressUnderbar.Size = new System.Drawing.Size(171, 1);
            this.Label_PGAddressUnderbar.TabIndex = 78;
            this.Label_PGAddressUnderbar.Text = "label1";
            // 
            // Label_PGNameUnderbar
            // 
            this.Label_PGNameUnderbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_PGNameUnderbar.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PGNameUnderbar.Location = new System.Drawing.Point(151, 110);
            this.Label_PGNameUnderbar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_PGNameUnderbar.Name = "Label_PGNameUnderbar";
            this.Label_PGNameUnderbar.Size = new System.Drawing.Size(171, 1);
            this.Label_PGNameUnderbar.TabIndex = 77;
            this.Label_PGNameUnderbar.Text = "label1";
            // 
            // Label_PGName
            // 
            this.Label_PGName.AutoSize = true;
            this.Label_PGName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PGName.Location = new System.Drawing.Point(66, 83);
            this.Label_PGName.Name = "Label_PGName";
            this.Label_PGName.Size = new System.Drawing.Size(78, 25);
            this.Label_PGName.TabIndex = 76;
            this.Label_PGName.Text = "Name :";
            // 
            // Label_PGAddress
            // 
            this.Label_PGAddress.AutoSize = true;
            this.Label_PGAddress.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PGAddress.Location = new System.Drawing.Point(40, 146);
            this.Label_PGAddress.Name = "Label_PGAddress";
            this.Label_PGAddress.Size = new System.Drawing.Size(104, 25);
            this.Label_PGAddress.TabIndex = 75;
            this.Label_PGAddress.Text = "Address :";
            // 
            // TextBox_PGAddress
            // 
            this.TextBox_PGAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_PGAddress.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_PGAddress.Location = new System.Drawing.Point(151, 146);
            this.TextBox_PGAddress.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_PGAddress.Multiline = true;
            this.TextBox_PGAddress.Name = "TextBox_PGAddress";
            this.TextBox_PGAddress.Size = new System.Drawing.Size(171, 58);
            this.TextBox_PGAddress.TabIndex = 74;
            // 
            // TextBox_PGName
            // 
            this.TextBox_PGName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_PGName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_PGName.Location = new System.Drawing.Point(151, 83);
            this.TextBox_PGName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_PGName.Name = "TextBox_PGName";
            this.TextBox_PGName.Size = new System.Drawing.Size(171, 25);
            this.TextBox_PGName.TabIndex = 73;
            // 
            // ErrorProvider_GetPGDetailsForm
            // 
            this.ErrorProvider_GetPGDetailsForm.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider_GetPGDetailsForm.ContainerControl = this;
            this.ErrorProvider_GetPGDetailsForm.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProvider_GetPGDetailsForm.Icon")));
            // 
            // GetPGDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 295);
            this.ControlBox = false;
            this.Controls.Add(this.Label_PGAddressUnderbar);
            this.Controls.Add(this.Label_PGNameUnderbar);
            this.Controls.Add(this.Label_PGName);
            this.Controls.Add(this.Label_PGAddress);
            this.Controls.Add(this.TextBox_PGAddress);
            this.Controls.Add(this.TextBox_PGName);
            this.Controls.Add(this.Label_PGDetailsTitle);
            this.Controls.Add(this.Button_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetPGDetails";
            this.Text = "GetPGDetails";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_GetPGDetailsForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Label Label_PGDetailsTitle;
        private System.Windows.Forms.Label Label_PGAddressUnderbar;
        private System.Windows.Forms.Label Label_PGNameUnderbar;
        private System.Windows.Forms.Label Label_PGName;
        private System.Windows.Forms.Label Label_PGAddress;
        private System.Windows.Forms.TextBox TextBox_PGAddress;
        private System.Windows.Forms.TextBox TextBox_PGName;
        private System.Windows.Forms.ErrorProvider ErrorProvider_GetPGDetailsForm;
    }
}