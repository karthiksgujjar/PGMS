namespace PG_Management_System
{
    partial class FloorsForm
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
            this.Label_FLOORS = new System.Windows.Forms.Label();
            this.Button_AddFloor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_FLOORS
            // 
            this.Label_FLOORS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_FLOORS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_FLOORS.Font = new System.Drawing.Font("Cambria", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FLOORS.Location = new System.Drawing.Point(271, 9);
            this.Label_FLOORS.Name = "Label_FLOORS";
            this.Label_FLOORS.Size = new System.Drawing.Size(258, 70);
            this.Label_FLOORS.TabIndex = 7;
            this.Label_FLOORS.Text = "FLOORS";
            this.Label_FLOORS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_AddFloor
            // 
            this.Button_AddFloor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_AddFloor.BackColor = System.Drawing.Color.Transparent;
            this.Button_AddFloor.FlatAppearance.BorderSize = 0;
            this.Button_AddFloor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_AddFloor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_AddFloor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_AddFloor.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AddFloor.Image = global::PG_Management_System.Properties.Resources.Insert;
            this.Button_AddFloor.Location = new System.Drawing.Point(750, 400);
            this.Button_AddFloor.Name = "Button_AddFloor";
            this.Button_AddFloor.Size = new System.Drawing.Size(38, 38);
            this.Button_AddFloor.TabIndex = 8;
            this.Button_AddFloor.UseVisualStyleBackColor = false;
            this.Button_AddFloor.Click += new System.EventHandler(this.Button_AddFloor_Click);
            // 
            // FloorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_AddFloor);
            this.Controls.Add(this.Label_FLOORS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FloorsForm";
            this.Text = "PGMS - Floors";
            this.Load += new System.EventHandler(this.FloorsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_FLOORS;
        private System.Windows.Forms.Button Button_AddFloor;
    }
}