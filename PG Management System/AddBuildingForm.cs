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
    public partial class AddBuildingForm : Form
    {
        string RImagePath = "No Image";
        string PictureBox_ImagePath = "No Image";

        public AddBuildingForm()
        {
            InitializeComponent();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (TextBox_BuildingID.Text == "" || TextBox_BuildingName.Text == "")
            {
                MessageBox.Show("Please enter all fields.", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    if (!(Convert.ToInt32(TextBox_BuildingID.Text) > 0))
                    {
                        throw new FormatException();
                    }
                    if (PictureBox_ImagePath != "No Image")
                    {
                        RImagePath = "Images/" + TextBox_BuildingName.Text + "/"; //RelativeImagePath
                        Directory.CreateDirectory(RImagePath);

                        PictureBox_BuildingImage.Image.Save(RImagePath + TextBox_BuildingName.Text + " Image.jpg", ImageFormat.Jpeg);
                    }
                    MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
                    string query = "INSERT INTO buildings VALUES(@ID,@Name,@ImageRPath);";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", TextBox_BuildingID.Text);
                    cmd.Parameters.AddWithValue("@Name", TextBox_BuildingName.Text);
                    cmd.Parameters.AddWithValue("@ImageRPath", RImagePath);

                    con.Open();
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Building Inserted Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Unable to Insert Building", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter only Positive Numbers in ID Field\n", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextBox_BuildingID.Focus();
                }
                catch (Exception Err)
                {
                    if (Err.Message.Contains("PRIMARY"))
                    {
                        MessageBox.Show("Enter Unique ID.\nID  " + TextBox_BuildingID.Text + "  ALREADY EXISTS!!", "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextBox_BuildingID.Focus();
                    }
                    else if (Err.Message.Contains("generic"))
                    {
                        MessageBox.Show("Don't Leave White Spaces at the end in the Name Field.", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextBox_BuildingName.Focus();
                    }
                    else
                    {
                        MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Button_FormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_FormMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBox_BuildingImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.bmp) | *.png; *.jpg; *.jpeg; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PictureBox_BuildingImage.Image = new Bitmap(ofd.FileName);
                    PictureBox_ImagePath = ofd.FileName;
                }
                catch (Exception Err)
                {
                    PictureBox_BuildingImage.Image = Properties.Resources.Add_Image;
                    MessageBox.Show("Unable to Load the Image\n" + Err.Message, "IMAGE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearForm()
        {
            TextBox_BuildingID.Clear();
            TextBox_BuildingName.Clear();
            PictureBox_BuildingImage.Image = Properties.Resources.Add_Image;
            TextBox_BuildingID.Focus();
        }

    }
}
