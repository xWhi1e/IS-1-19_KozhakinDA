﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IS_1_19_KozhakinDA
{
    
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
    class SqlConn
    {
        public string connStr = "server=caseum.ru;port=33333;user=test_user;database=db_test;password=test_pass;";

        public void InfoConnect()
        {
            MessageBox.Show(connStr);
        }
    }
}
