namespace PG_Management_System
{
    partial class AddBuildingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBuildingForm));
            this.Button_FormMinimize = new System.Windows.Forms.Button();
            this.Button_FormClose = new System.Windows.Forms.Button();
            this.Button_Save = new System.Windows.Forms.Button();
            this.TextBox_BuildingName = new System.Windows.Forms.TextBox();
            this.ErrorProvider_AddBuildingForm = new System.Windows.Forms.ErrorProvider(this.components);
            this.Label_BuildingNameUnderbar = new System.Windows.Forms.Label();
            this.Label_BuildingIDUnderbar = new System.Windows.Forms.Label();
            this.Label_BuildingName = new System.Windows.Forms.Label();
            this.Label_BuildingID = new System.Windows.Forms.Label();
            this.TextBox_BuildingID = new System.Windows.Forms.TextBox();
            this.Label_FormTitle = new System.Windows.Forms.Label();
            this.PictureBox_BuildingImage = new System.Windows.Forms.PictureBox();
            this.ToolTip_AddBuidlingForm = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_AddBuildingForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_BuildingImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_FormMinimize
            // 
            this.Button_FormMinimize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_FormMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_FormMinimize.FlatAppearance.BorderSize = 0;
            this.Button_FormMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_FormMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Button_FormMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_FormMinimize.Font = new System.Drawing.Font("Wide Latin", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_FormMinimize.Location = new System.Drawing.Point(300, 0);
            this.Button_FormMinimize.Name = "Button_FormMinimize";
            this.Button_FormMinimize.Size = new System.Drawing.Size(20, 20);
            this.Button_FormMinimize.TabIndex = 27;
            this.Button_FormMinimize.TabStop = false;
            this.Button_FormMinimize.Text = "-";
            this.Button_FormMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_FormMinimize.UseVisualStyleBackColor = false;
            this.Button_FormMinimize.Click += new System.EventHandler(this.Button_FormMinimize_Click);
            // 
            // Button_FormClose
            // 
            this.Button_FormClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_FormClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_FormClose.FlatAppearance.BorderSize = 0;
            this.Button_FormClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_FormClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Button_FormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_FormClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_FormClose.Location = new System.Drawing.Point(320, 0);
            this.Button_FormClose.Name = "Button_FormClose";
            this.Button_FormClose.Size = new System.Drawing.Size(20, 20);
            this.Button_FormClose.TabIndex = 26;
            this.Button_FormClose.TabStop = false;
            this.Button_FormClose.Text = "X";
            this.Button_FormClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_FormClose.UseVisualStyleBackColor = false;
            this.Button_FormClose.Click += new System.EventHandler(this.Button_FormClose_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Save.BackColor = System.Drawing.Color.Transparent;
            this.Button_Save.Cursor = System.Windows.Forms.Cursors.Default;
            this.Button_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Save.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Save.Location = new System.Drawing.Point(126, 420);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(75, 30);
            this.Button_Save.TabIndex = 2;
            this.Button_Save.Text = "SAVE";
            this.Button_Save.UseVisualStyleBackColor = false;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // TextBox_BuildingName
            // 
            this.TextBox_BuildingName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_BuildingName.BackColor = System.Drawing.Color.LightGray;
            this.TextBox_BuildingName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_BuildingName.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_BuildingName.Location = new System.Drawing.Point(123, 355);
            this.TextBox_BuildingName.Name = "TextBox_BuildingName";
            this.TextBox_BuildingName.Size = new System.Drawing.Size(139, 16);
            this.TextBox_BuildingName.TabIndex = 1;
            // 
            // ErrorProvider_AddBuildingForm
            // 
            this.ErrorProvider_AddBuildingForm.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider_AddBuildingForm.ContainerControl = this;
            this.ErrorProvider_AddBuildingForm.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProvider_AddBuildingForm.Icon")));
            this.ErrorProvider_AddBuildingForm.RightToLeft = true;
            // 
            // Label_BuildingNameUnderbar
            // 
            this.Label_BuildingNameUnderbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_BuildingNameUnderbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_BuildingNameUnderbar.Location = new System.Drawing.Point(123, 374);
            this.Label_BuildingNameUnderbar.Name = "Label_BuildingNameUnderbar";
            this.Label_BuildingNameUnderbar.Size = new System.Drawing.Size(139, 1);
            this.Label_BuildingNameUnderbar.TabIndex = 31;
            // 
            // Label_BuildingIDUnderbar
            // 
            this.Label_BuildingIDUnderbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_BuildingIDUnderbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_BuildingIDUnderbar.Location = new System.Drawing.Point(123, 328);
            this.Label_BuildingIDUnderbar.Name = "Label_BuildingIDUnderbar";
            this.Label_BuildingIDUnderbar.Size = new System.Drawing.Size(139, 1);
            this.Label_BuildingIDUnderbar.TabIndex = 30;
            // 
            // Label_BuildingName
            // 
            this.Label_BuildingName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_BuildingName.AutoSize = true;
            this.Label_BuildingName.BackColor = System.Drawing.Color.Transparent;
            this.Label_BuildingName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_BuildingName.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BuildingName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_BuildingName.Location = new System.Drawing.Point(42, 352);
            this.Label_BuildingName.Name = "Label_BuildingName";
            this.Label_BuildingName.Size = new System.Drawing.Size(68, 22);
            this.Label_BuildingName.TabIndex = 19;
            this.Label_BuildingName.Text = "Name :";
            this.Label_BuildingName.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Label_BuildingID
            // 
            this.Label_BuildingID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_BuildingID.AutoSize = true;
            this.Label_BuildingID.BackColor = System.Drawing.Color.Transparent;
            this.Label_BuildingID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_BuildingID.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BuildingID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_BuildingID.Location = new System.Drawing.Point(74, 306);
            this.Label_BuildingID.Name = "Label_BuildingID";
            this.Label_BuildingID.Size = new System.Drawing.Size(38, 22);
            this.Label_BuildingID.TabIndex = 20;
            this.Label_BuildingID.Text = "ID :";
            this.Label_BuildingID.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // TextBox_BuildingID
            // 
            this.TextBox_BuildingID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_BuildingID.BackColor = System.Drawing.Color.LightGray;
            this.TextBox_BuildingID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_BuildingID.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_BuildingID.Location = new System.Drawing.Point(123, 309);
            this.TextBox_BuildingID.Name = "TextBox_BuildingID";
            this.TextBox_BuildingID.Size = new System.Drawing.Size(139, 16);
            this.TextBox_BuildingID.TabIndex = 0;
            // 
            // Label_FormTitle
            // 
            this.Label_FormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_FormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_FormTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_FormTitle.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FormTitle.Image = ((System.Drawing.Image)(resources.GetObject("Label_FormTitle.Image")));
            this.Label_FormTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Label_FormTitle.Location = new System.Drawing.Point(0, 0);
            this.Label_FormTitle.Name = "Label_FormTitle";
            this.Label_FormTitle.Size = new System.Drawing.Size(340, 20);
            this.Label_FormTitle.TabIndex = 25;
            this.Label_FormTitle.Text = "PGMS - Add Building";
            this.Label_FormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox_BuildingImage
            // 
            this.PictureBox_BuildingImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBox_BuildingImage.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_BuildingImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox_BuildingImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox_BuildingImage.Image = global::PG_Management_System.Properties.Resources.Add_Image;
            this.PictureBox_BuildingImage.Location = new System.Drawing.Point(61, 60);
            this.PictureBox_BuildingImage.Name = "PictureBox_BuildingImage";
            this.PictureBox_BuildingImage.Size = new System.Drawing.Size(219, 205);
            this.PictureBox_BuildingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_BuildingImage.TabIndex = 24;
            this.PictureBox_BuildingImage.TabStop = false;
            this.ToolTip_AddBuidlingForm.SetToolTip(this.PictureBox_BuildingImage, "Add Building Image");
            this.PictureBox_BuildingImage.Click += new System.EventHandler(this.PictureBox_BuildingImage_Click);
            // 
            // AddBuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(340, 475);
            this.ControlBox = false;
            this.Controls.Add(this.TextBox_BuildingID);
            this.Controls.Add(this.Button_FormMinimize);
            this.Controls.Add(this.Button_FormClose);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.TextBox_BuildingName);
            this.Controls.Add(this.Label_BuildingNameUnderbar);
            this.Controls.Add(this.Label_BuildingIDUnderbar);
            this.Controls.Add(this.Label_FormTitle);
            this.Controls.Add(this.PictureBox_BuildingImage);
            this.Controls.Add(this.Label_BuildingName);
            this.Controls.Add(this.Label_BuildingID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBuildingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddBuildingForm";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_AddBuildingForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_BuildingImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button_FormMinimize;
        private System.Windows.Forms.Button Button_FormClose;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.TextBox TextBox_BuildingName;
        private System.Windows.Forms.ErrorProvider ErrorProvider_AddBuildingForm;
        private System.Windows.Forms.Label Label_BuildingNameUnderbar;
        private System.Windows.Forms.Label Label_BuildingIDUnderbar;
        private System.Windows.Forms.Label Label_FormTitle;
        private System.Windows.Forms.PictureBox PictureBox_BuildingImage;
        private System.Windows.Forms.Label Label_BuildingName;
        private System.Windows.Forms.Label Label_BuildingID;
        private System.Windows.Forms.TextBox TextBox_BuildingID;
        private System.Windows.Forms.ToolTip ToolTip_AddBuidlingForm;
    }
}