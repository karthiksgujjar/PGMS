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
    public partial class FloorsForm : Form
    {
        public static FloorsForm floorsFormInstance = new FloorsForm();

        public FloorsForm()
        {
            InitializeComponent();
        }

        private void Button_AddFloor_Click(object sender, EventArgs e)
        {
            AddFloorForm addFloorForm = new AddFloorForm();
            addFloorForm.ShowDialog();
        }

        private void FloorsForm_Load(object sender, EventArgs e)
        {
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
                    RowCount++;
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
                    };
                    Button_DeleteFloor.FlatAppearance.BorderSize = 0;
                    Button_DeleteFloor.Click += new EventHandler(Button_DeleteFloor_Click);

                    TableLayout_FloorsDisplay.Controls.Add(PictureBox_FloorImage, 0, RowCount);
                    TableLayout_FloorsDisplay.Controls.Add(Label_FloorName, 1, RowCount);
                    TableLayout_FloorsDisplay.Controls.Add(Button_DeleteFloor, 2, RowCount);
                }
                this.Controls.Add(TableLayout_FloorsDisplay);
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
                string query = "DELETE FROM floors WHERE id = @ID;";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", Properties.Settings.Default.SelectedFloorID);

                try
                {
                    con.Open();
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Floor Deleted Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Unable to Delete Floor", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception Err)
                {
                    MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
