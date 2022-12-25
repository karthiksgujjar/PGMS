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
    public partial class AcceptPaymentForm : Form
    {
        public static AcceptPaymentForm acceptPaymentFormInstance = new AcceptPaymentForm();

        public AcceptPaymentForm()
        {
            InitializeComponent();
        }

        private void AcceptPaymentForm_Load(object sender, EventArgs e)
        {
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
            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
            string query = "INSERT INTO fees VALUES(@GuestID,@ReceiptNo,@ModeOfPayment,@Amount,@DateOfPayment);";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@GuestID",Properties.Settings.Default.SelectedGuestID);
            cmd.Parameters.AddWithValue("@ReceiptNo", Label_ReceiptNo.Text);
            if(RadioButton_Cash.Checked)
            {
                cmd.Parameters.AddWithValue("@ModeOfPayment", RadioButton_Cash.Text);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ModeOfPayment", TextBox_UPI_ID.Text);
            }
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
                    Button_ResetGuestPaymentForm_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Unable to Accept Payment", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception Err)
            {
                MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        
        private void Button_ShareGuestPaymentReceipt_Click(object sender, EventArgs e)
        {

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
            Button_AcceptGuestPayment.Visible = false;
            Button_ShareGuestPaymentReceipt.Visible = false;
            Button_ResetGuestPaymentForm.Visible = false;
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
            Button_AcceptGuestPayment.Visible = false;
            Button_ShareGuestPaymentReceipt.Visible = false;
            Button_ResetGuestPaymentForm.Visible = false;
            ComboBox_Guests.Visible = false;
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
            Button_AcceptGuestPayment.Visible = false;
            Button_ShareGuestPaymentReceipt.Visible = false;
            Button_ResetGuestPaymentForm.Visible = false;
            ComboBox_Guests.Text = "-- Select Guest --";
            ComboBox_Guests.Visible = true;
            ComboBox_Guests.Focus();

        }

        private void ComboBox_Guests_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                Button_ShareGuestPaymentReceipt.Visible = true;
                Button_ResetGuestPaymentForm.Visible = true;
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
    }
}
