namespace PG_Management_System
{
    partial class AcceptPaymentForm
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
            this.ComboBox_Rooms = new System.Windows.Forms.ComboBox();
            this.ComboBox_Floors = new System.Windows.Forms.ComboBox();
            this.ComboBox_Buildings = new System.Windows.Forms.ComboBox();
            this.Label_PGFMSReceiptTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboBox_Rooms
            // 
            this.ComboBox_Rooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ComboBox_Rooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Rooms.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Rooms.FormattingEnabled = true;
            this.ComboBox_Rooms.Location = new System.Drawing.Point(613, 90);
            this.ComboBox_Rooms.Name = "ComboBox_Rooms";
            this.ComboBox_Rooms.Size = new System.Drawing.Size(158, 23);
            this.ComboBox_Rooms.Sorted = true;
            this.ComboBox_Rooms.TabIndex = 18;
            this.ComboBox_Rooms.Visible = false;
            // 
            // ComboBox_Floors
            // 
            this.ComboBox_Floors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ComboBox_Floors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Floors.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Floors.FormattingEnabled = true;
            this.ComboBox_Floors.Location = new System.Drawing.Point(613, 59);
            this.ComboBox_Floors.Name = "ComboBox_Floors";
            this.ComboBox_Floors.Size = new System.Drawing.Size(158, 23);
            this.ComboBox_Floors.Sorted = true;
            this.ComboBox_Floors.TabIndex = 17;
            this.ComboBox_Floors.Visible = false;
            // 
            // ComboBox_Buildings
            // 
            this.ComboBox_Buildings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ComboBox_Buildings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Buildings.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Buildings.FormattingEnabled = true;
            this.ComboBox_Buildings.Location = new System.Drawing.Point(613, 28);
            this.ComboBox_Buildings.Name = "ComboBox_Buildings";
            this.ComboBox_Buildings.Size = new System.Drawing.Size(158, 23);
            this.ComboBox_Buildings.Sorted = true;
            this.ComboBox_Buildings.TabIndex = 16;
            // 
            // Label_PGFMSReceiptTitle
            // 
            this.Label_PGFMSReceiptTitle.AutoSize = true;
            this.Label_PGFMSReceiptTitle.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PGFMSReceiptTitle.Location = new System.Drawing.Point(327, 153);
            this.Label_PGFMSReceiptTitle.Name = "Label_PGFMSReceiptTitle";
            this.Label_PGFMSReceiptTitle.Size = new System.Drawing.Size(146, 22);
            this.Label_PGFMSReceiptTitle.TabIndex = 19;
            this.Label_PGFMSReceiptTitle.Text = "PGFMS - Receipt";
            // 
            // AcceptPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Label_PGFMSReceiptTitle);
            this.Controls.Add(this.ComboBox_Rooms);
            this.Controls.Add(this.ComboBox_Floors);
            this.Controls.Add(this.ComboBox_Buildings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AcceptPaymentForm";
            this.Text = "AcceptPaymentForm";
            this.Load += new System.EventHandler(this.AcceptPaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox_Rooms;
        private System.Windows.Forms.ComboBox ComboBox_Floors;
        private System.Windows.Forms.ComboBox ComboBox_Buildings;
        private System.Windows.Forms.Label Label_PGFMSReceiptTitle;
    }
}