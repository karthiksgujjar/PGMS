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
    public partial class GetPGDetails : Form
    {
        public GetPGDetails()
        {
            InitializeComponent();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (TextBox_PGName.Text == "")
            {
                ErrorProvider_GetPGDetailsForm.SetError(TextBox_PGName, "PG Name not Entered");
                TextBox_PGName.Focus();
            }
            else if (TextBox_PGAddress.Text == "")
            {
                ErrorProvider_GetPGDetailsForm.SetError(TextBox_PGAddress, "PG Address not Entered");
                TextBox_PGAddress.Focus();
            }
            else
            {
                Properties.Settings.Default.PGName = TextBox_PGName.Text;
                Properties.Settings.Default.PGAddress = TextBox_PGAddress.Text;
                Properties.Settings.Default.Save();
            }
        }
    }
}
