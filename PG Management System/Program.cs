﻿using System;
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

            /*if(Properties.Settings.Default.FirstRunStatus == true )
            {
                FirstRunForm firstRunForm = new FirstRunForm();
                firstRunForm.ShowDialog();
            }
            else
            {*/
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
            //}

            Application.Run();
        }
    }
}

