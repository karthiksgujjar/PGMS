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
        }
        
        private void MainForm_Activated(object sender, EventArgs e)
        {
            
            if( Button_Home.Visible )
            {
                ComboBox_Buildings_SelectedIndexChanged(sender, e); //I'm calling this function here because when the floors forms is to be refreshed i.e, when floor is added or deleted from the floorsform, this function updates the ComboBox_Floors and also loads the new FloorsForm. However I was loading a new FloorsForm here but was not able to update the ComboBox_Floors, this issues is solved by this trick.
            }
            else if(Button_Home.Visible && Button_Previous.Visible )
            {
                LoadForm(new RoomsForm());
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
                        ComboBox_Buildings.Items.Add(BuildingsNames["building_name"].ToString() + " -- " + BuildingsNames["id"].ToString());
                    }
                }
                catch (Exception Err)
                {
                    MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                BuildingsForm.buildingsFormInstance.Close();
                LoadForm(new BuildingsForm());
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
            Properties.Settings.Default.SelectedBuildingID = 
                Regex.Match(ComboBox_Buildings.SelectedItem.ToString(),@"\d+").Value; //This line is very important because it returns the selected_buildingID from which floors of selected building will be displayed both in Floors_ComboBox and FloorsForm OnLoad().

            Properties.Settings.Default.SelectedBuildingName = 
                string.Concat(ComboBox_Buildings.SelectedItem.ToString().Where(char.IsLetter)); //This is helps to create a folder inside Images/BuildingName/FloorName like format

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
                    ComboBox_Floors.Items.Add(FloorsNames["floor_name"].ToString() + " -- " + FloorsNames["id"].ToString());
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
        }

        private void Button_Previous_Click(object sender, EventArgs e)
        {
        }

        private void Button_Home_Click(object sender, EventArgs e)
        {
            Button_Home.Visible = false;
            ComboBox_Floors.Visible = false;
            ComboBox_Buildings.Text = "-- Select Building --";
            BuildingsForm.buildingsFormInstance.Close();
            LoadForm(new BuildingsForm());
        }

    }
}
