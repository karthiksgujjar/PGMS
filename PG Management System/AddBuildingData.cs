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
    public partial class AddBuildingData : Form
    {
        string RImagePath = "No Image";
        string PictureBox_ImagePath = "No Image";

        public AddBuildingData()
        {
            InitializeComponent();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (TextBox_BuildingDataID.Text == "" || TextBox_BuildingDataName.Text == "")
            {
                MessageBox.Show("Please enter all fields.", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    if (!(Convert.ToInt32(TextBox_BuildingDataID.Text) > 0))
                    {
                        throw new FormatException();
                    }
                    if(Properties.Settings.Default.AddingBuilding)
                    {
                        if (PictureBox_ImagePath != "No Image")
                        {
                            RImagePath = "Images/" + TextBox_BuildingDataName.Text + "/"; //RelativeImagePath
                            Directory.CreateDirectory(RImagePath);

                            PictureBox_BuildingDataImage.Image.Save(RImagePath + TextBox_BuildingDataName.Text + " Image.jpg", ImageFormat.Jpeg);
                        }
                        MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
                        string query = "INSERT INTO buildings VALUES(@ID,@Name,@ImageRPath);";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@ID", TextBox_BuildingDataID.Text);
                        cmd.Parameters.AddWithValue("@Name", TextBox_BuildingDataName.Text);
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
                    else if(Properties.Settings.Default.AddingFloor)
                    {
                        if (PictureBox_ImagePath != "No Image")
                        {
                            RImagePath = "Images/" + Properties.Settings.Default.SelectedBuildingName + "/" + TextBox_BuildingDataName.Text + "/"; //RelativeImagePath
                            Directory.CreateDirectory(RImagePath);

                            PictureBox_BuildingDataImage.Image.Save(RImagePath + TextBox_BuildingDataName.Text + " Image.jpg", ImageFormat.Jpeg);
                        }
                        MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
                        string query = "INSERT INTO floors VALUES(@ID,@BuildingID,@Name,@ImageRPath);";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@ID", Properties.Settings.Default.SelectedBuildingID + TextBox_BuildingDataID.Text);
                        cmd.Parameters.AddWithValue("@BuildingID", Properties.Settings.Default.SelectedBuildingID);
                        cmd.Parameters.AddWithValue("@Name", TextBox_BuildingDataName.Text);
                        cmd.Parameters.AddWithValue("@ImageRPath", RImagePath);

                        con.Open();
                        int res = cmd.ExecuteNonQuery();
                        if (res > 0)
                        {
                            MessageBox.Show("Floor Inserted Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("Unable to Insert Floor", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        Label_BuildingDataName.Location = new Point(18, 351);
                        Label_BuildingDataName.Text = "Room No :";
                        if (PictureBox_ImagePath != "No Image")
                        {
                            RImagePath = "Images/" + Properties.Settings.Default.SelectedBuildingName + "/" + Properties.Settings.Default.SelectedFloorName + "/Room No. " + TextBox_BuildingDataName.Text + "/"; //RelativeImagePath
                            Directory.CreateDirectory(RImagePath);

                            PictureBox_BuildingDataImage.Image.Save(RImagePath + "Room No. " + TextBox_BuildingDataName.Text + " Image.jpg", ImageFormat.Jpeg);
                        }
                        MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
                        string query = "INSERT INTO rooms VALUES(@ID,@FloorID,@Name,@ImageRPath);";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@ID", Properties.Settings.Default.SelectedFloorID + TextBox_BuildingDataID.Text);
                        cmd.Parameters.AddWithValue("@FloorID", Properties.Settings.Default.SelectedFloorID);
                        cmd.Parameters.AddWithValue("@Name", TextBox_BuildingDataName.Text);
                        cmd.Parameters.AddWithValue("@ImageRPath", RImagePath);

                        con.Open();
                        int res = cmd.ExecuteNonQuery();
                        if (res > 0)
                        {
                            MessageBox.Show("Room Inserted Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("Unable to Insert Room", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter only Positive Numbers in ID Field\n", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextBox_BuildingDataID.Focus();
                }
                catch (Exception Err)
                {
                    if (Err.Message.Contains("PRIMARY"))
                    {
                        MessageBox.Show("Enter Unique ID.\nID  " + TextBox_BuildingDataID.Text + "  ALREADY EXISTS!!", "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextBox_BuildingDataID.Focus();
                    }
                    else if (Err.Message.Contains("generic"))
                    {
                        MessageBox.Show("Don't Leave White Spaces at the end in the Name Field.", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextBox_BuildingDataName.Focus();
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
            Properties.Settings.Default.AddingBuilding = false;
            Properties.Settings.Default.AddingFloor = false;
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
                    PictureBox_BuildingDataImage.Image = new Bitmap(ofd.FileName);
                    PictureBox_ImagePath = ofd.FileName;
                }
                catch (Exception Err)
                {
                    PictureBox_BuildingDataImage.Image = Properties.Resources.Add_Image;
                    MessageBox.Show("Unable to Load the Image\n" + Err.Message, "IMAGE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearForm()
        {
            TextBox_BuildingDataID.Clear();
            TextBox_BuildingDataName.Clear();
            PictureBox_BuildingDataImage.Image = Properties.Resources.Add_Image;
            TextBox_BuildingDataID.Focus();
        }

    }
}
