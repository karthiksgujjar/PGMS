﻿namespace PG_Management_System
{
    partial class BuidlingsForm
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
            this.Button_AddBuilding = new System.Windows.Forms.Button();
            this.Label_BUILDINGS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_AddBuilding
            // 
            this.Button_AddBuilding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_AddBuilding.FlatAppearance.BorderSize = 0;
            this.Button_AddBuilding.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_AddBuilding.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AddBuilding.Location = new System.Drawing.Point(750, 400);
            this.Button_AddBuilding.Name = "Button_AddBuilding";
            this.Button_AddBuilding.Size = new System.Drawing.Size(38, 38);
            this.Button_AddBuilding.TabIndex = 4;
            this.Button_AddBuilding.Text = "+";
            this.Button_AddBuilding.UseVisualStyleBackColor = true;
            // 
            // Label_BUILDINGS
            // 
            this.Label_BUILDINGS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_BUILDINGS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_BUILDINGS.Font = new System.Drawing.Font("Cambria", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BUILDINGS.Location = new System.Drawing.Point(224, 9);
            this.Label_BUILDINGS.Name = "Label_BUILDINGS";
            this.Label_BUILDINGS.Size = new System.Drawing.Size(352, 70);
            this.Label_BUILDINGS.TabIndex = 5;
            this.Label_BUILDINGS.Text = "BUILDINGS";
            this.Label_BUILDINGS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BuidlingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_BUILDINGS);
            this.Controls.Add(this.Button_AddBuilding);
            this.Name = "BuidlingsForm";
            this.Text = "PGMS - Buidlings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_AddBuilding;
        private System.Windows.Forms.Label Label_BUILDINGS;
    }
}