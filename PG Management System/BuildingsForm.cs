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
    public partial class BuildingsForm : Form
    {
        public BuildingsForm()
        {
            InitializeComponent();
        }

        private void Button_AddBuilding_Click(object sender, EventArgs e)
        {
            AddBuildingForm addBuildingForm = new AddBuildingForm();
            addBuildingForm.ShowDialog();
        }

        private void BuildingsForm_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
            string query = "SELECT * FROM buildings ;";
            MySqlCommand cmd = new MySqlCommand(query, con);

            TableLayoutPanel TableLayout_BuildingsDisplay = new TableLayoutPanel
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right,
            AutoSize = true,
            BackColor = Color.Transparent,
            Location = new System.Drawing.Point(20, 110),
            };

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
                    TableLayout_BuildingsDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

                    PictureBox PictureBox_BuildingImage = new PictureBox
                    {
                        Anchor = AnchorStyles.None,
                        BackColor = Color.Transparent,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        ImageLocation = BuildingsData["building_imageRPath"].ToString() + BuildingsData["building_name"].ToString() + " Image.jpg",
                        Size= new Size(250,250),
                    };

                    Label Label_BuildingName = new Label
                    {
                        Text = BuildingsData["building_name"].ToString(),
                        AutoSize = true,
                        Font = new Font("Cambria", 12, FontStyle.Italic),
                        Anchor = AnchorStyles.None,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    Button Button_EditBuildingDeatils = new Button
                    {
                        Text = "EDIT",
                        AutoSize = true,
                        Font = new Font("Cambria", 12, FontStyle.Italic),
                        Anchor = AnchorStyles.None,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    Button Button_DeleteBuilding = new Button
                    {
                        Text = "DELETE",
                        AutoSize = true,
                        Font = new Font("Cambria", 12, FontStyle.Italic),
                        Anchor = AnchorStyles.None,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    TableLayout_BuildingsDisplay.Controls.Add(PictureBox_BuildingImage, 0, RowCount);
                    TableLayout_BuildingsDisplay.Controls.Add(Label_BuildingName, 1, RowCount);
                    TableLayout_BuildingsDisplay.Controls.Add(Button_EditBuildingDeatils, 2, RowCount);
                    TableLayout_BuildingsDisplay.Controls.Add(Button_DeleteBuilding, 3, RowCount);
                }
                if (BuildingsData.HasRows)
                {
                    this.Controls.Add(TableLayout_BuildingsDisplay);
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void BuildingsForm_Activated(object sender, EventArgs e)
        {
            BuildingsForm_Load(sender, e);
        }
    }
}
