namespace PG_Management_System
{
    partial class AddFloorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFloorForm));
            this.Button_FormMinimize = new System.Windows.Forms.Button();
            this.Button_FormClose = new System.Windows.Forms.Button();
            this.Label_FormTitle = new System.Windows.Forms.Label();
            this.ToolTip_AddFloorForm = new System.Windows.Forms.ToolTip(this.components);
            this.TextBox_FloorID = new System.Windows.Forms.TextBox();
            this.Button_Save = new System.Windows.Forms.Button();
            this.TextBox_FloorName = new System.Windows.Forms.TextBox();
            this.Label_FloorNameUnderbar = new System.Windows.Forms.Label();
            this.Label_FloorDUnderbar = new System.Windows.Forms.Label();
            this.PictureBox_FloorImage = new System.Windows.Forms.PictureBox();
            this.Label_FloorName = new System.Windows.Forms.Label();
            this.Label_FloorID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_FloorImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_FormMinimize
            // 
            this.Button_FormMinimize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_FormMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_FormMinimize.FlatAppearance.BorderSize = 0;
            this.Button_FormMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_FormMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Button_FormMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_FormMinimize.Font = new System.Drawing.Font("Wide Latin", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_FormMinimize.Location = new System.Drawing.Point(300, 0);
            this.Button_FormMinimize.Name = "Button_FormMinimize";
            this.Button_FormMinimize.Size = new System.Drawing.Size(20, 20);
            this.Button_FormMinimize.TabIndex = 40;
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
            this.Button_FormClose.TabIndex = 39;
            this.Button_FormClose.TabStop = false;
            this.Button_FormClose.Text = "X";
            this.Button_FormClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_FormClose.UseVisualStyleBackColor = false;
            this.Button_FormClose.Click += new System.EventHandler(this.Button_FormClose_Click);
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
            this.Label_FormTitle.TabIndex = 38;
            this.Label_FormTitle.Text = "PGMS - Add Floor";
            this.Label_FormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox_FloorID
            // 
            this.TextBox_FloorID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_FloorID.BackColor = System.Drawing.Color.LightGray;
            this.TextBox_FloorID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_FloorID.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_FloorID.Location = new System.Drawing.Point(123, 311);
            this.TextBox_FloorID.Name = "TextBox_FloorID";
            this.TextBox_FloorID.Size = new System.Drawing.Size(139, 16);
            this.TextBox_FloorID.TabIndex = 41;
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
            this.Button_Save.TabIndex = 43;
            this.Button_Save.Text = "SAVE";
            this.Button_Save.UseVisualStyleBackColor = false;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // TextBox_FloorName
            // 
            this.TextBox_FloorName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_FloorName.BackColor = System.Drawing.Color.LightGray;
            this.TextBox_FloorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_FloorName.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_FloorName.Location = new System.Drawing.Point(123, 357);
            this.TextBox_FloorName.Name = "TextBox_FloorName";
            this.TextBox_FloorName.Size = new System.Drawing.Size(139, 16);
            this.TextBox_FloorName.TabIndex = 42;
            // 
            // Label_FloorNameUnderbar
            // 
            this.Label_FloorNameUnderbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_FloorNameUnderbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_FloorNameUnderbar.Location = new System.Drawing.Point(123, 376);
            this.Label_FloorNameUnderbar.Name = "Label_FloorNameUnderbar";
            this.Label_FloorNameUnderbar.Size = new System.Drawing.Size(139, 1);
            this.Label_FloorNameUnderbar.TabIndex = 48;
            // 
            // Label_FloorDUnderbar
            // 
            this.Label_FloorDUnderbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_FloorDUnderbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_FloorDUnderbar.Location = new System.Drawing.Point(123, 330);
            this.Label_FloorDUnderbar.Name = "Label_FloorDUnderbar";
            this.Label_FloorDUnderbar.Size = new System.Drawing.Size(139, 1);
            this.Label_FloorDUnderbar.TabIndex = 47;
            // 
            // PictureBox_FloorImage
            // 
            this.PictureBox_FloorImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBox_FloorImage.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_FloorImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox_FloorImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox_FloorImage.Image = global::PG_Management_System.Properties.Resources.Add_Image;
            this.PictureBox_FloorImage.Location = new System.Drawing.Point(60, 60);
            this.PictureBox_FloorImage.Name = "PictureBox_FloorImage";
            this.PictureBox_FloorImage.Size = new System.Drawing.Size(219, 205);
            this.PictureBox_FloorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_FloorImage.TabIndex = 46;
            this.PictureBox_FloorImage.TabStop = false;
            this.PictureBox_FloorImage.Click += new System.EventHandler(this.PictureBox_FloorImage_Click);
            // 
            // Label_FloorName
            // 
            this.Label_FloorName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_FloorName.AutoSize = true;
            this.Label_FloorName.BackColor = System.Drawing.Color.Transparent;
            this.Label_FloorName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_FloorName.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FloorName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_FloorName.Location = new System.Drawing.Point(42, 352);
            this.Label_FloorName.Name = "Label_FloorName";
            this.Label_FloorName.Size = new System.Drawing.Size(68, 22);
            this.Label_FloorName.TabIndex = 44;
            this.Label_FloorName.Text = "Name :";
            this.Label_FloorName.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Label_FloorID
            // 
            this.Label_FloorID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_FloorID.AutoSize = true;
            this.Label_FloorID.BackColor = System.Drawing.Color.Transparent;
            this.Label_FloorID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_FloorID.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FloorID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_FloorID.Location = new System.Drawing.Point(74, 306);
            this.Label_FloorID.Name = "Label_FloorID";
            this.Label_FloorID.Size = new System.Drawing.Size(38, 22);
            this.Label_FloorID.TabIndex = 45;
            this.Label_FloorID.Text = "ID :";
            this.Label_FloorID.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // AddFloorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(340, 475);
            this.ControlBox = false;
            this.Controls.Add(this.TextBox_FloorID);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.TextBox_FloorName);
            this.Controls.Add(this.Label_FloorNameUnderbar);
            this.Controls.Add(this.Label_FloorDUnderbar);
            this.Controls.Add(this.PictureBox_FloorImage);
            this.Controls.Add(this.Label_FloorName);
            this.Controls.Add(this.Label_FloorID);
            this.Controls.Add(this.Button_FormMinimize);
            this.Controls.Add(this.Button_FormClose);
            this.Controls.Add(this.Label_FormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFloorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddFloorForm";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_FloorImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button_FormMinimize;
        private System.Windows.Forms.Button Button_FormClose;
        private System.Windows.Forms.Label Label_FormTitle;
        private System.Windows.Forms.ToolTip ToolTip_AddFloorForm;
        private System.Windows.Forms.TextBox TextBox_FloorID;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.TextBox TextBox_FloorName;
        private System.Windows.Forms.Label Label_FloorNameUnderbar;
        private System.Windows.Forms.Label Label_FloorDUnderbar;
        private System.Windows.Forms.PictureBox PictureBox_FloorImage;
        private System.Windows.Forms.Label Label_FloorName;
        private System.Windows.Forms.Label Label_FloorID;
    }
}