using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PG_Management_System
{
    public partial class FloorsForm : Form
    {
        public static FloorsForm floorsFormInstance = new FloorsForm();

        public FloorsForm()
        {
            InitializeComponent();
        }

        private void Button_AddFloor_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AddingFloor = true;
            AddBuildingData addBuildingForm = new AddBuildingData();
            addBuildingForm.ShowDialog();
        }

        private void FloorsForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MainForm_SidePanel_Add_Remove_Building_Button)
            {
                Button_AddFloor.Visible = true;
            }
            TableLayoutPanel TableLayout_FloorsDisplay = new TableLayoutPanel
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom,
                AutoScroll = true,
                BackColor = Color.Transparent,
                Location = new System.Drawing.Point(20, 110),
                Size = new Size(700, 350),
            };

            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
            string query = "SELECT * FROM floors WHERE building_id=@BuildingID;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@BuildingID", Properties.Settings.Default.SelectedBuildingID);

            try
            {
                con.Open();
                MySqlDataReader FloorsData = cmd.ExecuteReader();

                int RowCount = 0;

                while (FloorsData.Read())
                {
                    TableLayout_FloorsDisplay.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    TableLayout_FloorsDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                    TableLayout_FloorsDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                    TableLayout_FloorsDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

                    PictureBox PictureBox_FloorImage = new PictureBox
                    {
                        Anchor = AnchorStyles.None,
                        BackColor = Color.Transparent,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        ImageLocation = FloorsData["floor_imageRPath"].ToString() + FloorsData["floor_name"].ToString() + " Image.jpg",
                        Size = new Size(250, 250),
                    };

                    Label Label_FloorName = new Label
                    {
                        Text = FloorsData["floor_name"].ToString(),
                        AutoSize = true,
                        Font = new Font("Cambria", 20, FontStyle.Bold),
                        Anchor = AnchorStyles.None,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    Button Button_DeleteFloor = new Button
                    {
                        Anchor = AnchorStyles.None,
                        AutoSize = true,
                        BackColor = Color.Transparent,
                        FlatStyle = FlatStyle.Flat,
                        Image = Properties.Resources.Delete,
                        Tag = FloorsData["id"].ToString(),
                        Visible = false,
                    };
                    Button_DeleteFloor.FlatAppearance.BorderSize = 0;
                    Button_DeleteFloor.Click += new EventHandler(Button_DeleteFloor_Click);

                    if (Properties.Settings.Default.MainForm_SidePanel_Add_Remove_Building_Button)
                    {
                        Button_DeleteFloor.Visible = true;
                    }

                    TableLayout_FloorsDisplay.Controls.Add(PictureBox_FloorImage, 0, RowCount);
                    TableLayout_FloorsDisplay.Controls.Add(Label_FloorName, 1, RowCount);
                    TableLayout_FloorsDisplay.Controls.Add(Button_DeleteFloor, 2, RowCount);
                    RowCount++;

                }
                this.Controls.Add(TableLayout_FloorsDisplay);
                con.Close();
            }
            catch (Exception Err)
            {
                MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_DeleteFloor_Click(Object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Do you really want to Delete?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                Button getID = sender as Button;
                Properties.Settings.Default.SelectedFloorID = getID.Tag.ToString();

                MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
                string query1 = "SELECT floor_imageRPath FROM floors WHERE id = @ID;";
                string query2 = "DELETE FROM floors WHERE id = @ID;";
                
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                cmd1.Parameters.AddWithValue("@ID", Properties.Settings.Default.SelectedFloorID);

                MySqlCommand cmd2 = new MySqlCommand(query2, con);
                cmd2.Parameters.AddWithValue("@ID", Properties.Settings.Default.SelectedFloorID);

                try
                {
                    string ImageLocation = "No Image";
                    con.Open();
                    MySqlDataReader RImagePath = cmd1.ExecuteReader();
                    if (RImagePath.Read())
                    {
                        ImageLocation = RImagePath["floor_imageRPath"].ToString();
                    }
                    con.Close();

                    con.Open();
                    int res = cmd2.ExecuteNonQuery();
                    if (res > 0)
                    {
                        if (ImageLocation != "No Image")
                        {
                            Directory.Delete(ImageLocation, true);
                        }
                        MessageBox.Show("Floor Deleted Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Unable to Delete Floor", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
                catch (Exception Err)
                {
                    if (Err.Message.Contains("FOREIGN"))
                    {
                        MessageBox.Show("Cannot Delete Floor.\nDelete all rooms in this floor then delete.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


    }
}
