using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PG_Management_System
{
    public partial class AdmissionForm : Form
    {
        string PictureBox_ImagePath = "No Image";
        string RImagePath = "No Image";
        public static AdmissionForm admissionFormInstance = new AdmissionForm();

        public AdmissionForm()
        {
            InitializeComponent();
        }
        
        private void AdmissionForm_Load(object sender, EventArgs e)
        {
            Label_PGName.Text = Properties.Settings.Default.PGName;
            Label_PGAddress.Text = Properties.Settings.Default.PGAddress;

            Button_RemoveGuest.Visible = false;
            TextBox_GuestName.Focus();

            if (Properties.Settings.Default.MainFormRemoveGuest)
            {
                TextBox_GuestName.Enabled = false;
                DateTimePicker_GuestDateOfBirth.Enabled = false;
                TextBox_GuestMobileNo.Enabled = false;
                TextBox_GuestMailID.Enabled = false;
                TextBox_GuestAadhaarNo.Enabled = false;
                ComboBox_GuestBloodGroup.Enabled = false;
                TextBox_GuestParentGuardianName.Enabled = false;
                TextBox_GuestEmergencyMobNo.Enabled = false;
                DateTimePicker_GuestDateOfJoining.Enabled = false;
                TextBox_GuestPermanentAddress.Enabled = false;
                TextBox_GuestAdvanceAmountPaid.Enabled = false;
                TextBox_GuestPayAmountPerMonth.Enabled = false;
                PictureBox_GuestImage.Enabled = false;
                
                Button_AdmitGuest.Visible = false;
                Button_ResetGuestAdmissionForm.Visible = false;
            }

            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
            string query = "SELECT id,building_name FROM buildings;";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                ComboBox_Buildings.Items.Clear();
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

            ComboBox_Buildings.Text = "-- Select Building --";
        }
        
        private void PictureBox_GuestImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.bmp) | *.png; *.jpg; *.jpeg; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PictureBox_GuestImage.Image = new Bitmap(ofd.FileName);
                    PictureBox_ImagePath = ofd.FileName;
                }
                catch (Exception Err)
                {
                    PictureBox_GuestImage.Image = Properties.Resources.Add_Image;
                    MessageBox.Show("Unable to Load the Image\n" + Err.Message, "IMAGE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void TextBox_GuestMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptOnlyDigits(e);
        }

        private void TextBox_GuestAadhaarNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptOnlyDigits(e);
        }

        private void TextBox_GuestEmergencyMobNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptOnlyDigits(e);
        }

        private void TextBox_GuestAdvanceAmountPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptOnlyDigits(e);
        }

        private void TextBox_GuestPayAmountPerMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptOnlyDigits(e);
        }
        
        private void AcceptOnlyDigits(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) || ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Button_AdmitGuest_Click(object sender, EventArgs e)
        {
            ErrorProvider_AdmissionForm.Clear();

            if (TextBox_GuestName.Text == "") 
            {
                ErrorProvider_AdmissionForm.SetError(TextBox_GuestName, "Name not Entered");
                TextBox_GuestName.Focus();
            }
            else if (TextBox_GuestMobileNo.Text == "") 
            {
                ErrorProvider_AdmissionForm.SetError(TextBox_GuestMobileNo, "Mobile Number not Entered");
                TextBox_GuestMobileNo.Focus();
            }
            else if (TextBox_GuestMailID.Text == "") 
            {
                ErrorProvider_AdmissionForm.SetError(TextBox_GuestMailID, "Mail ID not Entered");
                TextBox_GuestMailID.Focus();
            }
            else if (TextBox_GuestAadhaarNo.Text == "") 
            {
                ErrorProvider_AdmissionForm.SetError(TextBox_GuestAadhaarNo, "Aadhaar Number not Entered");
                TextBox_GuestAadhaarNo.Focus();
            }
            else if (ComboBox_GuestBloodGroup.Text == "") 
            {
                ErrorProvider_AdmissionForm.SetError(ComboBox_GuestBloodGroup, "Blood Group not Selected");
                ComboBox_GuestBloodGroup.Focus();
            }
            else if (TextBox_GuestParentGuardianName.Text == "") 
            {
                ErrorProvider_AdmissionForm.SetError(TextBox_GuestParentGuardianName, "Parent or Guardian Name not Entered");
                TextBox_GuestParentGuardianName.Focus();
            }
            else if (TextBox_GuestEmergencyMobNo.Text == "") 
            {
                ErrorProvider_AdmissionForm.SetError(TextBox_GuestEmergencyMobNo, "Emergency Number not Entered");
                TextBox_GuestEmergencyMobNo.Focus();
            }
            else if (TextBox_GuestPermanentAddress.Text == "")
            {
                ErrorProvider_AdmissionForm.SetError(TextBox_GuestPermanentAddress, "Address not Entered");
                TextBox_GuestPermanentAddress.Focus();
            }
            else if (TextBox_GuestAdvanceAmountPaid.Text == "")
            {
                ErrorProvider_AdmissionForm.SetError(TextBox_GuestAdvanceAmountPaid, "Amount not Entered");
                TextBox_GuestAdvanceAmountPaid.Focus();
            }
            else if (TextBox_GuestPayAmountPerMonth.Text == "")
            {
                ErrorProvider_AdmissionForm.SetError(TextBox_GuestPayAmountPerMonth, "Amount not Entered");
                TextBox_GuestPayAmountPerMonth.Focus();
            }
            else if (ComboBox_Buildings.Text == "-- Select Building --") 
            {
                ErrorProvider_AdmissionForm.SetError(ComboBox_Buildings, "Building not Selected");
                ComboBox_Buildings.Focus();
            }
            else if (ComboBox_Floors.Text == "-- Select Floor --")
            {
                ErrorProvider_AdmissionForm.SetError(ComboBox_Buildings, "Building not Selected");
                ComboBox_Floors.Focus();
            }
            else if (ComboBox_Rooms.Text == "-- Select Room --")
            {
                ErrorProvider_AdmissionForm.SetError(ComboBox_Buildings, "Building not Selected");
                ComboBox_Rooms.Focus();
            }
            else
            {
                try
                {
                    if (PictureBox_ImagePath != "No Image")
                    {
                        RImagePath = "Images/" + Properties.Settings.Default.SelectedBuildingName + "/" + Properties.Settings.Default.SelectedFloorName + "/" + Properties.Settings.Default.SelectedRoomName + "/"; //RelativeImagePath
                        Directory.CreateDirectory(RImagePath);

                        PictureBox_GuestImage.Image.Save(RImagePath + TextBox_GuestName.Text + " Image.jpg", ImageFormat.Jpeg);
                    }
                    MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
                    string query = "INSERT INTO guests VALUES(@ID,@RoomID,@Name,@DOB,@MobNo,@MailID,@AadhaarNo,@BloodGroup,@PorGName,@EmContactNo,@DOJ,@PAddress,@AdvAmount,@AmountPerMonth,@ImageRPath);";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", Properties.Settings.Default.SelectedRoomID + TextBox_GuestAadhaarNo.Text);
                    cmd.Parameters.AddWithValue("@RoomID", Properties.Settings.Default.SelectedRoomID);
                    cmd.Parameters.AddWithValue("@Name", TextBox_GuestName.Text);
                    cmd.Parameters.AddWithValue("@DOB", DateTimePicker_GuestDateOfBirth.Value.ToString("dd MMMM yyyy"));
                    cmd.Parameters.AddWithValue("@MobNo", TextBox_GuestMobileNo.Text);
                    cmd.Parameters.AddWithValue("@MailID", TextBox_GuestMailID.Text);
                    cmd.Parameters.AddWithValue("@AadhaarNo", TextBox_GuestAadhaarNo.Text);
                    cmd.Parameters.AddWithValue("@BloodGroup", ComboBox_GuestBloodGroup.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PorGName", TextBox_GuestParentGuardianName.Text);
                    cmd.Parameters.AddWithValue("@EmContactNo", TextBox_GuestMobileNo.Text);
                    cmd.Parameters.AddWithValue("@DOJ", DateTimePicker_GuestDateOfJoining.Value.ToString("dd MMMM yyyy"));
                    cmd.Parameters.AddWithValue("@PAddress", TextBox_GuestPermanentAddress.Text);
                    cmd.Parameters.AddWithValue("@AdvAmount", TextBox_GuestAdvanceAmountPaid.Text);
                    cmd.Parameters.AddWithValue("@AmountPerMonth", TextBox_GuestPayAmountPerMonth.Text);
                    cmd.Parameters.AddWithValue("@ImageRPath", RImagePath);

                    con.Open();
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Guest Admitted Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Button_ResetGuestAdmissionForm_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Unable to Admit Guest", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
                catch (Exception Err)
                {
                    if (Err.Message.Contains("PRIMARY"))
                    {
                        MessageBox.Show("AADHAAR NUMBER ALREADY EXISTS.\nID  " + TextBox_GuestAadhaarNo.Text + "  ALREADY EXISTS!!", "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextBox_GuestAadhaarNo.Focus();
                    }
                    else if (Err.Message.Contains("generic"))
                    {
                        MessageBox.Show("Don't Leave White Spaces at the end in the Name Field.", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextBox_GuestName.Focus();
                    }
                    else
                    {
                        MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        
        private void Button_RemoveGuest_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Do you really want to Remove Guest?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
                string query = "DELETE FROM fees WHERE guest_id=@ID; DELETE FROM visitors WHERE guest_id=@ID; DELETE FROM guests WHERE id=@ID;";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", Properties.Settings.Default.SelectedGuestID);
                try
                {
                    con.Open();
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        if (PictureBox_GuestImage.ImageLocation != "No Image")
                        {
                            File.Delete(PictureBox_GuestImage.ImageLocation);
                        }
                        MessageBox.Show("Guest Deleted Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Button_ResetGuestAdmissionForm_Click(sender, e);
                        Button_RemoveGuest.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Unable to Delete Guest", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
                catch (Exception Err)
                {
                    
                    MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button_ResetGuestAdmissionForm_Click(object sender, EventArgs e)
        {
            TextBox_GuestName.Text = "";
            DateTimePicker_GuestDateOfBirth.Value = DateTime.Today;
            TextBox_GuestMobileNo.Text = "";
            TextBox_GuestMailID.Text = "";
            TextBox_GuestAadhaarNo.Text = "";
            ComboBox_GuestBloodGroup.Text = "";
            TextBox_GuestParentGuardianName.Text = "";
            TextBox_GuestEmergencyMobNo.Text = "";
            DateTimePicker_GuestDateOfJoining.Value = DateTime.Today;
            TextBox_GuestPermanentAddress.Text = "";
            TextBox_GuestAdvanceAmountPaid.Text = "";
            TextBox_GuestPayAmountPerMonth.Text = "";
            PictureBox_GuestImage.Image = Properties.Resources.Add_Image;
            ComboBox_Floors.Visible = false;
            ComboBox_Rooms.Visible = false;
            ComboBox_Guests.Visible = false;

            TextBox_GuestName.Focus();
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
            Button_RemoveGuest.Visible = false;
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

            ComboBox_Rooms.Text = "-- Select Room --";
            ComboBox_Rooms.Visible = true;
            ComboBox_Rooms.Focus();
        }

        private void ComboBox_Rooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] roomNameID = ComboBox_Rooms.SelectedItem.ToString().Split('-');

            Properties.Settings.Default.SelectedRoomName = roomNameID[0].Trim();

            Properties.Settings.Default.SelectedRoomID = Regex.Match(roomNameID[1], @"\d+").Value;

            if (Properties.Settings.Default.MainFormRemoveGuest)
            {

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

                ComboBox_Guests.Text = "-- Select Guest --";
                ComboBox_Guests.Visible = true;
                ComboBox_Guests.Focus();
            }
        }

        private void ComboBox_Guests_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] guestID = ComboBox_Guests.SelectedItem.ToString().Split('-');

            Properties.Settings.Default.SelectedGuestID = Regex.Match(guestID[1], @"\d+").Value;

            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
            string query = "SELECT * FROM guests where id=@ID;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", Properties.Settings.Default.SelectedGuestID);
            try
            {
                con.Open();
                MySqlDataReader GuestDetails = cmd.ExecuteReader();

                while (GuestDetails.Read())
                {
                    TextBox_GuestName.Text = GuestDetails["name"].ToString();
                    DateTimePicker_GuestDateOfBirth.Value = DateTime.Parse(GuestDetails["dob"].ToString());
                    TextBox_GuestMobileNo.Text = GuestDetails["mob_no"].ToString();
                    TextBox_GuestMailID.Text = GuestDetails["mail_id"].ToString();
                    TextBox_GuestAadhaarNo.Text = GuestDetails["aadhaar_no"].ToString();
                    ComboBox_GuestBloodGroup.Text = GuestDetails["blood_group"].ToString();
                    TextBox_GuestParentGuardianName.Text = GuestDetails["parent_guardian_name"].ToString();
                    TextBox_GuestEmergencyMobNo.Text = GuestDetails["emergency_contactno"].ToString();
                    DateTimePicker_GuestDateOfJoining.Value = DateTime.Parse(GuestDetails["doj"].ToString());
                    TextBox_GuestPermanentAddress.Text = GuestDetails["p_address"].ToString();
                    TextBox_GuestAdvanceAmountPaid.Text = GuestDetails["advance_amount"].ToString();
                    TextBox_GuestPayAmountPerMonth.Text = GuestDetails["amount_per_month"].ToString();
                    PictureBox_GuestImage.ImageLocation = GuestDetails["guest_imageRPath"].ToString() + GuestDetails["name"].ToString() + " Image.jpg";
                }
                con.Close();
                Button_RemoveGuest.Visible = true;
            }
            catch (Exception Err)
            {
                MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBox_GuestBloodGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
