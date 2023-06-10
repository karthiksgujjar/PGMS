using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PG_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            int flag = 1;
            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);

            try
            {
                con.Open();
            }
            catch { 
                flag = 0;
            }
            finally{
                con.Close();
            }

            if (Properties.Settings.Default.FirstRunStatus && flag == 0)
            {
                FirstRunForm firstRunForm = new FirstRunForm();
                firstRunForm.ShowDialog();
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
            }

            Application.Run();
        }
    }
}

