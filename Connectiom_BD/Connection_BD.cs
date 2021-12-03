using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connectiom_BD
{
    public class Connection_BD

    {
        public string connStr4 = "server=caseum.ru;port=33333;user=test_user;database=db_test;password=test_pass;";

        public void InfoConnect()
        {
            MessageBox.Show(connStr4);
        }
    }
}
