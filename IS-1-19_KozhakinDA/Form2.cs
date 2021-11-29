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

namespace IS_1_19_KozhakinDA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        class sql
        {

            private MySqlConnection connection;
            private string server;
            private string database;
            private string uid;
            private string password;
            private string port;

            //Constructor
            public sql()
            {
                Initialize();
            }

            //Initialize values
            private void Initialize()
            {
                server = "caseum.ru";
                database = "db_test";
                uid = "test_server";
                password = "test_pass";
                port = "33333";
                string connectionString;
                connectionString = "server=caseum.ru;port=33333;user=test_user;" +
                "database=db_test;password=test_pass;";

                connection = new MySqlConnection(connectionString);
            }

            private bool OpenConnection()
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return false;
                }
            }

        }
    }
}
