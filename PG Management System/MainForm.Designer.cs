namespace PG_Management_System
{
    partial class MainForm
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
            this.Button_FormClose = new System.Windows.Forms.Button();
            this.Button_FormMinimize = new System.Windows.Forms.Button();
            this.Button_Previous = new System.Windows.Forms.Button();
            this.Button_Home = new System.Windows.Forms.Button();
            this.Button_Settings = new System.Windows.Forms.Button();
            this.Label_FormTitle = new System.Windows.Forms.Label();
            this.Panel_MainPanel = new System.Windows.Forms.Panel();
            this.ComboBox_Buildings = new System.Windows.Forms.ComboBox();
            this.Button_FormMaximize = new System.Windows.Forms.Button();
            this.ComboBox_Floors = new System.Windows.Forms.ComboBox();
            this.ComboBox_Rooms = new System.Windows.Forms.ComboBox();
            this.Label_GuestFormDisplayController = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_FormClose
            // 
            this.Button_FormClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_FormClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_FormClose.FlatAppearance.BorderSize = 0;
            this.Button_FormClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_FormClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Button_FormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_FormClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_FormClose.Location = new System.Drawing.Point(1060, 0);
            this.Button_FormClose.Name = "Button_FormClose";
            this.Button_FormClose.Size = new System.Drawing.Size(20, 20);
            this.Button_FormClose.TabIndex = 8;
            this.Button_FormClose.TabStop = false;
            this.Button_FormClose.Text = "X";
            this.Button_FormClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_FormClose.UseVisualStyleBackColor = false;
            this.Button_FormClose.Click += new System.EventHandler(this.Button_FormClose_Click);
            // 
            // Button_FormMinimize
            // 
            this.Button_FormMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_FormMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_FormMinimize.FlatAppearance.BorderSize = 0;
            this.Button_FormMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_FormMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Button_FormMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_FormMinimize.Font = new System.Drawing.Font("Wide Latin", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_FormMinimize.Location = new System.Drawing.Point(1007, 0);
            this.Button_FormMinimize.Name = "Button_FormMinimize";
            this.Button_FormMinimize.Size = new System.Drawing.Size(20, 20);
            this.Button_FormMinimize.TabIndex = 9;
            this.Button_FormMinimize.TabStop = false;
            this.Button_FormMinimize.Text = "-";
            this.Button_FormMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_FormMinimize.UseVisualStyleBackColor = false;
            this.Button_FormMinimize.Click += new System.EventHandler(this.Button_FormMinimize_Click);
            // 
            // Button_Previous
            // 
            this.Button_Previous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Previous.FlatAppearance.BorderSize = 0;
            this.Button_Previous.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Previous.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Button_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Previous.Image = global::PG_Management_System.Properties.Resources.Previous;
            this.Button_Previous.Location = new System.Drawing.Point(86, 20);
            this.Button_Previous.Name = "Button_Previous";
            this.Button_Previous.Size = new System.Drawing.Size(20, 20);
            this.Button_Previous.TabIndex = 10;
            this.Button_Previous.TabStop = false;
            this.Button_Previous.UseVisualStyleBackColor = false;
            this.Button_Previous.Visible = false;
            this.Button_Previous.Click += new System.EventHandler(this.Button_Previous_Click);
            // 
            // Button_Home
            // 
            this.Button_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Home.FlatAppearance.BorderSize = 0;
            this.Button_Home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Button_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Home.Image = global::PG_Management_System.Properties.Resources.Home;
            this.Button_Home.Location = new System.Drawing.Point(50, 19);
            this.Button_Home.Name = "Button_Home";
            this.Button_Home.Size = new System.Drawing.Size(20, 20);
            this.Button_Home.TabIndex = 11;
            this.Button_Home.TabStop = false;
            this.Button_Home.UseVisualStyleBackColor = false;
            this.Button_Home.Visible = false;
            this.Button_Home.Click += new System.EventHandler(this.Button_Home_Click);
            // 
            // Button_Settings
            // 
            this.Button_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Settings.FlatAppearance.BorderSize = 0;
            this.Button_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Settings.Image = global::PG_Management_System.Properties.Resources.Settings;
            this.Button_Settings.Location = new System.Drawing.Point(1058, 20);
            this.Button_Settings.Name = "Button_Settings";
            this.Button_Settings.Size = new System.Drawing.Size(20, 20);
            this.Button_Settings.TabIndex = 9;
            this.Button_Settings.TabStop = false;
            this.Button_Settings.UseVisualStyleBackColor = false;
            // 
            // Label_FormTitle
            // 
            this.Label_FormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_FormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_FormTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_FormTitle.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FormTitle.Image = global::PG_Management_System.Properties.Resources.PGMS_32;
            this.Label_FormTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_FormTitle.Location = new System.Drawing.Point(0, 0);
            this.Label_FormTitle.Name = "Label_FormTitle";
            this.Label_FormTitle.Size = new System.Drawing.Size(1080, 40);
            this.Label_FormTitle.TabIndex = 7;
            this.Label_FormTitle.Text = "PGMS";
            this.Label_FormTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Panel_MainPanel
            // 
            this.Panel_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_MainPanel.Location = new System.Drawing.Point(0, 40);
            this.Panel_MainPanel.Name = "Panel_MainPanel";
            this.Panel_MainPanel.Size = new System.Drawing.Size(1080, 680);
            this.Panel_MainPanel.TabIndex = 0;
            // 
            // ComboBox_Buildings
            // 
            this.ComboBox_Buildings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ComboBox_Buildings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Buildings.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Buildings.FormattingEnabled = true;
            this.ComboBox_Buildings.Location = new System.Drawing.Point(127, 17);
            this.ComboBox_Buildings.Name = "ComboBox_Buildings";
            this.ComboBox_Buildings.Size = new System.Drawing.Size(158, 23);
            this.ComboBox_Buildings.Sorted = true;
            this.ComboBox_Buildings.TabIndex = 12;
            this.ComboBox_Buildings.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Buildings_SelectedIndexChanged);
            // 
            // Button_FormMaximize
            // 
            this.Button_FormMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_FormMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_FormMaximize.FlatAppearance.BorderSize = 0;
            this.Button_FormMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_FormMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Button_FormMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_FormMaximize.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Button_FormMaximize.Location = new System.Drawing.Point(1035, 0);
            this.Button_FormMaximize.Name = "Button_FormMaximize";
            this.Button_FormMaximize.Size = new System.Drawing.Size(20, 20);
            this.Button_FormMaximize.TabIndex = 13;
            this.Button_FormMaximize.TabStop = false;
            this.Button_FormMaximize.Text = "r";
            this.Button_FormMaximize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_FormMaximize.UseVisualStyleBackColor = false;
            this.Button_FormMaximize.Click += new System.EventHandler(this.Button_FormMaximize_Click);
            // 
            // ComboBox_Floors
            // 
            this.ComboBox_Floors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ComboBox_Floors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Floors.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Floors.FormattingEnabled = true;
            this.ComboBox_Floors.Location = new System.Drawing.Point(325, 17);
            this.ComboBox_Floors.Name = "ComboBox_Floors";
            this.ComboBox_Floors.Size = new System.Drawing.Size(158, 23);
            this.ComboBox_Floors.Sorted = true;
            this.ComboBox_Floors.TabIndex = 14;
            this.ComboBox_Floors.Visible = false;
            this.ComboBox_Floors.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Floors_SelectedIndexChanged);
            // 
            // ComboBox_Rooms
            // 
            this.ComboBox_Rooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ComboBox_Rooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Rooms.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Rooms.FormattingEnabled = true;
            this.ComboBox_Rooms.Location = new System.Drawing.Point(523, 16);
            this.ComboBox_Rooms.Name = "ComboBox_Rooms";
            this.ComboBox_Rooms.Size = new System.Drawing.Size(158, 23);
            this.ComboBox_Rooms.Sorted = true;
            this.ComboBox_Rooms.TabIndex = 15;
            this.ComboBox_Rooms.Visible = false;
            this.ComboBox_Rooms.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Rooms_SelectedIndexChanged);
            // 
            // Label_GuestFormDisplayController
            // 
            this.Label_GuestFormDisplayController.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_GuestFormDisplayController.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_GuestFormDisplayController.Enabled = false;
            this.Label_GuestFormDisplayController.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_GuestFormDisplayController.Location = new System.Drawing.Point(736, 20);
            this.Label_GuestFormDisplayController.Name = "Label_GuestFormDisplayController";
            this.Label_GuestFormDisplayController.Size = new System.Drawing.Size(136, 14);
            this.Label_GuestFormDisplayController.TabIndex = 16;
            this.Label_GuestFormDisplayController.Text = "GuestFormDisplayController";
            this.Label_GuestFormDisplayController.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.Label_GuestFormDisplayController);
            this.Controls.Add(this.ComboBox_Rooms);
            this.Controls.Add(this.ComboBox_Floors);
            this.Controls.Add(this.Button_FormMaximize);
            this.Controls.Add(this.ComboBox_Buildings);
            this.Controls.Add(this.Panel_MainPanel);
            this.Controls.Add(this.Button_Settings);
            this.Controls.Add(this.Button_FormClose);
            this.Controls.Add(this.Button_FormMinimize);
            this.Controls.Add(this.Button_Previous);
            this.Controls.Add(this.Button_Home);
            this.Controls.Add(this.Label_FormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PGMS";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_FormClose;
        private System.Windows.Forms.Button Button_FormMinimize;
        private System.Windows.Forms.Button Button_Previous;
        private System.Windows.Forms.Button Button_Home;
        private System.Windows.Forms.Button Button_Settings;
        private System.Windows.Forms.Label Label_FormTitle;
        private System.Windows.Forms.Panel Panel_MainPanel;
        private System.Windows.Forms.ComboBox ComboBox_Buildings;
        private System.Windows.Forms.Button Button_FormMaximize;
        private System.Windows.Forms.ComboBox ComboBox_Floors;
        private System.Windows.Forms.ComboBox ComboBox_Rooms;
        private System.Windows.Forms.Label Label_GuestFormDisplayController;
    }
}