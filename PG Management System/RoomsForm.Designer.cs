namespace PG_Management_System
{
    partial class RoomsForm
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
            this.Label_ROOMS = new System.Windows.Forms.Label();
            this.Button_AddRoom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_ROOMS
            // 
            this.Label_ROOMS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_ROOMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_ROOMS.Font = new System.Drawing.Font("Cambria", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ROOMS.Location = new System.Drawing.Point(271, 9);
            this.Label_ROOMS.Name = "Label_ROOMS";
            this.Label_ROOMS.Size = new System.Drawing.Size(258, 70);
            this.Label_ROOMS.TabIndex = 9;
            this.Label_ROOMS.Text = "ROOMS";
            this.Label_ROOMS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_AddRoom
            // 
            this.Button_AddRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_AddRoom.FlatAppearance.BorderSize = 0;
            this.Button_AddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_AddRoom.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AddRoom.Location = new System.Drawing.Point(750, 400);
            this.Button_AddRoom.Name = "Button_AddRoom";
            this.Button_AddRoom.Size = new System.Drawing.Size(38, 38);
            this.Button_AddRoom.TabIndex = 8;
            this.Button_AddRoom.Text = "+";
            this.Button_AddRoom.UseVisualStyleBackColor = true;
            // 
            // RoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_ROOMS);
            this.Controls.Add(this.Button_AddRoom);
            this.Name = "RoomsForm";
            this.Text = "PGMS - Rooms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_ROOMS;
        private System.Windows.Forms.Button Button_AddRoom;
    }
}