using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace PG_Management_System
{
    public partial class GetDBDetailsForm : Form
    {
        public GetDBDetailsForm()
        {
            InitializeComponent();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (TextBox_ServerName.Text == "")
            {
                ErrorProvider_GetDBDetailsForm.SetError(TextBox_ServerName, "Server Name not Entered");
                TextBox_ServerName.Focus();
            }
            else if (TextBox_UserName.Text == "")
            {
                ErrorProvider_GetDBDetailsForm.SetError(TextBox_UserName, "User Name not Entered");
                TextBox_UserName.Focus();
            }
            else if (TextBox_Password.Text == "")
            {
                ErrorProvider_GetDBDetailsForm.SetError(TextBox_Password, "Password not Entered");
                TextBox_Password.Focus();
            }
            else
            {
                Properties.Settings.Default.constring =  "SERVER = " + TextBox_ServerName.Text + "; UID = " + TextBox_UserName.Text + "; Password = " + TextBox_Password.Text;
                string CreateDB_UseDB_CreateTables_Query = 
                               "CREATE DATABASE pgms;" +

                               "USE pgms;" +

                               "CREATE TABLE login(username VARCHAR(10) NOT NULL, password VARCHAR(50) NOT NULL, PRIMARY KEY(username));" +

                               "CREATE TABLE buildings(id INT(3) NOT NULL, building_name VARCHAR(100) NOT NULL, building_imageRPath VARCHAR(100) NOT NULL, PRIMARY KEY(id));" +

                               "CREATE TABLE floors(id VARCHAR(6) NOT NULL, building_id INT(3) NOT NULL, floor_name VARCHAR(100) NOT NULL, floor_imageRPath VARCHAR(200) NOT NULL, PRIMARY KEY(id), FOREIGN KEY(building_id) REFERENCES buildings(id));" +

                               "CREATE TABLE rooms(id VARCHAR(9) NOT NULL, floor_id VARCHAR(6) NOT NULL, room_no SMALLINT NOT NULL, room_imageRPath VARCHAR(300) NOT NULL, PRIMARY KEY(id), FOREIGN KEY(floor_id) REFERENCES floors(id));" +

                               "CREATE TABLE guests(id VARCHAR(21) NOT NULL, room_id VARCHAR(9) NOT NULL, name VARCHAR(100) NOT NULL, dob VARCHAR(10) NOT NULL, mob_no INT(10) NOT NULL, mail_id VARCHAR(100) NOT NULL, aadhaar_no INT(12) NOT NULL, blood_group VARCHAR(3) NOT NULL, parent_guardian_name VARCHAR(100) NOT NULL, emergency_contactno INT(10) NOT NULL, doj VARCHAR(10) NOT NULL, p_address VARCHAR(100) NOT NULL, advance_amount INT(10) NOT NULL, amount_per_month INT(10) NOT NULL, guest_imageRPath VARCHAR(400) NOT NULL, PRIMARY KEY(id), FOREIGN KEY(room_id) REFERENCES rooms(id));" +

                               "CREATE TABLE fees( guest_id VARCHAR(21) NOT NULL, receipt_no INT NOT NULL, mode VARCHAR(50) NOT NULL, amount INT NOT NULL, dop VARCHAR(20) NOT NULL, PRIMARY KEY(receipt_no), FOREIGN KEY(guest_id) REFERENCES guests(id));" +

                               "CREATE TABLE visitors(poi VARCHAR(25) NOT NULL,guest_id VARCHAR(255) NOT NULL,name VARCHAR(100) NOT NULL,mob_no VARCHAR(10) NOT NULL,relate VARCHAR(50) NOT NULL,visit_date_time VARCHAR(50) NOT NULL,reason VARCHAR(500) NOT NULL,FOREIGN KEY(guest_id) REFERENCES guests(id));" +

                               "INSERT INTO login VALUES ('owner','owner');";

                MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
                MySqlCommand cmd = new MySqlCommand(CreateDB_UseDB_CreateTables_Query, con);

                try
                {
                    con.Open();
                    int res = cmd.ExecuteNonQuery();
                    
                    if (res > 1) 
                    {
                        MessageBox.Show("Successfully Connected to the Server!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Properties.Settings.Default.constring = "SERVER = " + TextBox_ServerName.Text + ";DATABASE=pgms; UID = " + TextBox_UserName.Text + "; Password = " + TextBox_Password.Text;
                        Properties.Settings.Default.Save();
                    }
                    con.Close();
                }
                catch (Exception Err)
                {
                    MessageBox.Show("Unable to Connect to the Server\n" + Err.Message, "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
    }
}
