namespace PG_Management_System
{
    partial class AcceptPaymentForm
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
            this.ComboBox_Guests = new System.Windows.Forms.ComboBox();
            this.ComboBox_Rooms = new System.Windows.Forms.ComboBox();
            this.ComboBox_Floors = new System.Windows.Forms.ComboBox();
            this.ComboBox_Buildings = new System.Windows.Forms.ComboBox();
            this.Label_PGAddress = new System.Windows.Forms.Label();
            this.Label_PGName = new System.Windows.Forms.Label();
            this.Label_ReceiptNoTitle = new System.Windows.Forms.Label();
            this.Label_RECEIPTTitle = new System.Windows.Forms.Label();
            this.Label_DateTitle = new System.Windows.Forms.Label();
            this.Label_TitleSeparator = new System.Windows.Forms.Label();
            this.Label_ReceiptNo = new System.Windows.Forms.Label();
            this.Label_ReceiptContent = new System.Windows.Forms.Label();
            this.Button_ResetGuestPaymentForm = new System.Windows.Forms.Button();
            this.Button_ShareGuestPaymentReceipt = new System.Windows.Forms.Button();
            this.Button_AcceptGuestPayment = new System.Windows.Forms.Button();
            this.TextBox_GuestName = new System.Windows.Forms.TextBox();
            this.TextBox_GuestPayAmountPerMonth = new System.Windows.Forms.TextBox();
            this.TextBox_CurrentMonth = new System.Windows.Forms.TextBox();
            this.Label_CurrentDate = new System.Windows.Forms.Label();
            this.RadioButton_Cash = new System.Windows.Forms.RadioButton();
            this.RadioButton_UPI = new System.Windows.Forms.RadioButton();
            this.TextBox_UPI_ID = new System.Windows.Forms.TextBox();
            this.Label_UPI_ID_Underbar = new System.Windows.Forms.Label();
            this.Label_UPI_ID_Title = new System.Windows.Forms.Label();
            this.Button_ReceiptPrint = new System.Windows.Forms.Button();
            this.Button_ReceiptMail = new System.Windows.Forms.Button();
            this.ComboBox_Printers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ComboBox_Guests
            // 
            this.ComboBox_Guests.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboBox_Guests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ComboBox_Guests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Guests.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Guests.FormattingEnabled = true;
            this.ComboBox_Guests.Location = new System.Drawing.Point(625, 12);
            this.ComboBox_Guests.Name = "ComboBox_Guests";
            this.ComboBox_Guests.Size = new System.Drawing.Size(158, 23);
            this.ComboBox_Guests.Sorted = true;
            this.ComboBox_Guests.TabIndex = 3;
            this.ComboBox_Guests.Visible = false;
            this.ComboBox_Guests.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Guests_SelectedIndexChanged);
            // 
            // ComboBox_Rooms
            // 
            this.ComboBox_Rooms.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboBox_Rooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ComboBox_Rooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Rooms.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Rooms.FormattingEnabled = true;
            this.ComboBox_Rooms.Location = new System.Drawing.Point(435, 12);
            this.ComboBox_Rooms.Name = "ComboBox_Rooms";
            this.ComboBox_Rooms.Size = new System.Drawing.Size(158, 23);
            this.ComboBox_Rooms.Sorted = true;
            this.ComboBox_Rooms.TabIndex = 2;
            this.ComboBox_Rooms.Visible = false;
            this.ComboBox_Rooms.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Rooms_SelectedIndexChanged);
            // 
            // ComboBox_Floors
            // 
            this.ComboBox_Floors.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboBox_Floors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ComboBox_Floors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Floors.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Floors.FormattingEnabled = true;
            this.ComboBox_Floors.Location = new System.Drawing.Point(245, 12);
            this.ComboBox_Floors.Name = "ComboBox_Floors";
            this.ComboBox_Floors.Size = new System.Drawing.Size(158, 23);
            this.ComboBox_Floors.Sorted = true;
            this.ComboBox_Floors.TabIndex = 1;
            this.ComboBox_Floors.Visible = false;
            this.ComboBox_Floors.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Floors_SelectedIndexChanged);
            // 
            // ComboBox_Buildings
            // 
            this.ComboBox_Buildings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboBox_Buildings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ComboBox_Buildings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Buildings.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Buildings.FormattingEnabled = true;
            this.ComboBox_Buildings.Location = new System.Drawing.Point(55, 12);
            this.ComboBox_Buildings.Name = "ComboBox_Buildings";
            this.ComboBox_Buildings.Size = new System.Drawing.Size(158, 23);
            this.ComboBox_Buildings.Sorted = true;
            this.ComboBox_Buildings.TabIndex = 0;
            this.ComboBox_Buildings.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Buildings_SelectedIndexChanged);
            // 
            // Label_PGAddress
            // 
            this.Label_PGAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_PGAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_PGAddress.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PGAddress.Location = new System.Drawing.Point(16, 99);
            this.Label_PGAddress.Name = "Label_PGAddress";
            this.Label_PGAddress.Size = new System.Drawing.Size(828, 25);
            this.Label_PGAddress.TabIndex = 76;
            this.Label_PGAddress.Text = "PG Address";
            this.Label_PGAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_PGName
            // 
            this.Label_PGName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_PGName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_PGName.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PGName.Location = new System.Drawing.Point(23, 55);
            this.Label_PGName.Name = "Label_PGName";
            this.Label_PGName.Size = new System.Drawing.Size(814, 28);
            this.Label_PGName.TabIndex = 75;
            this.Label_PGName.Text = "PG Name";
            this.Label_PGName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_ReceiptNoTitle
            // 
            this.Label_ReceiptNoTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_ReceiptNoTitle.AutoSize = true;
            this.Label_ReceiptNoTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_ReceiptNoTitle.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ReceiptNoTitle.Location = new System.Drawing.Point(12, 149);
            this.Label_ReceiptNoTitle.Name = "Label_ReceiptNoTitle";
            this.Label_ReceiptNoTitle.Size = new System.Drawing.Size(110, 22);
            this.Label_ReceiptNoTitle.TabIndex = 77;
            this.Label_ReceiptNoTitle.Text = "Receipt No. :";
            this.Label_ReceiptNoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_RECEIPTTitle
            // 
            this.Label_RECEIPTTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_RECEIPTTitle.AutoSize = true;
            this.Label_RECEIPTTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_RECEIPTTitle.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RECEIPTTitle.Location = new System.Drawing.Point(387, 143);
            this.Label_RECEIPTTitle.Name = "Label_RECEIPTTitle";
            this.Label_RECEIPTTitle.Size = new System.Drawing.Size(83, 22);
            this.Label_RECEIPTTitle.TabIndex = 78;
            this.Label_RECEIPTTitle.Text = "RECEIPT";
            this.Label_RECEIPTTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_DateTitle
            // 
            this.Label_DateTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_DateTitle.AutoSize = true;
            this.Label_DateTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_DateTitle.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DateTitle.Location = new System.Drawing.Point(657, 148);
            this.Label_DateTitle.Name = "Label_DateTitle";
            this.Label_DateTitle.Size = new System.Drawing.Size(56, 22);
            this.Label_DateTitle.TabIndex = 79;
            this.Label_DateTitle.Text = "Date: ";
            this.Label_DateTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_TitleSeparator
            // 
            this.Label_TitleSeparator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_TitleSeparator.BackColor = System.Drawing.Color.Red;
            this.Label_TitleSeparator.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TitleSeparator.Location = new System.Drawing.Point(0, 136);
            this.Label_TitleSeparator.Name = "Label_TitleSeparator";
            this.Label_TitleSeparator.Size = new System.Drawing.Size(856, 1);
            this.Label_TitleSeparator.TabIndex = 80;
            // 
            // Label_ReceiptNo
            // 
            this.Label_ReceiptNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_ReceiptNo.AutoSize = true;
            this.Label_ReceiptNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_ReceiptNo.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ReceiptNo.Location = new System.Drawing.Point(123, 150);
            this.Label_ReceiptNo.Name = "Label_ReceiptNo";
            this.Label_ReceiptNo.Size = new System.Drawing.Size(54, 22);
            this.Label_ReceiptNo.TabIndex = 81;
            this.Label_ReceiptNo.Text = "0000";
            this.Label_ReceiptNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_ReceiptContent
            // 
            this.Label_ReceiptContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_ReceiptContent.AutoSize = true;
            this.Label_ReceiptContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_ReceiptContent.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ReceiptContent.Location = new System.Drawing.Point(12, 240);
            this.Label_ReceiptContent.Name = "Label_ReceiptContent";
            this.Label_ReceiptContent.Size = new System.Drawing.Size(767, 66);
            this.Label_ReceiptContent.TabIndex = 83;
            this.Label_ReceiptContent.Text = "Received with thanks from  _________________________________. The Sum of rupees  " +
    "___________________ \r\n\r\ntowards monthly fees for the month of  _________________" +
    "_______, by ";
            // 
            // Button_ResetGuestPaymentForm
            // 
            this.Button_ResetGuestPaymentForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button_ResetGuestPaymentForm.BackColor = System.Drawing.Color.Transparent;
            this.Button_ResetGuestPaymentForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_ResetGuestPaymentForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_ResetGuestPaymentForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_ResetGuestPaymentForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ResetGuestPaymentForm.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ResetGuestPaymentForm.Location = new System.Drawing.Point(696, 441);
            this.Button_ResetGuestPaymentForm.Name = "Button_ResetGuestPaymentForm";
            this.Button_ResetGuestPaymentForm.Size = new System.Drawing.Size(97, 30);
            this.Button_ResetGuestPaymentForm.TabIndex = 86;
            this.Button_ResetGuestPaymentForm.Text = "RESET";
            this.Button_ResetGuestPaymentForm.UseVisualStyleBackColor = false;
            this.Button_ResetGuestPaymentForm.Visible = false;
            this.Button_ResetGuestPaymentForm.Click += new System.EventHandler(this.Button_ResetGuestPaymentForm_Click);
            // 
            // Button_ShareGuestPaymentReceipt
            // 
            this.Button_ShareGuestPaymentReceipt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button_ShareGuestPaymentReceipt.BackColor = System.Drawing.Color.Transparent;
            this.Button_ShareGuestPaymentReceipt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_ShareGuestPaymentReceipt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_ShareGuestPaymentReceipt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_ShareGuestPaymentReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ShareGuestPaymentReceipt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ShareGuestPaymentReceipt.Location = new System.Drawing.Point(55, 441);
            this.Button_ShareGuestPaymentReceipt.Name = "Button_ShareGuestPaymentReceipt";
            this.Button_ShareGuestPaymentReceipt.Size = new System.Drawing.Size(83, 30);
            this.Button_ShareGuestPaymentReceipt.TabIndex = 85;
            this.Button_ShareGuestPaymentReceipt.Text = "SHARE";
            this.Button_ShareGuestPaymentReceipt.UseVisualStyleBackColor = false;
            this.Button_ShareGuestPaymentReceipt.Visible = false;
            this.Button_ShareGuestPaymentReceipt.Click += new System.EventHandler(this.Button_ShareGuestPaymentReceipt_Click);
            // 
            // Button_AcceptGuestPayment
            // 
            this.Button_AcceptGuestPayment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button_AcceptGuestPayment.BackColor = System.Drawing.Color.Transparent;
            this.Button_AcceptGuestPayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_AcceptGuestPayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_AcceptGuestPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_AcceptGuestPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_AcceptGuestPayment.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AcceptGuestPayment.Location = new System.Drawing.Point(380, 441);
            this.Button_AcceptGuestPayment.Name = "Button_AcceptGuestPayment";
            this.Button_AcceptGuestPayment.Size = new System.Drawing.Size(97, 30);
            this.Button_AcceptGuestPayment.TabIndex = 84;
            this.Button_AcceptGuestPayment.Text = "ACCEPT";
            this.Button_AcceptGuestPayment.UseVisualStyleBackColor = false;
            this.Button_AcceptGuestPayment.Visible = false;
            this.Button_AcceptGuestPayment.Click += new System.EventHandler(this.Button_AcceptGuestPayment_Click);
            // 
            // TextBox_GuestName
            // 
            this.TextBox_GuestName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBox_GuestName.BackColor = System.Drawing.Color.White;
            this.TextBox_GuestName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_GuestName.Enabled = false;
            this.TextBox_GuestName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_GuestName.Location = new System.Drawing.Point(240, 233);
            this.TextBox_GuestName.Name = "TextBox_GuestName";
            this.TextBox_GuestName.Size = new System.Drawing.Size(230, 23);
            this.TextBox_GuestName.TabIndex = 87;
            this.TextBox_GuestName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_GuestPayAmountPerMonth
            // 
            this.TextBox_GuestPayAmountPerMonth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBox_GuestPayAmountPerMonth.BackColor = System.Drawing.Color.White;
            this.TextBox_GuestPayAmountPerMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_GuestPayAmountPerMonth.Enabled = false;
            this.TextBox_GuestPayAmountPerMonth.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_GuestPayAmountPerMonth.Location = new System.Drawing.Point(636, 233);
            this.TextBox_GuestPayAmountPerMonth.MaxLength = 10;
            this.TextBox_GuestPayAmountPerMonth.Name = "TextBox_GuestPayAmountPerMonth";
            this.TextBox_GuestPayAmountPerMonth.Size = new System.Drawing.Size(133, 23);
            this.TextBox_GuestPayAmountPerMonth.TabIndex = 88;
            this.TextBox_GuestPayAmountPerMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_CurrentMonth
            // 
            this.TextBox_CurrentMonth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBox_CurrentMonth.BackColor = System.Drawing.Color.White;
            this.TextBox_CurrentMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_CurrentMonth.Enabled = false;
            this.TextBox_CurrentMonth.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_CurrentMonth.Location = new System.Drawing.Point(334, 277);
            this.TextBox_CurrentMonth.MaxLength = 10;
            this.TextBox_CurrentMonth.Name = "TextBox_CurrentMonth";
            this.TextBox_CurrentMonth.Size = new System.Drawing.Size(165, 23);
            this.TextBox_CurrentMonth.TabIndex = 89;
            this.TextBox_CurrentMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label_CurrentDate
            // 
            this.Label_CurrentDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_CurrentDate.AutoSize = true;
            this.Label_CurrentDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_CurrentDate.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CurrentDate.Location = new System.Drawing.Point(710, 149);
            this.Label_CurrentDate.Name = "Label_CurrentDate";
            this.Label_CurrentDate.Size = new System.Drawing.Size(116, 22);
            this.Label_CurrentDate.TabIndex = 82;
            this.Label_CurrentDate.Text = "dd-mm-yyyy";
            this.Label_CurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RadioButton_Cash
            // 
            this.RadioButton_Cash.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioButton_Cash.AutoSize = true;
            this.RadioButton_Cash.BackColor = System.Drawing.Color.Transparent;
            this.RadioButton_Cash.Checked = true;
            this.RadioButton_Cash.FlatAppearance.BorderSize = 0;
            this.RadioButton_Cash.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RadioButton_Cash.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_Cash.Location = new System.Drawing.Point(545, 285);
            this.RadioButton_Cash.Name = "RadioButton_Cash";
            this.RadioButton_Cash.Size = new System.Drawing.Size(73, 26);
            this.RadioButton_Cash.TabIndex = 90;
            this.RadioButton_Cash.TabStop = true;
            this.RadioButton_Cash.Text = "CASH";
            this.RadioButton_Cash.UseVisualStyleBackColor = false;
            this.RadioButton_Cash.CheckedChanged += new System.EventHandler(this.RadioButton_Cash_CheckedChanged);
            // 
            // RadioButton_UPI
            // 
            this.RadioButton_UPI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioButton_UPI.AutoSize = true;
            this.RadioButton_UPI.BackColor = System.Drawing.Color.Transparent;
            this.RadioButton_UPI.FlatAppearance.BorderSize = 0;
            this.RadioButton_UPI.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RadioButton_UPI.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_UPI.Location = new System.Drawing.Point(545, 317);
            this.RadioButton_UPI.Name = "RadioButton_UPI";
            this.RadioButton_UPI.Size = new System.Drawing.Size(57, 26);
            this.RadioButton_UPI.TabIndex = 91;
            this.RadioButton_UPI.Text = "UPI";
            this.RadioButton_UPI.UseVisualStyleBackColor = false;
            this.RadioButton_UPI.CheckedChanged += new System.EventHandler(this.RadioButton_UPI_CheckedChanged);
            // 
            // TextBox_UPI_ID
            // 
            this.TextBox_UPI_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBox_UPI_ID.BackColor = System.Drawing.Color.White;
            this.TextBox_UPI_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_UPI_ID.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_UPI_ID.Location = new System.Drawing.Point(607, 361);
            this.TextBox_UPI_ID.Name = "TextBox_UPI_ID";
            this.TextBox_UPI_ID.Size = new System.Drawing.Size(173, 23);
            this.TextBox_UPI_ID.TabIndex = 92;
            this.TextBox_UPI_ID.Visible = false;
            // 
            // Label_UPI_ID_Underbar
            // 
            this.Label_UPI_ID_Underbar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_UPI_ID_Underbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_UPI_ID_Underbar.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_UPI_ID_Underbar.Location = new System.Drawing.Point(607, 387);
            this.Label_UPI_ID_Underbar.Name = "Label_UPI_ID_Underbar";
            this.Label_UPI_ID_Underbar.Size = new System.Drawing.Size(173, 1);
            this.Label_UPI_ID_Underbar.TabIndex = 93;
            this.Label_UPI_ID_Underbar.Visible = false;
            // 
            // Label_UPI_ID_Title
            // 
            this.Label_UPI_ID_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_UPI_ID_Title.AutoSize = true;
            this.Label_UPI_ID_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_UPI_ID_Title.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_UPI_ID_Title.Location = new System.Drawing.Point(568, 365);
            this.Label_UPI_ID_Title.Name = "Label_UPI_ID_Title";
            this.Label_UPI_ID_Title.Size = new System.Drawing.Size(38, 22);
            this.Label_UPI_ID_Title.TabIndex = 94;
            this.Label_UPI_ID_Title.Text = "ID :";
            this.Label_UPI_ID_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_UPI_ID_Title.Visible = false;
            // 
            // Button_ReceiptPrint
            // 
            this.Button_ReceiptPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button_ReceiptPrint.AutoSize = true;
            this.Button_ReceiptPrint.BackColor = System.Drawing.Color.Transparent;
            this.Button_ReceiptPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_ReceiptPrint.FlatAppearance.BorderSize = 0;
            this.Button_ReceiptPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_ReceiptPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_ReceiptPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ReceiptPrint.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ReceiptPrint.Image = global::PG_Management_System.Properties.Resources.Print;
            this.Button_ReceiptPrint.Location = new System.Drawing.Point(206, 442);
            this.Button_ReceiptPrint.Name = "Button_ReceiptPrint";
            this.Button_ReceiptPrint.Size = new System.Drawing.Size(28, 28);
            this.Button_ReceiptPrint.TabIndex = 96;
            this.Button_ReceiptPrint.UseVisualStyleBackColor = false;
            this.Button_ReceiptPrint.Visible = false;
            this.Button_ReceiptPrint.Click += new System.EventHandler(this.Button_ReceiptPrint_Click);
            // 
            // Button_ReceiptMail
            // 
            this.Button_ReceiptMail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button_ReceiptMail.AutoSize = true;
            this.Button_ReceiptMail.BackColor = System.Drawing.Color.Transparent;
            this.Button_ReceiptMail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_ReceiptMail.FlatAppearance.BorderSize = 0;
            this.Button_ReceiptMail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_ReceiptMail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_ReceiptMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ReceiptMail.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ReceiptMail.Image = global::PG_Management_System.Properties.Resources.Mail_Image;
            this.Button_ReceiptMail.Location = new System.Drawing.Point(158, 442);
            this.Button_ReceiptMail.Name = "Button_ReceiptMail";
            this.Button_ReceiptMail.Size = new System.Drawing.Size(28, 28);
            this.Button_ReceiptMail.TabIndex = 95;
            this.Button_ReceiptMail.UseVisualStyleBackColor = false;
            this.Button_ReceiptMail.Visible = false;
            this.Button_ReceiptMail.Click += new System.EventHandler(this.Button_RecieptMail_Click);
            // 
            // ComboBox_Printers
            // 
            this.ComboBox_Printers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboBox_Printers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ComboBox_Printers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Printers.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Printers.FormattingEnabled = true;
            this.ComboBox_Printers.Location = new System.Drawing.Point(55, 490);
            this.ComboBox_Printers.Name = "ComboBox_Printers";
            this.ComboBox_Printers.Size = new System.Drawing.Size(179, 23);
            this.ComboBox_Printers.Sorted = true;
            this.ComboBox_Printers.TabIndex = 97;
            this.ComboBox_Printers.Visible = false;
            this.ComboBox_Printers.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Printers_SelectedIndexChanged);
            // 
            // AcceptPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(856, 635);
            this.ControlBox = false;
            this.Controls.Add(this.ComboBox_Printers);
            this.Controls.Add(this.Button_ReceiptPrint);
            this.Controls.Add(this.Button_ReceiptMail);
            this.Controls.Add(this.Label_UPI_ID_Title);
            this.Controls.Add(this.TextBox_UPI_ID);
            this.Controls.Add(this.Label_UPI_ID_Underbar);
            this.Controls.Add(this.RadioButton_UPI);
            this.Controls.Add(this.RadioButton_Cash);
            this.Controls.Add(this.TextBox_CurrentMonth);
            this.Controls.Add(this.TextBox_GuestPayAmountPerMonth);
            this.Controls.Add(this.TextBox_GuestName);
            this.Controls.Add(this.Button_ResetGuestPaymentForm);
            this.Controls.Add(this.Button_ShareGuestPaymentReceipt);
            this.Controls.Add(this.Button_AcceptGuestPayment);
            this.Controls.Add(this.Label_ReceiptContent);
            this.Controls.Add(this.Label_CurrentDate);
            this.Controls.Add(this.Label_ReceiptNo);
            this.Controls.Add(this.Label_TitleSeparator);
            this.Controls.Add(this.Label_DateTitle);
            this.Controls.Add(this.Label_RECEIPTTitle);
            this.Controls.Add(this.Label_ReceiptNoTitle);
            this.Controls.Add(this.Label_PGAddress);
            this.Controls.Add(this.Label_PGName);
            this.Controls.Add(this.ComboBox_Guests);
            this.Controls.Add(this.ComboBox_Rooms);
            this.Controls.Add(this.ComboBox_Floors);
            this.Controls.Add(this.ComboBox_Buildings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AcceptPaymentForm";
            this.Text = "AcceptPaymentForm";
            this.Load += new System.EventHandler(this.AcceptPaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboBox_Guests;
        private System.Windows.Forms.ComboBox ComboBox_Rooms;
        private System.Windows.Forms.ComboBox ComboBox_Floors;
        private System.Windows.Forms.ComboBox ComboBox_Buildings;
        private System.Windows.Forms.Label Label_PGAddress;
        private System.Windows.Forms.Label Label_PGName;
        private System.Windows.Forms.Label Label_ReceiptNoTitle;
        private System.Windows.Forms.Label Label_RECEIPTTitle;
        private System.Windows.Forms.Label Label_DateTitle;
        private System.Windows.Forms.Label Label_TitleSeparator;
        private System.Windows.Forms.Label Label_ReceiptNo;
        private System.Windows.Forms.Label Label_ReceiptContent;
        private System.Windows.Forms.Button Button_ResetGuestPaymentForm;
        private System.Windows.Forms.Button Button_ShareGuestPaymentReceipt;
        private System.Windows.Forms.Button Button_AcceptGuestPayment;
        private System.Windows.Forms.TextBox TextBox_GuestName;
        private System.Windows.Forms.TextBox TextBox_GuestPayAmountPerMonth;
        private System.Windows.Forms.TextBox TextBox_CurrentMonth;
        private System.Windows.Forms.Label Label_CurrentDate;
        private System.Windows.Forms.RadioButton RadioButton_Cash;
        private System.Windows.Forms.RadioButton RadioButton_UPI;
        private System.Windows.Forms.TextBox TextBox_UPI_ID;
        private System.Windows.Forms.Label Label_UPI_ID_Underbar;
        private System.Windows.Forms.Label Label_UPI_ID_Title;
        private System.Windows.Forms.Button Button_ReceiptMail;
        private System.Windows.Forms.Button Button_ReceiptPrint;
        private System.Windows.Forms.ComboBox ComboBox_Printers;
    }
}