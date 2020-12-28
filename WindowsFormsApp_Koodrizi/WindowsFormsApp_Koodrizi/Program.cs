﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Koodrizi
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
            Application.Run(new Home());
        }


        public static double WeightKood
        {
            get
            {
                return Properties.Settings.Default.WeightKood;
            }
            set
            {
                Properties.Settings.Default["WeightKood"] = value;
                Properties.Settings.Default.Save();
            }
        }
        public static double PersentRoyat
        {
            get
            {
                return Properties.Settings.Default.PersentRoyat;
            }
            set
            {
                Properties.Settings.Default["PersentRoyat"] = value;
                Properties.Settings.Default.Save();
            }
        }
        public static int BarId
        {
            get
            {
                return Properties.Settings.Default.BarId;
            }
            set
            {
                Properties.Settings.Default["BarId"] = value;
                Properties.Settings.Default.Save();
            }
        }
        public static DateTime SellDate
        {
            get
            {
                return Properties.Settings.Default.SellDate;
            }
            set
            {
                Properties.Settings.Default["SellDate"] = value;
                Properties.Settings.Default.Save();
            }
        }
        public static DateTime DueDate
        {
            get
            {
                return Properties.Settings.Default.DueDate;
            }
            set
            {
                Properties.Settings.Default["DueDate"] = value;
                Properties.Settings.Default.Save();
            }
        }

    }
}
