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

namespace PG_Management_System
{
    public partial class VisitorsForm : Form
    {
        public static VisitorsForm visitorsFormInstance = new VisitorsForm();
        int OTP;
        public VisitorsForm()
        {
            InitializeComponent();
        }

        private void VisitorsForm_Load(object sender, EventArgs e)
        {
            Label_PGName.Text = Properties.Settings.Default.PGName;
            Label_PGAddress.Text = Properties.Settings.Default.PGAddress;
            Label_CurrentDate.Text = DateTime.Now.ToLongDateString();

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

        private void ComboBox_Guests_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] guestID = ComboBox_Guests.SelectedItem.ToString().Split('-');

            Properties.Settings.Default.SelectedGuestID = Regex.Match(guestID[1], @"\d+").Value;

            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
            string query = "SELECT name,mob_no,guest_imageRPath FROM guests where id=@ID;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", Properties.Settings.Default.SelectedGuestID);
            try
            {
                con.Open();
                MySqlDataReader GuestDetails = cmd.ExecuteReader();

                if (GuestDetails.Read())
                {
                    Label_GuestName.Text = GuestDetails["name"].ToString();
                    Label_GuestMobNo.Text = GuestDetails["mob_no"].ToString();
                    Label_GuestName.Visible = true;
                    Label_GuestMobNo.Visible = true;
                    PictureBox_GuestImage.ImageLocation = GuestDetails["guest_imageRPath"].ToString() + GuestDetails["name"].ToString() + " Image.jpg";
                }
                con.Close();
            }
            catch (Exception Err)
            {
                MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_Allow_Click(object sender, EventArgs e)
        {
            ErrorProvider_VisitorsForm.Clear();

            if(TextBox_POI.Text == "")
            {
                ErrorProvider_VisitorsForm.SetError(TextBox_POI,"Enter POI");
                TextBox_POI.Focus();
            }
            else if(TextBox_VisitorName.Text == "")
            {
                ErrorProvider_VisitorsForm.SetError(TextBox_VisitorName, "Enter POI");
                TextBox_VisitorName.Focus();
            }
            else if (TextBox_VisitorMobileNo.Text == "")
            {
                ErrorProvider_VisitorsForm.SetError(TextBox_VisitorMobileNo, "Enter POI");
                TextBox_VisitorMobileNo.Focus();
            }
            else if (TextBox_Relation.Text == "")
            {
                ErrorProvider_VisitorsForm.SetError(TextBox_Relation, "Enter POI");
                TextBox_Relation.Focus();
            }
            else if (TextBox_ReasonOfVisit.Text == "")
            {
                ErrorProvider_VisitorsForm.SetError(TextBox_ReasonOfVisit, "Enter POI");
                TextBox_ReasonOfVisit.Focus();
            }
            else
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
                    string query = "INSERT INTO visitors VALUES(@POI,@GuestID,@Name,@MobNo,@Relation,@DOV,@Reason);";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@POI", TextBox_POI.Text);
                    cmd.Parameters.AddWithValue("@GuestID", Properties.Settings.Default.SelectedGuestID);
                    cmd.Parameters.AddWithValue("@Name", TextBox_VisitorName.Text);
                    cmd.Parameters.AddWithValue("@MobNo", TextBox_VisitorMobileNo.Text);
                    cmd.Parameters.AddWithValue("@Relation", TextBox_Relation.Text);
                    cmd.Parameters.AddWithValue("@DOV", Label_CurrentDate.Text);
                    cmd.Parameters.AddWithValue("@Reason", TextBox_ReasonOfVisit.Text);

                    con.Open();
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Visitor Details Stored Successfully. Allow the Visitor.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Unable to store Visitor details. Don't allow the Visitor.", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
                catch (Exception Err)
                {
                    
                    MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
