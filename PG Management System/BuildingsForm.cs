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
    public partial class BuildingsForm : Form
    {
        public static BuildingsForm buildingsFormInstance = new BuildingsForm();
        
        public BuildingsForm()
        {
            InitializeComponent();
        }

        private void Button_AddBuilding_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AddingBuilding = true;
            AddBuildingData addBuildingForm = new AddBuildingData();
            addBuildingForm.ShowDialog();
        }

        private void BuildingsForm_Load(object sender, EventArgs e)
        {
            TableLayoutPanel TableLayout_BuildingsDisplay = new TableLayoutPanel
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom,
                AutoScroll = true,
                BackColor = Color.Transparent,
                Location = new System.Drawing.Point(20, 110),
                Size = new Size(700, 350),
            };

            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
            string query = "SELECT * FROM buildings;";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                MySqlDataReader BuildingsData = cmd.ExecuteReader();

                int RowCount = 0;

                while (BuildingsData.Read())
                {
                    RowCount++;
                    TableLayout_BuildingsDisplay.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    TableLayout_BuildingsDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                    TableLayout_BuildingsDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                    TableLayout_BuildingsDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

                    PictureBox PictureBox_BuildingImage = new PictureBox
                    {
                        Anchor = AnchorStyles.None,
                        BackColor = Color.Transparent,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        ImageLocation = BuildingsData["building_imageRPath"].ToString() + BuildingsData["building_name"].ToString() + " Image.jpg",
                        Size = new Size(250, 250),
                    };
                    

                    Label Label_BuildingName = new Label
                    {
                        Text = BuildingsData["building_name"].ToString(),
                        AutoSize = true,
                        Font = new Font("Cambria", 20, FontStyle.Bold),
                        Anchor = AnchorStyles.None,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };
                    
                    Button Button_DeleteBuilding = new Button
                    {
                        Anchor = AnchorStyles.None,
                        AutoSize = true,
                        BackColor = Color.Transparent,
                        FlatStyle = FlatStyle.Flat,
                        Image = Properties.Resources.Delete,
                        Tag = BuildingsData["id"].ToString(),
                    };
                    Button_DeleteBuilding.FlatAppearance.BorderSize = 0;
                    Button_DeleteBuilding.Click += new EventHandler(Button_DeleteBuilding_Click);

                    TableLayout_BuildingsDisplay.Controls.Add(PictureBox_BuildingImage, 0, RowCount);
                    TableLayout_BuildingsDisplay.Controls.Add(Label_BuildingName, 1, RowCount);
                    TableLayout_BuildingsDisplay.Controls.Add(Button_DeleteBuilding, 2, RowCount);
                }
                this.Controls.Add(TableLayout_BuildingsDisplay);
                con.Close();
            }
            catch (Exception Err)
            {
                MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_DeleteBuilding_Click(Object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Do you really want to Delete?","CONFIRMATION",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                Button getID = sender as Button;
                Properties.Settings.Default.SelectedBuildingID = getID.Tag.ToString();

                MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
                string query1 = "SELECT building_imageRPath FROM buildings WHERE id = @ID;"; 
                string query2 = "DELETE FROM buildings WHERE id = @ID;";

                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                cmd1.Parameters.AddWithValue("@ID", Properties.Settings.Default.SelectedBuildingID);

                MySqlCommand cmd2 = new MySqlCommand(query2, con);
                cmd2.Parameters.AddWithValue("@ID", Properties.Settings.Default.SelectedBuildingID);

                try
                {
                    string ImageLocation = "No Image";
                    con.Open();
                    MySqlDataReader RImagePath = cmd1.ExecuteReader();
                    if (RImagePath.Read())
                    {
                        ImageLocation = RImagePath["building_imageRPath"].ToString();
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
                        MessageBox.Show("Building Deleted Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Unable to Delete Building", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
                catch (Exception Err)
                {
                    if (Err.Message.Contains("FOREIGN"))
                    {
                        MessageBox.Show("Cannot Delete Building.\nDelete all floors in this building then delete.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
