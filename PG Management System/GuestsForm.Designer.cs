namespace PG_Management_System
{
    partial class GuestsForm
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
            this.Label_GUESTS = new System.Windows.Forms.Label();
            this.Button_AddGuest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_GUESTS
            // 
            this.Label_GUESTS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_GUESTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_GUESTS.Font = new System.Drawing.Font("Cambria", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_GUESTS.Location = new System.Drawing.Point(275, 9);
            this.Label_GUESTS.Name = "Label_GUESTS";
            this.Label_GUESTS.Size = new System.Drawing.Size(251, 75);
            this.Label_GUESTS.TabIndex = 9;
            this.Label_GUESTS.Text = "GUESTS";
            this.Label_GUESTS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_AddGuest
            // 
            this.Button_AddGuest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_AddGuest.BackColor = System.Drawing.Color.Transparent;
            this.Button_AddGuest.FlatAppearance.BorderSize = 0;
            this.Button_AddGuest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_AddGuest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_AddGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_AddGuest.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AddGuest.Image = global::PG_Management_System.Properties.Resources.Insert;
            this.Button_AddGuest.Location = new System.Drawing.Point(750, 400);
            this.Button_AddGuest.Name = "Button_AddGuest";
            this.Button_AddGuest.Size = new System.Drawing.Size(38, 38);
            this.Button_AddGuest.TabIndex = 10;
            this.Button_AddGuest.UseVisualStyleBackColor = false;
            this.Button_AddGuest.Click += new System.EventHandler(this.Button_AddGuest_Click);
            // 
            // GuestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_AddGuest);
            this.Controls.Add(this.Label_GUESTS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuestsForm";
            this.Text = "PGMS - Guests";
            this.Load += new System.EventHandler(this.GuestsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_GUESTS;
        private System.Windows.Forms.Button Button_AddGuest;
    }
}