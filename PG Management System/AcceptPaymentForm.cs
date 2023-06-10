using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Borders;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;
using System.Net.Mail;
using System.Net;
using System.Drawing.Printing;
using RawPrint;

namespace PG_Management_System
{
    public partial class AcceptPaymentForm : Form
    {
        public static AcceptPaymentForm acceptPaymentFormInstance = new AcceptPaymentForm();
        public static string ReceiptFileLocation = null;

        public AcceptPaymentForm()
        {
            InitializeComponent();
        }

        private void AcceptPaymentForm_Load(object sender, EventArgs e)
        {
            Label_PGName.Text = Properties.Settings.Default.PGName;
            Label_PGAddress.Text = Properties.Settings.Default.PGAddress;
            Label_ReceiptNo.Text = Properties.Settings.Default.ReceiptNo.ToString();
            Label_CurrentDate.Text = DateTime.Today.ToString("dd-MM-yyyy");
            TextBox_CurrentMonth.Text = DateTime.Today.ToString("MMMM");
            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
            string query = "SELECT id,building_name FROM buildings;";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                ComboBox_Buildings.Items.Clear();
                ComboBox_Buildings.Text = "-- Select Building --";
                con.Open();
                MySqlDataReader BuildingsNames = cmd.ExecuteReader();

                while (BuildingsNames.Read())
                {
                    ComboBox_Buildings.Items.Add(BuildingsNames["building_name"].ToString() + " - " + BuildingsNames["id"].ToString());
                }
                con.Close();
            }
            catch (Exception Err)
            {
                MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ComboBox_Buildings.Focus();
        }

        private void Button_AcceptGuestPayment_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.ReceiptNo = 1;
            //Properties.Settings.Default.Save();  // Only option to reset the value of ReceiptNo, do this on 1st of every month after generating report of previous month, do this on form load

            //when payment is accepted and stored increment the properties.settings.default.receiptno by 1 and save it. -- done

            string mop = null;

            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
            string query = "INSERT INTO fees VALUES(@GuestID,@ReceiptNo,@ModeOfPayment,@Amount,@DateOfPayment);";
            MySqlCommand cmd = new MySqlCommand(query, con);


