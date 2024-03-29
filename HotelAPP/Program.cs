﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelAPP.AppForm;

namespace HotelAPP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm loginForm = new LoginForm();

            if(loginForm.ShowDialog() == DialogResult.Yes)
            {
                Application.Run(new Home());
            }
            else
            {
                Application.Exit();
            }
        }
        public static void logout()
        {
            Application.Restart();
        }
    }
}
