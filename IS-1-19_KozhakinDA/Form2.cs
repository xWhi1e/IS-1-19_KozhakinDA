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
        class Connect
        {
            public string connStr = "server=caseum.ru;port=33333;user=test_user;database=db_test;password=test_pass;";

            public void InfoConnect()
            {
                MessageBox.Show(connStr);
            }
        }
        


        

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect con = new Connect();
            MySqlConnection conn = new MySqlConnection(con.connStr);
            bool result = true;
            try
            {
                conn.Open();
            }
            catch
            {
                result = false;
            }
            finally
            {
                if (result == true)
                {
                    MessageBox.Show("Подключение успешно");
                }
                else
                {
                    MessageBox.Show("Подключение не произошло");
                }
                conn.Close();
            }
        }
    }
}
