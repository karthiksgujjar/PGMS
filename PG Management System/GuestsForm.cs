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
    public partial class GuestsForm : Form
    {
        public static GuestsForm guestsFormInstance = new GuestsForm();

        public GuestsForm()
        {
            InitializeComponent();
        }
        
        private void GuestsForm_Load(object sender, EventArgs e)
        {
            TableLayoutPanel TableLayout_GuestsDisplay = new TableLayoutPanel
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom,
                AutoScroll = true,
                BackColor = Color.Transparent,
                Location = new System.Drawing.Point(20, 110),
                Size = new Size(700, 350),
            };

            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
            string query = "SELECT id,name,mob_no,guest_imageRPath FROM guests WHERE room_id=@RoomID;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@RoomID", Properties.Settings.Default.SelectedRoomID);

            try
            {
                con.Open();
                MySqlDataReader GuestsData = cmd.ExecuteReader();

                int RowCount = 0;

                while (GuestsData.Read())
                {
                    TableLayout_GuestsDisplay.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    TableLayout_GuestsDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                    TableLayout_GuestsDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                    TableLayout_GuestsDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

                    PictureBox PictureBox_GuestImage = new PictureBox
                    {
                        Anchor = AnchorStyles.None,
                        BackColor = Color.Transparent,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        ImageLocation = GuestsData["guest_imageRPath"].ToString() + GuestsData["name"].ToString() + " Image.jpg",
                        Size = new Size(250, 250),
                    };

                    Label Label_GuestName = new Label
                    {
                        Text = GuestsData["name"].ToString(),
                        AutoSize = true,
                        Font = new Font("Cambria", 20, FontStyle.Bold),
                        Anchor = AnchorStyles.None,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    Label Label_GuestMobNo = new Label
                    {
                        Text = GuestsData["mob_no"].ToString(),
                        AutoSize = true,
                        Font = new Font("Cambria", 20, FontStyle.Bold),
                        Anchor = AnchorStyles.None,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    TableLayout_GuestsDisplay.Controls.Add(PictureBox_GuestImage, 0, RowCount);
                    TableLayout_GuestsDisplay.Controls.Add(Label_GuestName, 1, RowCount);
                    TableLayout_GuestsDisplay.Controls.Add(Label_GuestMobNo, 2, RowCount);
                    RowCount++;

                }
                this.Controls.Add(TableLayout_GuestsDisplay);
                con.Close();
            }
            catch (Exception Err)
            {
                MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