            if (RadioButton_UPI.Checked && String.IsNullOrEmpty(TextBox_UPI_ID.Text))
            {
                MessageBox.Show("Please enter UPI ID", "Enter UPI ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (RadioButton_UPI.Checked && !String.IsNullOrEmpty(TextBox_UPI_ID.Text))
            {
                cmd.Parameters.AddWithValue("@ModeOfPayment", TextBox_UPI_ID.Text);
                mop = "UPI ID: " + TextBox_UPI_ID.Text;
            }
            if (RadioButton_Cash.Checked)
            {
                cmd.Parameters.AddWithValue("@ModeOfPayment", RadioButton_Cash.Text);
                mop = RadioButton_Cash.Text;
            }
            if(!String.IsNullOrEmpty(mop))
            {
                cmd.Parameters.AddWithValue("@GuestID", Properties.Settings.Default.SelectedGuestID);
                cmd.Parameters.AddWithValue("@ReceiptNo", Label_ReceiptNo.Text);
                cmd.Parameters.AddWithValue("@Amount", TextBox_GuestPayAmountPerMonth.Text);
                cmd.Parameters.AddWithValue("@DateOfPayment", Label_CurrentDate.Text);

                try
                {
                    con.Open();
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Payment Accepted Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Properties.Settings.Default.ReceiptNo++;
                        Properties.Settings.Default.Save();
                        Label_ReceiptNo.Text = Properties.Settings.Default.ReceiptNo.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Unable to Accept Payment", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();

                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.FileName = TextBox_GuestName.Text + " Receipt - " + DateTime.Now.ToLongDateString();
                    sfd.DefaultExt = ".pdf";
                    sfd.Filter = "(*.pdf)|*.pdf";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {

                        PdfWriter writer = new PdfWriter(sfd.FileName);
                        ReceiptFileLocation = sfd.FileName;
                        PdfDocument pdf = new PdfDocument(writer);
                        Document document = new Document(pdf, PageSize.A4);

                        Paragraph PGName = new Paragraph(Properties.Settings.Default.PGName).SetTextAlignment(TextAlignment.CENTER).SetFontSize(20);
                        document.Add(PGName);

                        Paragraph PGAddress = new Paragraph(Properties.Settings.Default.PGAddress).SetTextAlignment(TextAlignment.CENTER).SetFontSize(16);
                        document.Add(PGAddress);

                        LineSeparator ls = new LineSeparator(new SolidLine());
                        document.Add(ls);

                        Table ReceiptHeader = new Table(3, true);

                        Cell ReceiptNo = new Cell(1, 1).Add(new Paragraph(Label_ReceiptNoTitle.Text + Label_ReceiptNo.Text).SetTextAlignment(TextAlignment.LEFT).SetFontSize(14));
                        ReceiptNo.SetBorder(Border.NO_BORDER);
                        ReceiptHeader.AddCell(ReceiptNo);

                        Cell ReceiptTitle = new Cell(1, 1).Add(new Paragraph(Label_RECEIPTTitle.Text).SetTextAlignment(TextAlignment.CENTER).SetFontSize(14));
                        ReceiptTitle.SetBorder(Border.NO_BORDER);
                        ReceiptHeader.AddCell(ReceiptTitle);

                        Cell ReceiptDate = new Cell(1, 1).Add(new Paragraph(Label_DateTitle.Text + Label_CurrentDate.Text).SetTextAlignment(TextAlignment.RIGHT).SetFontSize(14));
                        ReceiptDate.SetBorder(Border.NO_BORDER);
                        ReceiptHeader.AddCell(ReceiptDate);

                        document.Add(ReceiptHeader);

                        Paragraph ReceiptMainContent = new Paragraph("\n\n Received with thanks from " + TextBox_GuestName.Text + ". The Sum of rupees " + TextBox_GuestPayAmountPerMonth.Text + " towards monthly fees for the month of " + TextBox_CurrentMonth.Text + ", by " + mop + ".").SetTextAlignment(TextAlignment.JUSTIFIED).SetFontSize(14);
                        document.Add(ReceiptMainContent);

                        document.Close();

                        Button_ShareGuestPaymentReceipt.Visible = true;
                        Button_ResetGuestPaymentForm.Visible = true;
                    }
                }
                catch (Exception Err)
                {
                    MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        
        private void Button_ShareGuestPaymentReceipt_Click(object sender, EventArgs e)
        {
            Button_ReceiptMail.Visible = true;
            Button_ReceiptPrint.Visible = true;
        }

        private void Button_ResetGuestPaymentForm_Click(object sender, EventArgs e)
        {
            ComboBox_Floors.Visible = false;
            ComboBox_Rooms.Visible = false;
            ComboBox_Guests.Visible = false;
            TextBox_GuestName.Text = "";
            TextBox_GuestPayAmountPerMonth.Text = "";
            RadioButton_Cash.Checked = true;
            Button_AcceptGuestPayment.Visible = false;
            Button_ShareGuestPaymentReceipt.Visible = false;
            Button_ResetGuestPaymentForm.Visible = false;
            Button_ReceiptPrint.Visible = false;
            Button_ReceiptMail.Visible = false;
            ComboBox_Printers.Visible = false;

            AcceptPaymentForm_Load(sender, e);
        }

        private void ComboBox_Buildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] buildingNameID = ComboBox_Buildings.SelectedItem.ToString().Split('-');

            Properties.Settings.Default.SelectedBuildingName = buildingNameID[0].Trim();
            //This is helps to create a folder inside Images/BuildingName/FloorName like format

            Properties.Settings.Default.SelectedBuildingID = Regex.Match(buildingNameID[1], @"\d+").Value;
            //This line is very important because it returns the selected_buildingID from which floors of selected building will be displayed both in Floors_ComboBox and FloorsForm OnLoad().

            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
            string query = "SELECT id,floor_name FROM floors where building_id=@ID;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", Properties.Settings.Default.SelectedBuildingID);
            try
            {
                ComboBox_Floors.Items.Clear();
                con.Open();
                MySqlDataReader FloorsNames = cmd.ExecuteReader();

                while (FloorsNames.Read())
                {
                    ComboBox_Floors.Items.Add(FloorsNames["floor_name"].ToString() + " - " + FloorsNames["id"].ToString());
                }
                con.Close();
            }
            catch (Exception Err)
            {
                MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ComboBox_Rooms.Visible = false;
            ComboBox_Guests.Visible = false;
            TextBox_GuestName.Text = "";
            TextBox_GuestPayAmountPerMonth.Text = "";
            RadioButton_Cash.Checked = true;
            Button_AcceptGuestPayment.Visible = false;
            Button_ShareGuestPaymentReceipt.Visible = false;
            Button_ResetGuestPaymentForm.Visible = false;
            Button_ReceiptPrint.Visible = false;
            Button_ReceiptMail.Visible = false;
            ComboBox_Printers.Visible = false;

            ComboBox_Floors.Text = "-- Select Floor --";
            ComboBox_Floors.Visible = true;
            ComboBox_Floors.Focus();
        }

        private void ComboBox_Floors_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] floorNameID = ComboBox_Floors.SelectedItem.ToString().Split('-');

            Properties.Settings.Default.SelectedFloorName = floorNameID[0].Trim();

            Properties.Settings.Default.SelectedFloorID = Regex.Match(floorNameID[1], @"\d+").Value;

            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
            string query = "SELECT id,room_no FROM rooms where floor_id=@ID;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", Properties.Settings.Default.SelectedFloorID);
            try
            {
                ComboBox_Rooms.Items.Clear();
                con.Open();
                MySqlDataReader RoomsNames = cmd.ExecuteReader();

                while (RoomsNames.Read())
                {
                    ComboBox_Rooms.Items.Add("Room No. " + RoomsNames["room_no"].ToString() + " - " + RoomsNames["id"].ToString());
                }
                con.Close();
            }
            catch (Exception Err)
            {
                MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ComboBox_Guests.Visible = false;
            TextBox_GuestName.Text = "";
            TextBox_GuestPayAmountPerMonth.Text = "";
            RadioButton_Cash.Checked = true;
            Button_AcceptGuestPayment.Visible = false;
            Button_ShareGuestPaymentReceipt.Visible = false;
            Button_ResetGuestPaymentForm.Visible = false;
            Button_ReceiptPrint.Visible = false;
            Button_ReceiptMail.Visible = false;
            ComboBox_Printers.Visible = false;

            ComboBox_Rooms.Text = "-- Select Room --";
            ComboBox_Rooms.Visible = true;
            ComboBox_Rooms.Focus();
        }

