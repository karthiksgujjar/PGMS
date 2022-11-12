namespace PG_Management_System
{
    partial class BedsForm
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
            this.Label_RoomNoDisplay = new System.Windows.Forms.Label();
            this.Button_AddBed = new System.Windows.Forms.Button();
            this.Label_RoomDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_RoomNoDisplay
            // 
            this.Label_RoomNoDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_RoomNoDisplay.AutoSize = true;
            this.Label_RoomNoDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_RoomNoDisplay.Font = new System.Drawing.Font("Cambria", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RoomNoDisplay.Location = new System.Drawing.Point(212, 9);
            this.Label_RoomNoDisplay.Name = "Label_RoomNoDisplay";
            this.Label_RoomNoDisplay.Size = new System.Drawing.Size(315, 75);
            this.Label_RoomNoDisplay.TabIndex = 9;
            this.Label_RoomNoDisplay.Text = "Room No. ";
            this.Label_RoomNoDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_AddBed
            // 
            this.Button_AddBed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_AddBed.FlatAppearance.BorderSize = 0;
            this.Button_AddBed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_AddBed.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AddBed.Location = new System.Drawing.Point(750, 400);
            this.Button_AddBed.Name = "Button_AddBed";
            this.Button_AddBed.Size = new System.Drawing.Size(38, 38);
            this.Button_AddBed.TabIndex = 8;
            this.Button_AddBed.Text = "+";
            this.Button_AddBed.UseVisualStyleBackColor = true;
            // 
            // Label_RoomDetails
            // 
            this.Label_RoomDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_RoomDetails.AutoSize = true;
            this.Label_RoomDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_RoomDetails.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RoomDetails.Location = new System.Drawing.Point(12, 97);
            this.Label_RoomDetails.Name = "Label_RoomDetails";
            this.Label_RoomDetails.Size = new System.Drawing.Size(188, 66);
            this.Label_RoomDetails.TabIndex = 10;
            this.Label_RoomDetails.Text = "Total No. of Beds : XX \r\n   Beds Occupied : XX\r\n        Beds Vacant : XX";
            this.Label_RoomDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BedsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_RoomDetails);
            this.Controls.Add(this.Label_RoomNoDisplay);
            this.Controls.Add(this.Button_AddBed);
            this.Name = "BedsForm";
            this.Text = "PGMS - Beds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_RoomNoDisplay;
        private System.Windows.Forms.Button Button_AddBed;
        private System.Windows.Forms.Label Label_RoomDetails;
    }
}