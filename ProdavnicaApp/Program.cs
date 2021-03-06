﻿using Microsoft.Extensions.DependencyInjection;
using ProdavnicaApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdavnicaApp
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

            var login = new Login();
            if(login.ShowDialog() == DialogResult.OK)
                Application.Run(new GlavnaForma());
        }

    }
}
