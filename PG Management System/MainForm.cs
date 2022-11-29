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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm.loginFormInstance.Close();
            Timer_TimeUpdaterMainForm.Start();
            DateTime dateTime = DateTime.Now;
            Label_DateTimeDisplay.Text = dateTime.ToLongDateString() + ",  " + dateTime.ToShortTimeString();
        }

        private void Button_Home_Click(object sender, EventArgs e)
        {
            Button_Home.Visible = false;
            Button_Previous.Visible = false;
            ComboBox_Floors.Visible = false;
            ComboBox_Rooms.Visible = false;
            Label_GuestFormDisplayController.Enabled = false;
            ComboBox_Buildings.Text = "-- Select Building --";
            BuildingsForm.buildingsFormInstance.Close();
            LoadForm(new BuildingsForm());
        }
        
        private void Button_Previous_Click(object sender, EventArgs e)
        {
            if (Label_GuestFormDisplayController.Enabled)
            {
                ComboBox_Floors_SelectedIndexChanged(sender, e);
                ComboBox_Rooms.Focus();
            }
            else
            {
                Button_Previous.Visible = false;
                ComboBox_Rooms.Visible = false;
                ComboBox_Floors.Text = "-- Select Floor --";
                Label_GuestFormDisplayController.Enabled = false;
                RoomsForm.roomsFormInstance.Close();
                LoadForm(new FloorsForm());
            }
        }
        
        private void MainForm_Activated(object sender, EventArgs e)
        {
            if(Button_Home.Visible && Button_Previous.Visible && Label_GuestFormDisplayController.Enabled)
            {
                ComboBox_Rooms_SelectedIndexChanged(sender, e);
                ComboBox_Rooms.Focus();
            }
            else if(Button_Home.Visible && Button_Previous.Visible)
            {
                ComboBox_Floors_SelectedIndexChanged(sender, e);
                ComboBox_Rooms.Focus();
            }
            else if(Button_Home.Visible)
            {
                ComboBox_Buildings_SelectedIndexChanged(sender, e); 
                ComboBox_Rooms.Focus();
                //I'm calling this function here because when the floors forms is to be refreshed i.e, when floor is added or deleted from the floorsform, this function updates the ComboBox_Floors and also loads the new FloorsForm. However I was loading a new FloorsForm here but was not able to update the ComboBox_Floors, this issues is solved by this trick.
            }
            else
            {
                //Here BuildingForm is Loaded when the Button_Home is not visible that means, a floor is not yet selected that implies, new building is added or the form is loading for the first time. This also updates the ComboBox_Buildings here itself.
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
                }
                catch (Exception Err)
                {
                    MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                BuildingsForm.buildingsFormInstance.Close();
                LoadForm(new BuildingsForm());
                ComboBox_Buildings.Focus();
            }
        }
        
        private void Button_FormMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button_FormMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Button_FormClose_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you really want to exit?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void LoadForm(object Form)
        {
            Panel_MainPanel.Controls.Clear();
            Form ShowForm = Form as Form;
            ShowForm.TopLevel = false;
            ShowForm.Dock = DockStyle.Fill;
            ShowForm.Tag = ShowForm;
            Panel_MainPanel.Controls.Add(ShowForm);
            ShowForm.Show();
        }

        private void ComboBox_Buildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] buildingNameID = ComboBox_Buildings.SelectedItem.ToString().Split('-');

            Properties.Settings.Default.SelectedBuildingName = buildingNameID[0].Trim(); 
            //This is helps to create a folder inside Images/BuildingName/FloorName like format
            
            Properties.Settings.Default.SelectedBuildingID = Regex.Match(buildingNameID[1],@"\d+").Value;
            //This line is very important because it returns the selected_buildingID from which floors of selected building will be displayed both in Floors_ComboBox and FloorsForm OnLoad().

            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
            string query = "SELECT id,floor_name FROM floors where building_id=@ID;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", Properties.Settings.Default.SelectedBuildingID);
            try
            {
                ComboBox_Floors.Items.Clear();
                ComboBox_Floors.Text = "-- Select Floor --";
                con.Open();
                MySqlDataReader FloorsNames = cmd.ExecuteReader();

                while (FloorsNames.Read())
                {
                    ComboBox_Floors.Items.Add(FloorsNames["floor_name"].ToString() + " - " + FloorsNames["id"].ToString());
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FloorsForm.floorsFormInstance.Close();
            LoadForm(new FloorsForm());
            Button_Home.Visible = true;
            ComboBox_Floors.Visible = true;
            ComboBox_Rooms.Visible = false;
            Label_GuestFormDisplayController.Enabled = false;
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
                ComboBox_Rooms.Text = "-- Select Room --";
                con.Open();
                MySqlDataReader RoomsNames = cmd.ExecuteReader();

                while (RoomsNames.Read())
                {
                    ComboBox_Rooms.Items.Add("Room No. " + RoomsNames["room_no"].ToString() + " - " + RoomsNames["id"].ToString());
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RoomsForm.roomsFormInstance.Close();
            LoadForm(new RoomsForm());
            Button_Previous.Visible = true;
            ComboBox_Rooms.Visible = true;
            Label_GuestFormDisplayController.Enabled = false;
        }

        private void ComboBox_Rooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] roomNameID = ComboBox_Rooms.SelectedItem.ToString().Split('-');

            Properties.Settings.Default.SelectedRoomName = roomNameID[0].Trim();

            Properties.Settings.Default.SelectedRoomID = Regex.Match(roomNameID[1], @"\d+").Value;

            GuestsForm.guestsFormInstance.Close();
            LoadForm(new GuestsForm());
            Label_GuestFormDisplayController.Enabled = true;
        }

        private void Timer_TimeUpdaterMainForm_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            Label_DateTimeDisplay.Text = dateTime.ToLongDateString() + ",  " + dateTime.ToShortTimeString();
        }


    }
}
