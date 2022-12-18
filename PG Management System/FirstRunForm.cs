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
    public partial class FirstRunForm : Form
    {
        int ProgressCount = 0;

        public FirstRunForm()
        {
            InitializeComponent();
        }

        private void Button_FormClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_FormMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FirstRunForm_Load(object sender, EventArgs e)
        {
            LoadForm(new GetDBDetailsForm());
            Label_FormProgress1.Enabled = true;
        }

        public void LoadForm(object Form)
        {
            Panel_DetailsCollector.Controls.Clear();
            Form ShowForm = Form as Form;
            ShowForm.TopLevel = false;
            ShowForm.Dock = DockStyle.Fill;
            ShowForm.Tag = ShowForm;
            Panel_DetailsCollector.Controls.Add(ShowForm);
            ShowForm.Show();
        }

        private void Button_Next_Click(object sender, EventArgs e)
        {
            if (Label_FormProgress4.Enabled == true)
            {
                Label_FormProgress4.Image = Properties.Resources.C4Color;
                Label_FormStatusCompleteBar4.BackColor = Color.FromArgb(255, 128, 0);
                Label_FormProgress5.Enabled = true;
            }
            else if (Label_FormProgress3.Enabled == true)
            {
                Label_FormProgress3.Image = Properties.Resources.C3Color;
                Label_FormStatusCompleteBar3.BackColor = Color.FromArgb(255, 128, 0);
                Label_FormProgress4.Enabled = true;
            }
            else if (Label_FormProgress2.Enabled == true)
            {
                Label_FormProgress2.Image = Properties.Resources.C2Color;
                Label_FormStatusCompleteBar2.BackColor = Color.FromArgb(255, 128, 0);
                Label_FormProgress3.Enabled = true;
                LoadForm(new GetPGOwnerDetails());
            }
            else
            {
                Label_FormProgress1.Image = Properties.Resources.C1Color;
                Label_FormStatusCompleteBar1.BackColor = Color.FromArgb(255, 128, 0);
                Label_FormProgress2.Enabled = true;
                Button_Previous.Visible = true;
                LoadForm(new GetPGDetails());
            }   
        }

        private void Button_Previous_Click(object sender, EventArgs e)
        {
            if (Label_FormProgress5.Enabled == true)
            {
                Label_FormProgress4.Image = Properties.Resources.C4;
                Label_FormStatusCompleteBar4.BackColor = Color.LightGray;
                Label_FormProgress5.Enabled = false;
            }
            else if (Label_FormProgress4.Enabled == true)
            {
                Label_FormProgress3.Image = Properties.Resources.C3;
                Label_FormStatusCompleteBar3.BackColor = Color.LightGray;
                Label_FormProgress4.Enabled = false;
                LoadForm(new GetPGOwnerDetails());
            }
            else if (Label_FormProgress3.Enabled == true)
            {
                Label_FormProgress2.Image = Properties.Resources.C2;
                Label_FormStatusCompleteBar2.BackColor = Color.LightGray;
                Label_FormProgress3.Enabled = false;
                LoadForm(new GetPGDetails());
            }
            else
            {
                Label_FormProgress1.Image = Properties.Resources.C1;
                Label_FormStatusCompleteBar1.BackColor = Color.LightGray;
                Label_FormProgress2.Enabled = false;
                Button_Previous.Visible = false;
                LoadForm(new GetDBDetailsForm());
            }
        }


    }
}
