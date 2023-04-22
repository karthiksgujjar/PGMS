using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PG_Management_System
{
    public partial class PasswordResetForm : Form
    {
        private int GeneratedOTP = OTPGenerator();
        public PasswordResetForm()
        {
            InitializeComponent();
        }

        private void Button_ResetPWD_Click(object sender, EventArgs e)
        {
            if (TextBox_MailID.Text.ToString() == "" || TextBox_OTP.Text.ToString() == "" || TextBox_NewPWD.Text.ToString() == "" || TextBox_ConfirmPWD.Text.ToString() == "")
            {
                MessageBox.Show("Please enter all fields.", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(TextBox_MailID.Text.ToString() == "")
                {
                    TextBox_MailID.Focus();
                }
                else if (TextBox_OTP.Text.ToString() == "")
                {
                    TextBox_OTP.Focus();
                }
                else if (TextBox_NewPWD.Text.ToString() == "")
                {
                    TextBox_NewPWD.Focus();
                }
                else
                {
                    TextBox_ConfirmPWD.Focus();
                }
            }
            else if (OTPValidator())
            {
                ErrorProvider_PasswordResetForm.SetError(TextBox_OTP, "OTP DOESN'T MATCH");
                TextBox_OTP.Focus();
            }
            else if(TextBox_NewPWD.Text.ToString() != TextBox_ConfirmPWD.Text.ToString())
            {
                ErrorProvider_PasswordResetForm.Clear();
                ErrorProvider_PasswordResetForm.SetError(TextBox_ConfirmPWD, "PASSWORDS DOESN'T MATCH");
                TextBox_NewPWD.Focus();
            }
            else
            {
                ErrorProvider_PasswordResetForm.Clear();
                try
                {
                    MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
                    string query = "UPDATE login SET password=@NewPWD WHERE username=@UN";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@NewPWD",TextBox_NewPWD.Text);
                    cmd.Parameters.AddWithValue("@UN", Properties.Settings.Default.LoggedUser);
                    con.Open();
                    int res = cmd.ExecuteNonQuery();
                    if (res == 1)
                    {
                        MessageBox.Show("PASWORD RESET SUCCESSFULL.\nYour new Password for " + Properties.Settings.Default.LoggedUser + " is: " + TextBox_NewPWD.Text.ToString(), "SUCCESS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("PASWORD RESET FAILURE.", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    con.Close();
                    this.Close();
                    LoginForm.loginFormInstance.Show();
                }
                catch(Exception Err)
                {
                    MessageBox.Show("Unable to make connection to Database\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button_FormClose_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm.loginFormInstance.Show();
        }
        
        private bool SendMail()
        {
            try
            {
                MailMessage mail = new MailMessage();

                mail.From = new MailAddress("gfgctumkur.pgms.bca6.2023@gmail.com", "PG Management System", Encoding.UTF8);
                mail.To.Add(new MailAddress(Properties.Settings.Default.OwnerMailID));
                mail.Subject = "OTP for Password Reset";
                mail.Body = "YOUR OTP IS " + GeneratedOTP.ToString() +". DO NOT SHARE THIS OTP WITH ANYONE.";
                mail.IsBodyHtml = true;

                SmtpClient client = new SmtpClient();
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.Credentials = new NetworkCredential("gfgctumkur.pgms.bca6.2023@gmail.com", "ekjxafsbpnsrafnw");
                client.EnableSsl = true;

                client.Send(mail);

                return true;
            }
            catch (Exception Err)
            {
                DialogResult res = MessageBox.Show("Unable to send OTP.\n"+Err.Message, "CONNECTION FAILURE", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.Retry)
                {
                    SendMail();
                }
                return false;
            }
        }

        private static int OTPGenerator()
        {
            Random RandomNumber = new Random();
            int OTP = RandomNumber.Next(999999);
            
            return OTP;
        }

        private bool OTPValidator()
        {
            try
            {
                int EnteredOTP = Convert.ToInt32(TextBox_OTP.Text.ToString());
                if(EnteredOTP != GeneratedOTP)
                {
                    return true; //Here, true gets returned and IF condition gets executed, so else part will be halted, meaning, OTP is Not Vaild.
                }
            }
            catch(Exception)
            {
                return true;
            }
            return false;
            
        }

        private void PasswordResetForm_Load(object sender, EventArgs e)
        {
            TextBox_MailID.Text = Properties.Settings.Default.OwnerMailID;
            if (SendMail())
            {
                Label_MailSentSuccessfully.Visible = true;
                TextBox_OTP.Focus();
            }
        }
    }
}
