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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void ButtonBuilding_Click(object sender, EventArgs e)
        {
            DisplayPanel.Controls.Clear();
            BuildingsForm buildingsForm = new BuildingsForm();
            buildingsForm.TopLevel = false;
            DisplayPanel.Controls.Add(buildingsForm);
            buildingsForm.Show();
        }

        private void ButtonFloor_Click(object sender, EventArgs e)
        {
            DisplayPanel.Controls.Clear();
            FloorsForm floorsForm = new FloorsForm();
            floorsForm.TopLevel = false;
            DisplayPanel.Controls.Add(floorsForm);
            floorsForm.Show();
        }
    }
}
