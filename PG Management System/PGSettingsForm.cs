using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PG_Management_System
{
    public partial class PGSettingsForm : Form
    {
        public static PGSettingsForm pgSettingsFormInstance = new PGSettingsForm();
        public PGSettingsForm()
        {
            InitializeComponent();
        }

        private void Button_Edit_Click(object sender, EventArgs e)
        {
            TextBox_PGName.Enabled = true;
            TextBox_PGAddress.Enabled = true;
            TextBox_OwnerName.Enabled = true;
            TextBox_OwnerMobileNo.Enabled = true;
            TextBox_OwnerMailID.Enabled = true;
            TextBox_OwnerLoginPassword.Enabled = true;
            CheckBox_Staff1.Enabled = true;
            CheckBox_Staff2.Enabled = true;
            TextBox_Staff1Password.Enabled = true;
            TextBox_Staff2Password.Enabled = true;
            Button_Save.Enabled = true;
        }

        private void PGSettingsForm_Load(object sender, EventArgs e)
        {
            TextBox_PGName.Text = Properties.Settings.Default.PGName;
            TextBox_PGAddress.Text = Properties.Settings.Default.PGAddress;
            TextBox_OwnerName.Text = Properties.Settings.Default.OwnerName;
            TextBox_OwnerMobileNo.Text = Properties.Settings.Default.OwnerMobNo;
            TextBox_OwnerMailID.Text = Properties.Settings.Default.OwnerMailID;
            TextBox_OwnerLoginPassword.Text = Properties.Settings.Default.OwnerPassword;
            TextBox_Staff1Password.Text = Properties.Settings.Default.Staff1Password;
            TextBox_Staff2Password.Text = Properties.Settings.Default.Staff2Password;

            if (Properties.Settings.Default.Staff1Selected)
                CheckBox_Staff1.Checked = true;

            if(Properties.Settings.Default.Staff2Selected)
                CheckBox_Staff2.Checked = true;
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PGName = TextBox_PGName.Text;
            Properties.Settings.Default.PGAddress = TextBox_PGAddress.Text;
            Properties.Settings.Default.OwnerName = TextBox_OwnerName.Text;
            Properties.Settings.Default.OwnerMobNo = TextBox_OwnerMobileNo.Text;
            Properties.Settings.Default.OwnerMailID = TextBox_OwnerMailID.Text;
            Properties.Settings.Default.Save();

            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
            MySqlCommand cmd = new MySqlCommand();
            
            string query = "UPDATE login SET password=@OwnerPWD WHERE username=\"owner\";";
            cmd.Parameters.AddWithValue("@OwnerPWD",TextBox_OwnerLoginPassword.Text);

            if (CheckBox_Staff1.Checked)
            {
                query += "UPDATE login SET password=@Staff1PWD WHERE username=\"staff1\";";
                cmd.Parameters.AddWithValue("@Staff1PWD", TextBox_Staff1Password.Text);
            }

            if (CheckBox_Staff2.Checked)
            {
                query += "UPDATE login SET password=@Staff2PWD WHERE username=\"staff2\";";
                cmd.Parameters.AddWithValue("@Staff2PWD", TextBox_Staff2Password.Text);
            }
            cmd.CommandText = query;
            cmd.Connection = con;

            try
            {
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res >= 1)
                {
                    Properties.Settings.Default.OwnerPassword = TextBox_OwnerLoginPassword.Text;
                    Properties.Settings.Default.Staff1Password = TextBox_Staff1Password.Text;
                    Properties.Settings.Default.Staff2Password = TextBox_Staff2Password.Text;
                    Properties.Settings.Default.Save();

                    MessageBox.Show("Details Saved Successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextBox_PGName.Enabled = false;
                    TextBox_PGAddress.Enabled = false;
                    TextBox_OwnerName.Enabled = false;
                    TextBox_OwnerMobileNo.Enabled = false;
                    TextBox_OwnerMailID.Enabled = false;
                    TextBox_OwnerLoginPassword.Enabled = false;
                    CheckBox_Staff1.Enabled = false;
                    CheckBox_Staff2.Enabled = false;
                    TextBox_Staff1Password.Enabled = false;
                    TextBox_Staff2Password.Enabled = false;
                    Button_Save.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Unable to Update Passwords.", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                con.Close();
            }
            catch (Exception Err)
            {
                MessageBox.Show("Unable to make connection to Database\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckBox_Staff1_CheckedChanged(object sender, EventArgs e)
        {
            string query = null;
            if (CheckBox_Staff1.Checked)
            {
                query = "INSERT INTO login VALUES ('staff1','staff1');";
                TextBox_Staff1Password.Visible = true;
                Label_Staff1PasswordUnderbar.Visible = true;
                Properties.Settings.Default.Staff1Selected = true;
                Properties.Settings.Default.Staff1Password = "staff1";
                Properties.Settings.Default.Save();
            }
            else
            {
                query = "DELETE FROM login WHERE username='staff1'";
                TextBox_Staff1Password.Visible = false;
                Label_Staff1PasswordUnderbar.Visible = false;
                Properties.Settings.Default.Staff1Selected = false;
                Properties.Settings.Default.Staff1Password = "";

                Properties.Settings.Default.Save();
            }
            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception Err)
            { }
        }

        private void CheckBox_Staff2_CheckedChanged(object sender, EventArgs e)
        {
            string query = null;
            if( CheckBox_Staff2.Checked)
            {
                query = "INSERT INTO login VALUES ('staff2','staff2');";
                TextBox_Staff2Password.Visible = true;
                Label_Staff2PasswordUnderbar.Visible = true;
                Properties.Settings.Default.Staff2Selected = true;
                Properties.Settings.Default.Staff2Password = "staff2";
                Properties.Settings.Default.Save();
            }
            else
            {
                query = "DELETE FROM login WHERE username='staff2'";
                TextBox_Staff2Password.Visible = false;
                Label_Staff2PasswordUnderbar.Visible = false;
                Properties.Settings.Default.Staff2Selected = false;
                Properties.Settings.Default.Staff2Password = "";
                Properties.Settings.Default.Save();
            }
            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception Err)
            { }
        }
    }
}
