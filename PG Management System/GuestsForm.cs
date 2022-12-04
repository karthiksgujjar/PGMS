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
        
        private void Button_AddGuest_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.GuestFormAddGuestButton = true;
            AdmissionForm admissionForm = new AdmissionForm();
            admissionForm.ShowDialog();
        }
        
        private void GuestsForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MainForm_SidePanel_Add_Remove_Building_Button)
            {
                Button_AddGuest.Visible = true;
            }
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
                    RowCount++;
                    TableLayout_GuestsDisplay.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    TableLayout_GuestsDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
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

                    Button Button_RemoveGuest = new Button
                    {
                        Anchor = AnchorStyles.None,
                        AutoSize = true,
                        BackColor = Color.Transparent,
                        FlatStyle = FlatStyle.Flat,
                        Image = Properties.Resources.Delete,
                        Tag = GuestsData["id"].ToString(),
                        Visible = false,
                    };
                    Button_RemoveGuest.FlatAppearance.BorderSize = 0;
                    Button_RemoveGuest.Click += new EventHandler(Button_RemoveGuest_Click);

                    if (Properties.Settings.Default.MainForm_SidePanel_Add_Remove_Building_Button)
                    {
                        Button_RemoveGuest.Visible = true;
                    }

                    TableLayout_GuestsDisplay.Controls.Add(PictureBox_GuestImage, 0, RowCount);
                    TableLayout_GuestsDisplay.Controls.Add(Label_GuestName, 1, RowCount);
                    TableLayout_GuestsDisplay.Controls.Add(Label_GuestMobNo, 2, RowCount);
                    TableLayout_GuestsDisplay.Controls.Add(Button_RemoveGuest, 3, RowCount);
                }
                this.Controls.Add(TableLayout_GuestsDisplay);
                con.Close();
            }
            catch (Exception Err)
            {
                MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void Button_RemoveGuest_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Do you really want to Delete?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                Button getID = sender as Button;
                Properties.Settings.Default.SelectedGuestID = getID.Tag.ToString();

                MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
                string query1 = "SELECT guest_imageRPath FROM guests WHERE id = @ID;";
                string query2 = "DELETE FROM guests WHERE id = @ID;";

                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                cmd1.Parameters.AddWithValue("@ID", Properties.Settings.Default.SelectedGuestID);

                MySqlCommand cmd2 = new MySqlCommand(query2, con);
                cmd2.Parameters.AddWithValue("@ID", Properties.Settings.Default.SelectedGuestID);

                try
                {
                    string ImageLocation = "No Image";
                    con.Open();
                    MySqlDataReader RImagePath = cmd1.ExecuteReader();
                    if (RImagePath.Read())
                    {
                        ImageLocation = RImagePath["guest_imageRPath"].ToString();
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
                        MessageBox.Show("Guest Removed Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Unable to Remove Guest", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
                catch (Exception Err)
                {
                    if (Err.Message.Contains("FOREIGN"))
                    {
                        MessageBox.Show("Cannot Delete Room.\nRemove all guests from this room then delete.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
