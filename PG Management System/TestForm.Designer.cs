namespace PG_Management_System
{
    partial class TestForm
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
            this.SideBarPanel = new System.Windows.Forms.Panel();
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.ButtonBuilding = new System.Windows.Forms.Button();
            this.ButtonFloor = new System.Windows.Forms.Button();
            this.SideBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBarPanel
            // 
            this.SideBarPanel.Controls.Add(this.ButtonFloor);
            this.SideBarPanel.Controls.Add(this.ButtonBuilding);
            this.SideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.SideBarPanel.Name = "SideBarPanel";
            this.SideBarPanel.Size = new System.Drawing.Size(159, 450);
            this.SideBarPanel.TabIndex = 0;
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayPanel.Location = new System.Drawing.Point(159, 0);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(641, 450);
            this.DisplayPanel.TabIndex = 1;
            // 
            // ButtonBuilding
            // 
            this.ButtonBuilding.Location = new System.Drawing.Point(36, 70);
            this.ButtonBuilding.Name = "ButtonBuilding";
            this.ButtonBuilding.Size = new System.Drawing.Size(75, 23);
            this.ButtonBuilding.TabIndex = 0;
            this.ButtonBuilding.Text = "Buildings";
            this.ButtonBuilding.UseVisualStyleBackColor = true;
            this.ButtonBuilding.Click += new System.EventHandler(this.ButtonBuilding_Click);
            // 
            // ButtonFloor
            // 
            this.ButtonFloor.Location = new System.Drawing.Point(42, 214);
            this.ButtonFloor.Name = "ButtonFloor";
            this.ButtonFloor.Size = new System.Drawing.Size(75, 23);
            this.ButtonFloor.TabIndex = 1;
            this.ButtonFloor.Text = "Floors";
            this.ButtonFloor.UseVisualStyleBackColor = true;
            this.ButtonFloor.Click += new System.EventHandler(this.ButtonFloor_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DisplayPanel);
            this.Controls.Add(this.SideBarPanel);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.SideBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBarPanel;
        private System.Windows.Forms.Panel DisplayPanel;
        private System.Windows.Forms.Button ButtonFloor;
        private System.Windows.Forms.Button ButtonBuilding;
    }
}