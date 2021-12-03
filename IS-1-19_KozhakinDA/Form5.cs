using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connectiom_BD;
using MySql.Data.MySqlClient;

namespace IS_1_19_KozhakinDA
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection_BD conn1 = new Connection_BD();
            MySqlConnection connect = new MySqlConnection(conn1.connStr4); // соидинение
            string fioStud = textBox2.Text; // присваивание значения (фио) 
            string dateitimeStud = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string dateitimeStudFinal = textBox1.Text == "" ? dateitimeStud : textBox1.Text; // я спиздил это говорю честно 
            string sql = $"INSERT INTO t_PraktStud (fioStud, datetimeStud)  VALUES ('{fioStud}','{dateitimeStudFinal}');";
            int counter = 0;
            try
            {
                connect.Open();

                MySqlCommand command1 = new MySqlCommand(sql, connect);
                counter = command1.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            finally
            {
                connect.Close();

                if (counter != 0)
                {
                    MessageBox.Show("Успешно");
                }
            }
        }
    }
}
