using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_1_19_KozhakinDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        abstract class Komplect<T>
        {
            public T article;
            public float price;
            public string AgeMade;

            public Komplect(T ARTKL, float Price, string Age)
            {
                article = ARTKL;
                price = Price;
                AgeMade = Age;
            }

            public abstract void Disp(ListBox lb);

        }
        class CP<T> : Komplect<T>
        {
            private float GZ;
            public float GZ1
            {
                get { return GZ; }
                set { GZ = value; }
            }
            private string kol_vo_ydr;
            public string kol_vo_ydr1
            {
                get { return kol_vo_ydr; }
                set { kol_vo_ydr = value; }
            }
            private string kol_vo_potoc;
            public string kol_vo_potoc1
            {
                get { return kol_vo_potoc; }
                set { kol_vo_potoc = value; }
            }

            public CP(T ARTKL, float Price, string Age, float gz, string ydra, string potok)
            : base(ARTKL, Price, Age)
            {
                GZ1 = gz;
                kol_vo_ydr1 = ydra;
                kol_vo_potoc1 = potok;
            }
            public override void Disp(ListBox lb)
            {
                lb.Items.Add($"Артикул товара : {article}");
                lb.Items.Add($"Цена товара : {price}");
                lb.Items.Add($"Год выпуска товара : {AgeMade}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
