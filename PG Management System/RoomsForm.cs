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
    public partial class RoomsForm : Form
    {
        public static RoomsForm roomsFormInstance = new RoomsForm();

        public RoomsForm()
        {
            InitializeComponent();
        }

        private void Button_AddRoom_Click(object sender, EventArgs e)
        {
            AddBuildingData addBuildingForm = new AddBuildingData();
            addBuildingForm.ShowDialog();
        }

        private void RoomsForm_Load(object sender, EventArgs e)
        {
            TableLayoutPanel TableLayout_RoomsDisplay = new TableLayoutPanel
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom,
                AutoScroll = true,
                BackColor = Color.Transparent,
                Location = new System.Drawing.Point(20, 110),
                Size = new Size(700, 350),
            };

            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
            string query = "SELECT * FROM rooms WHERE floor_id=@FloorID;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@FloorID", Properties.Settings.Default.SelectedFloorID);

            try
            {
                con.Open();
                MySqlDataReader RoomsData = cmd.ExecuteReader();

                int RowCount = 0;

                while (RoomsData.Read())
                {
                    RowCount++;
                    TableLayout_RoomsDisplay.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    TableLayout_RoomsDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                    TableLayout_RoomsDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                    TableLayout_RoomsDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

                    PictureBox PictureBox_RoomImage = new PictureBox
                    {
                        Anchor = AnchorStyles.None,
                        BackColor = Color.Transparent,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        ImageLocation = RoomsData["room_imageRPath"].ToString() + "Room No. " + RoomsData["room_no"].ToString() + " Image.jpg",
                        Size = new Size(250, 250),
                    };


                    Label Label_RoomNo = new Label
                    {
                        Text = RoomsData["room_no"].ToString(),
                        AutoSize = true,
                        Font = new Font("Cambria", 20, FontStyle.Bold),
                        Anchor = AnchorStyles.None,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    Button Button_DeleteRoom = new Button
                    {
                        Anchor = AnchorStyles.None,
                        AutoSize = true,
                        BackColor = Color.Transparent,
                        FlatStyle = FlatStyle.Flat,
                        Image = Properties.Resources.Delete,
                        Tag = RoomsData["id"].ToString(),
                    };
                    Button_DeleteRoom.FlatAppearance.BorderSize = 0;
                    Button_DeleteRoom.Click += new EventHandler(Button_DeleteRoom_Click);

                    TableLayout_RoomsDisplay.Controls.Add(PictureBox_RoomImage, 0, RowCount);
                    TableLayout_RoomsDisplay.Controls.Add(Label_RoomNo, 1, RowCount);
                    TableLayout_RoomsDisplay.Controls.Add(Button_DeleteRoom, 2, RowCount);
                }
                this.Controls.Add(TableLayout_RoomsDisplay);
            }
            catch (Exception Err)
            {
                MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_DeleteRoom_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Do you really want to Delete?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                Button getID = sender as Button;
                Properties.Settings.Default.SelectedRoomID = getID.Tag.ToString();

                MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
                string query = "DELETE FROM rooms WHERE id = @ID;";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", Properties.Settings.Default.SelectedRoomID);

                try
                {
                    con.Open();
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Room Deleted Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Unable to Delete Room", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
