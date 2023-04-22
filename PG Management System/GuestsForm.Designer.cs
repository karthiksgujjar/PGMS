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
            this.SuspendLayout();
            // 
            // Label_GUESTS
            // 
            this.Label_GUESTS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_GUESTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_GUESTS.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_GUESTS.Location = new System.Drawing.Point(271, 9);
            this.Label_GUESTS.Name = "Label_GUESTS";
            this.Label_GUESTS.Size = new System.Drawing.Size(258, 75);
            this.Label_GUESTS.TabIndex = 9;
            this.Label_GUESTS.Text = "GUESTS";
            this.Label_GUESTS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GuestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_GUESTS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuestsForm";
            this.Text = "PGMS - Guests";
            this.Load += new System.EventHandler(this.GuestsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_GUESTS;
    }
}