namespace PG_Management_System
{
    partial class GuestDetailsForm
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
            this.ComboBox_Buildings = new System.Windows.Forms.ComboBox();
            this.TableLayout_GuestDetails = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // ComboBox_Buildings
            // 
            this.ComboBox_Buildings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ComboBox_Buildings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Buildings.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Buildings.FormattingEnabled = true;
            this.ComboBox_Buildings.Location = new System.Drawing.Point(12, 12);
            this.ComboBox_Buildings.Name = "ComboBox_Buildings";
            this.ComboBox_Buildings.Size = new System.Drawing.Size(158, 23);
            this.ComboBox_Buildings.Sorted = true;
            this.ComboBox_Buildings.TabIndex = 13;
            this.ComboBox_Buildings.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Buildings_SelectedIndexChanged);
            // 
            // TableLayout_GuestDetails
            // 
            this.TableLayout_GuestDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayout_GuestDetails.AutoScroll = true;
            this.TableLayout_GuestDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayout_GuestDetails.BackColor = System.Drawing.Color.Transparent;
            this.TableLayout_GuestDetails.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TableLayout_GuestDetails.ColumnCount = 4;
            this.TableLayout_GuestDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayout_GuestDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayout_GuestDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayout_GuestDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayout_GuestDetails.Location = new System.Drawing.Point(12, 57);
            this.TableLayout_GuestDetails.Name = "TableLayout_GuestDetails";
            this.TableLayout_GuestDetails.RowCount = 1;
            this.TableLayout_GuestDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayout_GuestDetails.Size = new System.Drawing.Size(773, 364);
            this.TableLayout_GuestDetails.TabIndex = 14;
            this.TableLayout_GuestDetails.Visible = false;
            // 
            // GuestDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableLayout_GuestDetails);
            this.Controls.Add(this.ComboBox_Buildings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuestDetailsForm";
            this.Text = "GuestDetailsForm";
            this.Load += new System.EventHandler(this.GuestDetailsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox_Buildings;
        private System.Windows.Forms.TableLayoutPanel TableLayout_GuestDetails;
    }
}