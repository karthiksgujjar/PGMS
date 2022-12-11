using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PG_Management_System
{
    public partial class GuestDetailsForm : Form
    {
        public static GuestDetailsForm guestDetailsFormInstance =  new GuestDetailsForm();

        public GuestDetailsForm()
        {
            InitializeComponent();
        }

        private void GuestDetailsForm_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
            string query = "SELECT id,building_name FROM buildings;";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                ComboBox_Buildings.Items.Clear();
                con.Open();
                MySqlDataReader BuildingsNames = cmd.ExecuteReader();

                while (BuildingsNames.Read())
                {
                    ComboBox_Buildings.Items.Add(BuildingsNames["building_name"].ToString() + " - " + BuildingsNames["id"].ToString());
                }
                con.Close();
            }
            catch (Exception Err)
            {
                MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ComboBox_Buildings.Text = "-- Select Building --";
        }

        private void ComboBox_Buildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableLayout_GuestDetails.Visible = false;
            TableLayout_GuestDetails.Controls.Clear();

            string[] buildingNameID = ComboBox_Buildings.SelectedItem.ToString().Split('-');

            Properties.Settings.Default.SelectedBuildingName = buildingNameID[0].Trim();

            Properties.Settings.Default.SelectedBuildingID = Regex.Match(buildingNameID[1], @"\d+").Value;

            int TableLayout_GuestDetailsRowCount = 0;

            Label Label_BuildingName_TableLayout = new Label
            {
                Anchor = AnchorStyles.None,
                AutoSize = true,
                BackColor = Color.White,
                Dock = DockStyle.Fill,
                Font = new Font("Cambria", 20, FontStyle.Bold),
                Text = Properties.Settings.Default.SelectedBuildingName,
                TextAlign = ContentAlignment.MiddleCenter,
            };

            TableLayout_GuestDetails.SetColumnSpan(Label_BuildingName_TableLayout, 4);
            TableLayout_GuestDetails.Controls.Add(Label_BuildingName_TableLayout, 0, TableLayout_GuestDetailsRowCount);
            TableLayout_GuestDetailsRowCount++;

            string[,] floorsNameID = new string[100,2];

            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
            string query_floors = "SELECT id,floor_name FROM floors where building_id=@ID;";
            MySqlCommand cmd_floors = new MySqlCommand(query_floors, con);
            cmd_floors.Parameters.AddWithValue("@ID",Properties.Settings.Default.SelectedBuildingID);

            try
            {
                int floorsCount = 0;

                con.Open();
                MySqlDataReader floorsData = cmd_floors.ExecuteReader();

                while (floorsData.Read())
                {
                    floorsNameID[floorsCount,0] = floorsData["id"].ToString();
                    floorsNameID[floorsCount,1] = floorsData["floor_name"].ToString();
                    floorsCount++;
                }
                con.Close();

                for (int i = 0; i < floorsCount; i++)
                {
                    TableLayout_GuestDetails.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    TableLayout_GuestDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                    TableLayout_GuestDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                    TableLayout_GuestDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                    TableLayout_GuestDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F)); //For Paid or Not Column

                    Label Label_FloorName_TableLayout = new Label
                    {
                        Anchor = AnchorStyles.None,
                        AutoSize = true,
                        BackColor = Color.White,
                        Dock = DockStyle.Fill,
                        Font = new Font("Cambria", 18, FontStyle.Bold),
                        Text = floorsNameID[i,1],
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    TableLayout_GuestDetails.SetColumnSpan(Label_FloorName_TableLayout, 4);
                    TableLayout_GuestDetails.Controls.Add(Label_FloorName_TableLayout, 0, TableLayout_GuestDetailsRowCount);
                    TableLayout_GuestDetailsRowCount++;


                    string query_rooms = "SELECT id,room_no FROM rooms where floor_id=@ID ORDER BY(room_no);";
                    MySqlCommand cmd_rooms = new MySqlCommand(query_rooms, con);
                    cmd_rooms.Parameters.AddWithValue("@ID", floorsNameID[i,0]);

                    string[,] roomsNoID = new string[100, 2];
                    int roomsCount = 0;

                    try
                    {
                        con.Open();
                        MySqlDataReader roomsData = cmd_rooms.ExecuteReader();

                        while (roomsData.Read())
                        {
                            roomsNoID[roomsCount, 0] = roomsData["id"].ToString();
                            roomsNoID[roomsCount, 1] = "Room No. " + roomsData["room_no"].ToString();
                            roomsCount++;
                        }
                        con.Close();

                        for (int j = 0; j < roomsCount; j++)
                        {
                            TableLayout_GuestDetails.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                            TableLayout_GuestDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                            TableLayout_GuestDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                            TableLayout_GuestDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                            TableLayout_GuestDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F)); //For Paid or Not Column

                            Label Label_RoomName_TableLayout = new Label
                            {
                                Anchor = AnchorStyles.None,
                                AutoSize = true,
                                BackColor = Color.White,
                                Dock = DockStyle.Fill,
                                Font = new Font("Cambria", 16, FontStyle.Bold),
                                Text = roomsNoID[j,1],
                                TextAlign = ContentAlignment.MiddleCenter,
                            };

                            TableLayout_GuestDetails.SetColumnSpan(Label_RoomName_TableLayout, 4);
                            TableLayout_GuestDetails.Controls.Add(Label_RoomName_TableLayout, 0, TableLayout_GuestDetailsRowCount);
                            TableLayout_GuestDetailsRowCount++;

                            string query_guests = "SELECT id,name,mob_no FROM guests where room_id=@ID;";
                            MySqlCommand cmd_guests = new MySqlCommand(query_guests, con);
                            cmd_guests.Parameters.AddWithValue("@ID", roomsNoID[j, 0]);

                            string[,] guestsIDNameMobNo = new string[100, 3];
                            int guestsCount = 0;

                            try
                            {
                                con.Open();
                                MySqlDataReader guestsData = cmd_guests.ExecuteReader();

                                while (guestsData.Read())
                                {
                                    guestsIDNameMobNo[guestsCount, 0] = guestsData["id"].ToString();
                                    guestsIDNameMobNo[guestsCount, 1] = guestsData["name"].ToString();
                                    guestsIDNameMobNo[guestsCount, 2] = guestsData["mob_no"].ToString();
                                    guestsCount++;
                                }
                                con.Close();

                                for (int k = 0; k < guestsCount; k++)
                                {
                                    TableLayout_GuestDetails.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                                    TableLayout_GuestDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                                    TableLayout_GuestDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                                    TableLayout_GuestDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                                    TableLayout_GuestDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F)); //For Paid or Not Column


                                    Label Label_SlNo = new Label
                                    {
                                        Anchor = AnchorStyles.None,
                                        AutoSize = true,
                                        BackColor = Color.White,
                                        Font = new Font("Cambria", 14, FontStyle.Bold),
                                        Text = (k + 1).ToString(),
                                        TextAlign = ContentAlignment.MiddleCenter,
                                    };

                                    Label Label_GuestName = new Label
                                    {
                                        
                                        Anchor = AnchorStyles.None,
                                        AutoSize = true,
                                        BackColor = Color.White,
                                        Font = new Font("Cambria", 14, FontStyle.Bold),
                                        Text = guestsIDNameMobNo[k, 1],
                                        TextAlign = ContentAlignment.MiddleCenter,
                                    };

                                    

                                    Label Label_GuestMobNo = new Label
                                    {
                                        Anchor = AnchorStyles.None,
                                        AutoSize = true,
                                        BackColor = Color.White,
                                        Font = new Font("Cambria", 14, FontStyle.Bold),
                                        Text = guestsIDNameMobNo[k, 2],
                                        TextAlign = ContentAlignment.MiddleCenter,
                                    };

                                    Label Label_FeePaymentStatus = new Label
                                    {
                                        Anchor = AnchorStyles.None,
                                        AutoSize = true,
                                        BackColor = Color.White,
                                        Font = new Font("Cambria", 14, FontStyle.Bold),
                                        //Text = "Paid", // Fee Payment(Paid or Not Paid) with Receipt no. will be displayed i.e., Paid (036) or Not Paid 
                                        TextAlign = ContentAlignment.MiddleCenter,
                                    };

                                    string query_fees = "SELECT receipt_no FROM fees where guest_id=@ID;";
                                    MySqlCommand cmd_fees = new MySqlCommand(query_fees, con);
                                    cmd_fees.Parameters.AddWithValue("@ID", guestsIDNameMobNo[k, 0]);
                                    try
                                    {
                                        con.Open();
                                        MySqlDataReader fees = cmd_fees.ExecuteReader();
                                        if (fees.Read())
                                        {
                                            Label_FeePaymentStatus.Text = "Paid (" + fees["receipt_no"].ToString() + ")";
                                        }
                                        else
                                        {
                                            Label_FeePaymentStatus.Text = " Not Paid";
                                        }
                                        con.Close();
                                    }
                                    catch (Exception Err)
                                    {
                                        MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                    TableLayout_GuestDetails.Controls.Add(Label_SlNo, 0, TableLayout_GuestDetailsRowCount);
                                    TableLayout_GuestDetails.Controls.Add(Label_GuestName, 1, TableLayout_GuestDetailsRowCount);
                                    TableLayout_GuestDetails.Controls.Add(Label_GuestMobNo, 2, TableLayout_GuestDetailsRowCount);
                                    TableLayout_GuestDetails.Controls.Add(Label_FeePaymentStatus, 3, TableLayout_GuestDetailsRowCount);

                                    TableLayout_GuestDetailsRowCount++;
                                }
                            }
                            catch (Exception Err)
                            {
                                MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }

                    }
                    catch (Exception Err)
                    {
                        MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                TableLayout_GuestDetails.Visible = true;
            }
        }
    }
}
