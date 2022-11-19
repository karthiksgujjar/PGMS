using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Web;
using System.Net;
using System.Net.Mail;
using Org.BouncyCastle.Crypto.Macs;

namespace PG_Management_System
{
    public partial class LoginForm : Form
    {
        public static LoginForm loginFormInstance;
        public static string constring = "SERVER=localhost;DATABASE=pgms;UID=PGMS;Password=pgms123";
        public static string SelectedUserName;

        public LoginForm()
        {
            InitializeComponent();
            loginFormInstance = this;
        }

        private void Button_LogIn_Click(object sender, EventArgs e)
        {
            
            if (TextBox_PWD.Text == "")
            {
                MessageBox.Show("Please enter the Password.", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextBox_PWD.Focus();
            }
            else
            {
                try
                {
                    string constring = "SERVER=localhost;DATABASE=pgms;UID=PGMS;Password=pgms123";
                    MySqlConnection con = new MySqlConnection(constring);
                    string query = "SELECT password from login where username = @UN and password = @PWD";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@UN", ComboBox_UN.SelectedItem);
                    cmd.Parameters.AddWithValue("@PWD", TextBox_PWD.Text);

                    con.Open();
                    MySqlDataReader DB_PassWord = cmd.ExecuteReader();
                    if (DB_PassWord.HasRows)
                    {
                        ErrorProvider_LogInForm.Clear();
                        SaveCredentials();

                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                    }
                    else
                    {
                        ErrorProvider_LogInForm.SetError(TextBox_PWD, "WRONG PASSWORD");
                        TextBox_PWD.Focus();
                    }
                    con.Close();
                }
                catch (Exception Err)
                {
                    MessageBox.Show("Unable to make connection to Database\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(constring);
                string query = "SELECT username from login";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader DB_UserNames = cmd.ExecuteReader();
                while(DB_UserNames.Read())
                {
                    ComboBox_UN.Items.Add(DB_UserNames["username"]);
                }
                ComboBox_UN.SelectedIndex = 0;
                con.Close();
            }
            catch (Exception Err)
            {
                MessageBox.Show("Unable to make connection to Database\n"+Err.Message,"DATABASE ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Button_FormClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_FormMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button_Show_Hide_Pwd_Click(object sender, EventArgs e)
        {
            if(TextBox_PWD.UseSystemPasswordChar==true)
            {
                Button_Show_Hide_Pwd.Image = Properties.Resources.Hide_Password;
                TextBox_PWD.UseSystemPasswordChar=false;
            }
            else
            {
                Button_Show_Hide_Pwd.Image = Properties.Resources.Show_Password;
                TextBox_PWD.UseSystemPasswordChar = true;
            }
        }

        void SaveCredentials()
        {
            if(CheckBox_RememberMe.Checked)
            {
                if (ComboBox_UN.SelectedItem.ToString() == "admin")
                {
                    Properties.Settings.Default.AdminPassword = TextBox_PWD.Text;
                }
                else if(ComboBox_UN.SelectedItem.ToString() == "staff1")
                {
                    Properties.Settings.Default.Staff1Password = TextBox_PWD.Text;
                }
                else
                {
                    Properties.Settings.Default.Staff2Password = TextBox_PWD.Text;
                }
                Properties.Settings.Default.Save();
            }
            else
            {
                if (ComboBox_UN.SelectedItem.ToString() == "admin")
                {
                    Properties.Settings.Default.AdminPassword = "";
                }
                else if (ComboBox_UN.SelectedItem.ToString() == "staff1")
                {
                    Properties.Settings.Default.Staff1Password = "";
                }
                else
                {
                    Properties.Settings.Default.Staff2Password = "";
                }
                Properties.Settings.Default.Save();
            }
        }

        void LoadCredentials()
        {
            if (ComboBox_UN.SelectedItem.ToString() == "admin")
            {
                TextBox_PWD.Text = Properties.Settings.Default.AdminPassword;
                if (!string.IsNullOrEmpty(Properties.Settings.Default.AdminPassword))
                {
                    CheckBox_RememberMe.Checked = true;
                }
                else
                {
                    CheckBox_RememberMe.Checked = false;
                }
            }
            else if (ComboBox_UN.SelectedItem.ToString() == "staff1")
            {
                TextBox_PWD.Text = Properties.Settings.Default.Staff1Password;
                if (!string.IsNullOrEmpty(Properties.Settings.Default.Staff1Password))
                {
                    CheckBox_RememberMe.Checked = true;
                }
                else
                {
                    CheckBox_RememberMe.Checked = false;
                }
            }
            else
            {
                TextBox_PWD.Text = Properties.Settings.Default.Staff2Password;
                if (!string.IsNullOrEmpty(Properties.Settings.Default.Staff2Password))
                {
                    CheckBox_RememberMe.Checked = true;
                }
                else
                {
                    CheckBox_RememberMe.Checked = false;
                }
            }
        }

        private void ComboBox_UN_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCredentials();
            TextBox_PWD.Focus();
        }

        private void LinkLabel_ForgotPWD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SelectedUserName = ComboBox_UN.SelectedItem.ToString();
            PasswordResetForm passwordResetForm = new PasswordResetForm();
            passwordResetForm.Show();
        }
    }
}
