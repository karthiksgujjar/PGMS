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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Button_FormClose = new System.Windows.Forms.Button();
            this.Button_FormMinimize = new System.Windows.Forms.Button();
            this.Label_Header = new System.Windows.Forms.Label();
            this.Panel_MainPanel = new System.Windows.Forms.Panel();
            this.ComboBox_Buildings = new System.Windows.Forms.ComboBox();
            this.Button_FormMaximize = new System.Windows.Forms.Button();
            this.ComboBox_Floors = new System.Windows.Forms.ComboBox();
            this.ComboBox_Rooms = new System.Windows.Forms.ComboBox();
            this.Label_GuestFormDisplayController = new System.Windows.Forms.Label();
            this.Label_DateTimeDisplay = new System.Windows.Forms.Label();
            this.Timer_TimeUpdaterMainForm = new System.Windows.Forms.Timer(this.components);
            this.Label_SidePanel = new System.Windows.Forms.Label();
            this.Button_AddRemoveBuildingData = new System.Windows.Forms.Button();
            this.Button_RemoveGuest = new System.Windows.Forms.Button();
            this.Button_GuestDetails = new System.Windows.Forms.Button();
            this.Button_AdmitGuest = new System.Windows.Forms.Button();
            this.Button_Logout = new System.Windows.Forms.Button();
            this.PictureBox_PGMSLogo = new System.Windows.Forms.PictureBox();
            this.Button_Settings = new System.Windows.Forms.Button();
            this.Button_Previous = new System.Windows.Forms.Button();
            this.Button_Home = new System.Windows.Forms.Button();
            this.Button_OverviewPG = new System.Windows.Forms.Button();
            this.Button_AcceptPayment = new System.Windows.Forms.Button();
            this.Button_Visitors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_PGMSLogo)).BeginInit();
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
            // Label_Header
            // 
            this.Label_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_Header.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Header.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_Header.Location = new System.Drawing.Point(0, 0);
            this.Label_Header.Name = "Label_Header";
            this.Label_Header.Size = new System.Drawing.Size(1080, 40);
            this.Label_Header.TabIndex = 7;
            this.Label_Header.Text = "PGMS";
            this.Label_Header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Panel_MainPanel
            // 
            this.Panel_MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_MainPanel.Location = new System.Drawing.Point(122, 40);
            this.Panel_MainPanel.Name = "Panel_MainPanel";
            this.Panel_MainPanel.Size = new System.Drawing.Size(958, 680);
            this.Panel_MainPanel.TabIndex = 0;
            // 
            // ComboBox_Buildings
            // 
            this.ComboBox_Buildings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ComboBox_Buildings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Buildings.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Buildings.FormattingEnabled = true;
            this.ComboBox_Buildings.Location = new System.Drawing.Point(127, 16);
            this.ComboBox_Buildings.Name = "ComboBox_Buildings";
            this.ComboBox_Buildings.Size = new System.Drawing.Size(158, 23);
            this.ComboBox_Buildings.Sorted = true;
            this.ComboBox_Buildings.TabIndex = 12;
            this.ComboBox_Buildings.Visible = false;
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
            this.ComboBox_Floors.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Floors.FormattingEnabled = true;
            this.ComboBox_Floors.Location = new System.Drawing.Point(325, 16);
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
            this.ComboBox_Rooms.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Label_GuestFormDisplayController.Location = new System.Drawing.Point(813, 4);
            this.Label_GuestFormDisplayController.Name = "Label_GuestFormDisplayController";
            this.Label_GuestFormDisplayController.Size = new System.Drawing.Size(136, 14);
            this.Label_GuestFormDisplayController.TabIndex = 16;
            this.Label_GuestFormDisplayController.Text = "GuestFormDisplayController";
            this.Label_GuestFormDisplayController.Visible = false;
            // 
            // Label_DateTimeDisplay
            // 
            this.Label_DateTimeDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_DateTimeDisplay.AutoSize = true;
            this.Label_DateTimeDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_DateTimeDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_DateTimeDisplay.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DateTimeDisplay.Location = new System.Drawing.Point(813, 22);
            this.Label_DateTimeDisplay.Name = "Label_DateTimeDisplay";
            this.Label_DateTimeDisplay.Size = new System.Drawing.Size(111, 15);
            this.Label_DateTimeDisplay.TabIndex = 17;
            this.Label_DateTimeDisplay.Text = "DateTimeDisplay";
            // 
            // Timer_TimeUpdaterMainForm
            // 
            this.Timer_TimeUpdaterMainForm.Interval = 60000;
            this.Timer_TimeUpdaterMainForm.Tick += new System.EventHandler(this.Timer_TimeUpdaterMainForm_Tick);
            // 
            // Label_SidePanel
            // 
            this.Label_SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_SidePanel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Label_SidePanel.Location = new System.Drawing.Point(0, 40);
            this.Label_SidePanel.Name = "Label_SidePanel";
            this.Label_SidePanel.Size = new System.Drawing.Size(121, 680);
            this.Label_SidePanel.TabIndex = 18;
            // 
            // Button_AddRemoveBuildingData
            // 
            this.Button_AddRemoveBuildingData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_AddRemoveBuildingData.FlatAppearance.BorderSize = 0;
            this.Button_AddRemoveBuildingData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_AddRemoveBuildingData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Button_AddRemoveBuildingData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_AddRemoveBuildingData.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AddRemoveBuildingData.Location = new System.Drawing.Point(2, 329);
            this.Button_AddRemoveBuildingData.Name = "Button_AddRemoveBuildingData";
            this.Button_AddRemoveBuildingData.Size = new System.Drawing.Size(117, 51);
            this.Button_AddRemoveBuildingData.TabIndex = 1;
            this.Button_AddRemoveBuildingData.Text = "Add / Remove\r\nBuilding";
            this.Button_AddRemoveBuildingData.UseVisualStyleBackColor = false;
            this.Button_AddRemoveBuildingData.Click += new System.EventHandler(this.Button_AddRemoveBuildingData_Click);
            // 
            // Button_RemoveGuest
            // 
            this.Button_RemoveGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_RemoveGuest.FlatAppearance.BorderSize = 0;
            this.Button_RemoveGuest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_RemoveGuest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Button_RemoveGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_RemoveGuest.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_RemoveGuest.Location = new System.Drawing.Point(2, 526);
            this.Button_RemoveGuest.Name = "Button_RemoveGuest";
            this.Button_RemoveGuest.Size = new System.Drawing.Size(117, 25);
            this.Button_RemoveGuest.TabIndex = 4;
            this.Button_RemoveGuest.Text = "Remove Guest";
            this.Button_RemoveGuest.UseVisualStyleBackColor = false;
            this.Button_RemoveGuest.Click += new System.EventHandler(this.Button_RemoveGuest_Click);
            // 
            // Button_GuestDetails
            // 
            this.Button_GuestDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_GuestDetails.FlatAppearance.BorderSize = 0;
            this.Button_GuestDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_GuestDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Button_GuestDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_GuestDetails.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_GuestDetails.Location = new System.Drawing.Point(2, 469);
            this.Button_GuestDetails.Name = "Button_GuestDetails";
            this.Button_GuestDetails.Size = new System.Drawing.Size(117, 25);
            this.Button_GuestDetails.TabIndex = 3;
            this.Button_GuestDetails.Text = "Guests Details";
            this.Button_GuestDetails.UseVisualStyleBackColor = false;
            this.Button_GuestDetails.Click += new System.EventHandler(this.Button_GuestDetails_Click);
            // 
            // Button_AdmitGuest
            // 
            this.Button_AdmitGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_AdmitGuest.FlatAppearance.BorderSize = 0;
            this.Button_AdmitGuest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_AdmitGuest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Button_AdmitGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_AdmitGuest.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AdmitGuest.Location = new System.Drawing.Point(2, 412);
            this.Button_AdmitGuest.Name = "Button_AdmitGuest";
            this.Button_AdmitGuest.Size = new System.Drawing.Size(117, 25);
            this.Button_AdmitGuest.TabIndex = 2;
            this.Button_AdmitGuest.Text = "Admit Guest";
            this.Button_AdmitGuest.UseVisualStyleBackColor = false;
            this.Button_AdmitGuest.Click += new System.EventHandler(this.Button_AdmitGuest_Click);
            // 
            // Button_Logout
            // 
            this.Button_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Logout.FlatAppearance.BorderSize = 0;
            this.Button_Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Logout.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Logout.Image = global::PG_Management_System.Properties.Resources.Logout;
            this.Button_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Logout.Location = new System.Drawing.Point(2, 668);
            this.Button_Logout.Name = "Button_Logout";
            this.Button_Logout.Size = new System.Drawing.Size(117, 28);
            this.Button_Logout.TabIndex = 5;
            this.Button_Logout.Text = "Log Out";
            this.Button_Logout.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Button_Logout.UseVisualStyleBackColor = false;
            this.Button_Logout.Click += new System.EventHandler(this.Button_Logout_Click);
            // 
            // PictureBox_PGMSLogo
            // 
            this.PictureBox_PGMSLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PictureBox_PGMSLogo.Image = global::PG_Management_System.Properties.Resources.PGMS_Logo;
            this.PictureBox_PGMSLogo.Location = new System.Drawing.Point(3, 57);
            this.PictureBox_PGMSLogo.Name = "PictureBox_PGMSLogo";
            this.PictureBox_PGMSLogo.Size = new System.Drawing.Size(116, 117);
            this.PictureBox_PGMSLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_PGMSLogo.TabIndex = 19;
            this.PictureBox_PGMSLogo.TabStop = false;
            // 
            // Button_Settings
            // 
            this.Button_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Settings.FlatAppearance.BorderSize = 0;
            this.Button_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Settings.Image = global::PG_Management_System.Properties.Resources.Settings;
            this.Button_Settings.Location = new System.Drawing.Point(12, 18);
            this.Button_Settings.Name = "Button_Settings";
            this.Button_Settings.Size = new System.Drawing.Size(20, 20);
            this.Button_Settings.TabIndex = 9;
            this.Button_Settings.TabStop = false;
            this.Button_Settings.UseVisualStyleBackColor = false;
            this.Button_Settings.Click += new System.EventHandler(this.Button_Settings_Click);
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
            this.Button_Previous.Location = new System.Drawing.Point(100, 19);
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
            this.Button_Home.Location = new System.Drawing.Point(56, 18);
            this.Button_Home.Name = "Button_Home";
            this.Button_Home.Size = new System.Drawing.Size(20, 20);
            this.Button_Home.TabIndex = 11;
            this.Button_Home.TabStop = false;
            this.Button_Home.UseVisualStyleBackColor = false;
            this.Button_Home.Visible = false;
            this.Button_Home.Click += new System.EventHandler(this.Button_Home_Click);
            // 
            // Button_OverviewPG
            // 
            this.Button_OverviewPG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_OverviewPG.FlatAppearance.BorderSize = 0;
            this.Button_OverviewPG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_OverviewPG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Button_OverviewPG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_OverviewPG.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_OverviewPG.Location = new System.Drawing.Point(2, 197);
            this.Button_OverviewPG.Name = "Button_OverviewPG";
            this.Button_OverviewPG.Size = new System.Drawing.Size(117, 25);
            this.Button_OverviewPG.TabIndex = 0;
            this.Button_OverviewPG.Text = "Overview PG";
            this.Button_OverviewPG.UseVisualStyleBackColor = false;
            this.Button_OverviewPG.Click += new System.EventHandler(this.Button_OverviewPG_Click);
            // 
            // Button_AcceptPayment
            // 
            this.Button_AcceptPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_AcceptPayment.FlatAppearance.BorderSize = 0;
            this.Button_AcceptPayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_AcceptPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Button_AcceptPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_AcceptPayment.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AcceptPayment.Location = new System.Drawing.Point(2, 254);
            this.Button_AcceptPayment.Name = "Button_AcceptPayment";
            this.Button_AcceptPayment.Size = new System.Drawing.Size(117, 43);
            this.Button_AcceptPayment.TabIndex = 20;
            this.Button_AcceptPayment.Text = "Accept Payment";
            this.Button_AcceptPayment.UseVisualStyleBackColor = false;
            this.Button_AcceptPayment.Click += new System.EventHandler(this.Button_AcceptPayment_Click);
            // 
            // Button_Visitors
            // 
            this.Button_Visitors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Visitors.FlatAppearance.BorderSize = 0;
            this.Button_Visitors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Visitors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Button_Visitors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Visitors.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Visitors.Location = new System.Drawing.Point(2, 583);
            this.Button_Visitors.Name = "Button_Visitors";
            this.Button_Visitors.Size = new System.Drawing.Size(117, 25);
            this.Button_Visitors.TabIndex = 21;
            this.Button_Visitors.Text = "Visitors";
            this.Button_Visitors.UseVisualStyleBackColor = false;
            this.Button_Visitors.Click += new System.EventHandler(this.Button_Visitors_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.Button_Visitors);
            this.Controls.Add(this.Button_AcceptPayment);
            this.Controls.Add(this.Button_OverviewPG);
            this.Controls.Add(this.Button_Logout);
            this.Controls.Add(this.Button_GuestDetails);
            this.Controls.Add(this.Button_RemoveGuest);
            this.Controls.Add(this.Button_AdmitGuest);
            this.Controls.Add(this.Button_AddRemoveBuildingData);
            this.Controls.Add(this.PictureBox_PGMSLogo);
            this.Controls.Add(this.Label_SidePanel);
            this.Controls.Add(this.Label_DateTimeDisplay);
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
            this.Controls.Add(this.Label_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PGMS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_PGMSLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_FormClose;
        private System.Windows.Forms.Button Button_FormMinimize;
        private System.Windows.Forms.Button Button_Previous;
        private System.Windows.Forms.Button Button_Home;
        private System.Windows.Forms.Button Button_Settings;
        private System.Windows.Forms.Label Label_Header;
        private System.Windows.Forms.Panel Panel_MainPanel;
        private System.Windows.Forms.ComboBox ComboBox_Buildings;
        private System.Windows.Forms.Button Button_FormMaximize;
        private System.Windows.Forms.ComboBox ComboBox_Floors;
        private System.Windows.Forms.ComboBox ComboBox_Rooms;
        private System.Windows.Forms.Label Label_GuestFormDisplayController;
        private System.Windows.Forms.Label Label_DateTimeDisplay;
        private System.Windows.Forms.Timer Timer_TimeUpdaterMainForm;
        private System.Windows.Forms.Label Label_SidePanel;
        private System.Windows.Forms.PictureBox PictureBox_PGMSLogo;
        private System.Windows.Forms.Button Button_AddRemoveBuildingData;
        private System.Windows.Forms.Button Button_RemoveGuest;
        private System.Windows.Forms.Button Button_GuestDetails;
        private System.Windows.Forms.Button Button_AdmitGuest;
        private System.Windows.Forms.Button Button_Logout;
        private System.Windows.Forms.Button Button_OverviewPG;
        private System.Windows.Forms.Button Button_AcceptPayment;
        private System.Windows.Forms.Button Button_Visitors;
    }
}