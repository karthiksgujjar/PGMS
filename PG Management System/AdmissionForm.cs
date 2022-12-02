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
        
        private void Button_Admit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(Convert.ToInt64(TextBox_GuestMobileNo.Text) > 0) || !(Convert.ToInt64(TextBox_GuestAadhaarNo.Text) > 0))
                {
                    throw new FormatException();
                }

                if (PictureBox_ImagePath != "No Image")
                {
                    RImagePath = "Images/" + Properties.Settings.Default.SelectedBuildingName + "/" + Properties.Settings.Default.SelectedFloorName + "/" + Properties.Settings.Default.SelectedRoomName + "/"; //RelativeImagePath
                    Directory.CreateDirectory(RImagePath);

                    PictureBox_GuestImage.Image.Save(RImagePath + TextBox_GuestName.Text + " Image.jpg", ImageFormat.Jpeg);
                }
                MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
                string query = "INSERT INTO guests VALUES(@ID,@RoomID,@Name,@PhNo,@AadhaarNo,@ImageRPath);";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", Properties.Settings.Default.SelectedRoomID + TextBox_GuestAadhaarNo.Text);
                cmd.Parameters.AddWithValue("@RoomID", Properties.Settings.Default.SelectedRoomID);
                cmd.Parameters.AddWithValue("@Name", TextBox_GuestName.Text);
                cmd.Parameters.AddWithValue("@PhNo", TextBox_GuestMobileNo.Text);
                cmd.Parameters.AddWithValue("AadhaarNo", TextBox_GuestAadhaarNo.Text);
                cmd.Parameters.AddWithValue("@ImageRPath", RImagePath);

                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Guest Admitted Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unable to Admit Guest", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter only Positive Numbers for Mobile No. and AADHAAR No. Field\n", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void AdmissionForm_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.GuestFormAddGuestButton)
            {
                this.BackColor = Color.LightGray;
                TextBox_GuestName.BackColor = Color.LightGray;
                TextBox_GuestMobileNo.BackColor = Color.LightGray;
                TextBox_GuestMailID.BackColor = Color.LightGray;
                TextBox_GuestAddress.BackColor = Color.LightGray;
                TextBox_GuestAadhaarNo.BackColor = Color.LightGray;
                Button_FormClose.Visible = true;
            }
        }

        private void Button_FormClose_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.GuestFormAddGuestButton = false;
            this.Close();
        }
    }
}
