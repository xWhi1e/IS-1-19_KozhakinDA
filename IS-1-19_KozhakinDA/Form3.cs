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
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }
        

        private void Form3_Load_1(object sender, EventArgs e)
        {
            SqlConn conn = new SqlConn();
            MySqlConnection connect = new MySqlConnection(conn.connStr);
            string sql_z = $"SELECT id, fio, theme_kurs FROM t_stud";
            try
            {
                connect.Open();

                MySqlDataAdapter IDataAdapter = new MySqlDataAdapter(sql_z, connect);

                DataSet data_set = new DataSet();

                IDataAdapter.Fill(data_set);
                dataGridView1.DataSource = data_set.Tables[0];
            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }
            finally
            {
                connect.Close();
            }

        }
        string id_rows = "0";
        

        private void dataGridView1_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Left))
            {
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];

                dataGridView1.CurrentRow.Selected = true;

                string index_rows;

                index_rows = dataGridView1.SelectedCells[0].RowIndex.ToString();

                id_rows = dataGridView1.Rows[Convert.ToInt32(index_rows)].Cells[1].Value.ToString();
                MessageBox.Show(id_rows);
            }
        }

        
    }
    
}
