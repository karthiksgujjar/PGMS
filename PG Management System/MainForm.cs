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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button_FormClose_Click(object sender, EventArgs e)
        {
            /* DialogResult res = MessageBox.Show("Do you really want to exit?", "CONFIRMATION",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
              if(res==DialogResult.Yes)
              {
                  Application.Exit();
              }*/
            Application.Exit();
        }

        private void Button_FormMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoadForm(object Form)
        {
            Panel_MainPanel.Controls.Clear();
            Form ShowForm = Form as Form;
            ShowForm.TopLevel = false;
            Panel_MainPanel.Controls.Add(ShowForm);
            ShowForm.Dock = DockStyle.Fill;
            Panel_MainPanel.Tag = ShowForm;
            ShowForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadForm(new BuildingsForm());
            LoginForm.loginFormInstance.Close();
        }
    }
}
