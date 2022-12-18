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
    public partial class GetPGOwnerDetails : Form
    {
        public GetPGOwnerDetails()
        {
            InitializeComponent();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (TextBox_OwnerName.Text == "")
            {
                ErrorProvider_GetPGOwnerDetailsForm.SetError(TextBox_OwnerName, "Owner Name not Entered");
                TextBox_OwnerName.Focus();
            }
            else if (TextBox_OwnerMobileNo.Text == "")
            {
                ErrorProvider_GetPGOwnerDetailsForm.SetError(TextBox_OwnerMobileNo, "Owner Mobile Number not Entered");
                TextBox_OwnerMobileNo.Focus();
            }
            else if (TextBox_OwnerMailID.Text == "")
            {
                ErrorProvider_GetPGOwnerDetailsForm.SetError(TextBox_OwnerMailID, "Owner e-Mail ID not Entered");
                TextBox_OwnerMailID.Focus();
            }
            else if (TextBox_OwnerPassword.Text == "") 
            {
                ErrorProvider_GetPGOwnerDetailsForm.SetError(TextBox_OwnerPassword, "Password for owner not Entered");
                TextBox_OwnerPassword.Focus();
            }
            else
            {
                Properties.Settings.Default.OwnerName = TextBox_OwnerName.Text;
                Properties.Settings.Default.OwnerMobNo = TextBox_OwnerMobileNo.Text;
                Properties.Settings.Default.OwnerMailID = TextBox_OwnerMailID.Text;
                Properties.Settings.Default.Save();
                string query = "UPDATE login SET password='" + TextBox_OwnerPassword.Text + "' WHERE username='owner';";                               

                MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
                MySqlCommand cmd = new MySqlCommand(query, con);

                try
                {
                    con.Open();
                    int res = cmd.ExecuteNonQuery();

                    if (res == 1)
                    {
                        MessageBox.Show("Successfully Saved Owner Details!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
