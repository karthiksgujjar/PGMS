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
    public partial class GuestDetailsForm : Form
    {
        public static GuestDetailsForm guestDetailsFormInstance =  new GuestDetailsForm();

        public GuestDetailsForm()
        {
            InitializeComponent();
        }
    }
}
