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
            this.Button_FormMinimize = new System.Windows.Forms.Button();
            this.Button_FormClose = new System.Windows.Forms.Button();
            this.Panel_HeaderPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Button_Previous = new System.Windows.Forms.Button();
            this.Panel_MainPanel = new System.Windows.Forms.Panel();
            this.Button_Home = new System.Windows.Forms.Button();
            this.Label_FormTitle = new System.Windows.Forms.Label();
            this.Panel_HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_FormMinimize
            // 
            this.Button_FormMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_FormMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_FormMinimize.FlatAppearance.BorderSize = 0;
            this.Button_FormMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_FormMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Button_FormMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_FormMinimize.Font = new System.Drawing.Font("Wide Latin", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_FormMinimize.Location = new System.Drawing.Point(760, 0);
            this.Button_FormMinimize.Name = "Button_FormMinimize";
            this.Button_FormMinimize.Size = new System.Drawing.Size(20, 20);
            this.Button_FormMinimize.TabIndex = 9;
            this.Button_FormMinimize.TabStop = false;
            this.Button_FormMinimize.Text = "-";
            this.Button_FormMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_FormMinimize.UseVisualStyleBackColor = false;
            this.Button_FormMinimize.Click += new System.EventHandler(this.Button_FormMinimize_Click);
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
            this.Button_FormClose.Location = new System.Drawing.Point(780, 0);
            this.Button_FormClose.Name = "Button_FormClose";
            this.Button_FormClose.Size = new System.Drawing.Size(20, 20);
            this.Button_FormClose.TabIndex = 8;
            this.Button_FormClose.TabStop = false;
            this.Button_FormClose.Text = "X";
            this.Button_FormClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_FormClose.UseVisualStyleBackColor = false;
            this.Button_FormClose.Click += new System.EventHandler(this.Button_FormClose_Click);
            // 
            // Panel_HeaderPanel
            // 
            this.Panel_HeaderPanel.BackColor = System.Drawing.Color.Transparent;
            this.Panel_HeaderPanel.Controls.Add(this.button1);
            this.Panel_HeaderPanel.Controls.Add(this.Button_Previous);
            this.Panel_HeaderPanel.Controls.Add(this.Button_Home);
            this.Panel_HeaderPanel.Controls.Add(this.Button_FormClose);
            this.Panel_HeaderPanel.Controls.Add(this.Button_FormMinimize);
            this.Panel_HeaderPanel.Controls.Add(this.Label_FormTitle);
            this.Panel_HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.Panel_HeaderPanel.Name = "Panel_HeaderPanel";
            this.Panel_HeaderPanel.Size = new System.Drawing.Size(800, 40);
            this.Panel_HeaderPanel.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::PG_Management_System.Properties.Resources.Settings;
            this.button1.Location = new System.Drawing.Point(778, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 9;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
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
            this.Button_Previous.Location = new System.Drawing.Point(95, 20);
            this.Button_Previous.Name = "Button_Previous";
            this.Button_Previous.Size = new System.Drawing.Size(20, 20);
            this.Button_Previous.TabIndex = 10;
            this.Button_Previous.TabStop = false;
            this.Button_Previous.UseVisualStyleBackColor = false;
            this.Button_Previous.Visible = false;
            // 
            // Panel_MainPanel
            // 
            this.Panel_MainPanel.BackColor = System.Drawing.Color.White;
            this.Panel_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_MainPanel.Location = new System.Drawing.Point(0, 40);
            this.Panel_MainPanel.Name = "Panel_MainPanel";
            this.Panel_MainPanel.Size = new System.Drawing.Size(800, 410);
            this.Panel_MainPanel.TabIndex = 12;
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
            this.Button_Home.Location = new System.Drawing.Point(57, 20);
            this.Button_Home.Name = "Button_Home";
            this.Button_Home.Size = new System.Drawing.Size(20, 20);
            this.Button_Home.TabIndex = 11;
            this.Button_Home.TabStop = false;
            this.Button_Home.UseVisualStyleBackColor = false;
            this.Button_Home.Visible = false;
            // 
            // Label_FormTitle
            // 
            this.Label_FormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_FormTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_FormTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_FormTitle.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FormTitle.Image = global::PG_Management_System.Properties.Resources.PGMS_32;
            this.Label_FormTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_FormTitle.Location = new System.Drawing.Point(0, 0);
            this.Label_FormTitle.Name = "Label_FormTitle";
            this.Label_FormTitle.Size = new System.Drawing.Size(800, 40);
            this.Label_FormTitle.TabIndex = 7;
            this.Label_FormTitle.Text = "PGMS";
            this.Label_FormTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Panel_MainPanel);
            this.Controls.Add(this.Panel_HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PGMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Panel_HeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_FormMinimize;
        private System.Windows.Forms.Button Button_FormClose;
        private System.Windows.Forms.Label Label_FormTitle;
        private System.Windows.Forms.Panel Panel_HeaderPanel;
        private System.Windows.Forms.Panel Panel_MainPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Button_Previous;
        private System.Windows.Forms.Button Button_Home;
    }
}