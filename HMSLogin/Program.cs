﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSLogin
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
            //Application.Run(new Form1());
            //Application.Run(new ViewDepartment());
            //Application.Run(new HospitalLayout());
            //Application.Run(new AdminMenu(new Form1()));
            //Application.Run(new DoctorMenu(new Form1()));
            //Application.Run(new HospitalLayout());
            Application.Run(new Form1());
            //Application.Run(new FrmPatientDetails());
            //Application.Run(new FrmPatientDetails());
        }
    }
}
