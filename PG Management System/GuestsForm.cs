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
    public partial class GuestsForm : Form
    {
        public static GuestsForm guestsFormInstance = new GuestsForm();

        public GuestsForm()
        {
            InitializeComponent();
        }
        
        private void Button_AddGuest_Click(object sender, EventArgs e)
        {
            
            AdmissionForm admissionForm = new AdmissionForm();
            admissionForm.ShowDialog();
        }
        
        private void GuestsForm_Load(object sender, EventArgs e)
        {

        }


    }
}