        private void ComboBox_Rooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] roomNameID = ComboBox_Rooms.SelectedItem.ToString().Split('-');

            Properties.Settings.Default.SelectedRoomName = roomNameID[0].Trim();

            Properties.Settings.Default.SelectedRoomID = Regex.Match(roomNameID[1], @"\d+").Value;

            
            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
            string query = "SELECT id,name FROM guests where room_id=@ID;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", Properties.Settings.Default.SelectedRoomID);
            try
            {
                ComboBox_Guests.Items.Clear();
                con.Open();
                MySqlDataReader GuestsNames = cmd.ExecuteReader();

                while (GuestsNames.Read())
                {
                    ComboBox_Guests.Items.Add(GuestsNames["name"].ToString() + " - " + GuestsNames["id"].ToString());
                }
                con.Close();
            }
            catch (Exception Err)
            {
                MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TextBox_GuestName.Text = "";
            TextBox_GuestPayAmountPerMonth.Text = "";
            RadioButton_Cash.Checked = true;
            Button_AcceptGuestPayment.Visible = false;
            Button_ShareGuestPaymentReceipt.Visible = false;
            Button_ResetGuestPaymentForm.Visible = false;
            Button_ReceiptPrint.Visible = false;
            Button_ReceiptMail.Visible = false;
            ComboBox_Printers.Visible = false;

            ComboBox_Guests.Text = "-- Select Guest --";
            ComboBox_Guests.Visible = true;
            ComboBox_Guests.Focus();

        }

        private void ComboBox_Guests_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox_GuestName.Text = "";
            TextBox_GuestPayAmountPerMonth.Text = "";
            RadioButton_Cash.Checked = true;
            Button_AcceptGuestPayment.Visible = false;
            Button_ShareGuestPaymentReceipt.Visible = false;
            Button_ResetGuestPaymentForm.Visible = false;
            Button_ReceiptPrint.Visible = false;
            Button_ReceiptMail.Visible = false;
            ComboBox_Printers.Visible = false;

            string[] guestID = ComboBox_Guests.SelectedItem.ToString().Split('-');

            Properties.Settings.Default.SelectedGuestID = Regex.Match(guestID[1], @"\d+").Value;

            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
            string query = "SELECT name,amount_per_month FROM guests where id=@ID;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", Properties.Settings.Default.SelectedGuestID);
            try
            {
                con.Open();
                MySqlDataReader GuestDetails = cmd.ExecuteReader();

                while (GuestDetails.Read())
                {
                    TextBox_GuestName.Text = GuestDetails["name"].ToString();
                    TextBox_GuestPayAmountPerMonth.Text = GuestDetails["amount_per_month"].ToString();
                }
                con.Close();
                Button_AcceptGuestPayment.Visible = true;
                
            }
            catch (Exception Err)
            {
                MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RadioButton_UPI_CheckedChanged(object sender, EventArgs e)
        {
            Label_UPI_ID_Title.Visible = true;  
            TextBox_UPI_ID.Visible = true;
            Label_UPI_ID_Underbar.Visible = true;
        }

        private void RadioButton_Cash_CheckedChanged(object sender, EventArgs e)
        {
            Label_UPI_ID_Title.Visible = false;
            TextBox_UPI_ID.Visible = false;
            Label_UPI_ID_Underbar.Visible = false;
        }

        private void Button_RecieptMail_Click(object sender, EventArgs e)
        {
            string GuestMailID=null,GuestName =null;
            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
            string query = "SELECT name,mail_id FROM guests WHERE id=@ID;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", Properties.Settings.Default.SelectedGuestID);
            try
            {
                con.Open();
                MySqlDataReader GuestDetails = cmd.ExecuteReader();

                while(GuestDetails.Read())
                {
                    GuestMailID = GuestDetails["mail_id"].ToString();
                    GuestName = GuestDetails["name"].ToString();
                }
                con.Close();
            }
            catch (Exception Err)
            {
                MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (GuestMailID != null)
            {
                try
                {
                    MailMessage mail = new MailMessage();

                    mail.From = new MailAddress("gfgctumkur.pgms.bca6.2023@gmail.com", "PG Management System", Encoding.UTF8);
                    mail.To.Add(new MailAddress(GuestMailID));
                    mail.Subject = "Monthly Fees Receipt - " + DateTime.Now.ToString("MMMM");
                    mail.Body = "Dear " + GuestName + ", please find the attached monthly fees receipt below. \n Thank You.";
                    mail.Attachments.Add(new Attachment(ReceiptFileLocation));
                    mail.IsBodyHtml = true;

                    SmtpClient client = new SmtpClient();
                    client.Host = "smtp.gmail.com";
                    client.Port = 587;
                    client.Credentials = new NetworkCredential("gfgctumkur.pgms.bca6.2023@gmail.com", "ekjxafsbpnsrafnw");
                    client.EnableSsl = true;

                    client.Send(mail);
                    MessageBox.Show("Mail sent Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception Err)
                {
                    MessageBox.Show("Unable to send Mail.\n" + Err.Message, "CONNECTION FAILURE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }

        private void Button_ReceiptPrint_Click(object sender, EventArgs e)
        {
            ComboBox_Printers.Items.Clear();
            ComboBox_Printers.Text = "-- Select Printer --";
            foreach(string PrinterName in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                ComboBox_Printers.Items.Add(PrinterName);
            }
            ComboBox_Printers.Visible = true;
        }

        private void ComboBox_Printers_SelectedIndexChanged(object sender, EventArgs e)
        {
            IPrinter printer = new Printer();
            printer.PrintRawFile(ComboBox_Printers.SelectedItem.ToString(), ReceiptFileLocation, (TextBox_GuestName.Text + " Receipt - " + DateTime.Now.ToLongDateString()));
        }
    }
}
