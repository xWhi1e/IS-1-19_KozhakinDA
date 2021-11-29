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
                lb.Items.Add($"Тактовая частота процессора :{GZ1}");
                lb.Items.Add($"Количество ядер процессора :{kol_vo_ydr1}");
                lb.Items.Add($"Количество потоков процессора :{kol_vo_potoc1}");
            }
        }
        class Video<T> : Komplect<T>
        {
            private string GPUcastota;
            public string GPUcastota1
            {
                get { return GPUcastota; }
                set { GPUcastota = value; }
            }

            private string Proizvod;
            public string Proizvod1
            {
                get { return Proizvod; }
                set { Proizvod = value; }
            }

            private string MemoriGB;
            public string MemoriGB1
            {
                get { return MemoriGB; }
                set { MemoriGB = value; }
            }

            public Video(T ARTKL, float Price, string Age, string gpu, string proiz, string GB)
            : base(ARTKL, Price, Age)
            {
                GPUcastota1 = gpu;
                Proizvod1 = proiz;
                MemoriGB1 = GB;
            }
            public override void Disp(ListBox lb)
            {
                lb.Items.Add($"Артикул товара : {article}");
                lb.Items.Add($"Цена товара : {price}");
                lb.Items.Add($"Год выпуска товара : {AgeMade}");
                lb.Items.Add($"Частота видеочипа :{GPUcastota1}");
                lb.Items.Add($"Фирма производитель :{Proizvod1}");
                lb.Items.Add($"Объём памяти :{MemoriGB1}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            CP<string> cp1 = new CP<string>(textBox1.Text , Convert.ToInt32(textBox2.Text) , textBox3.Text , Convert.ToInt32(textBox4.Text) , textBox5.Text , textBox6.Text);
            cp1.Disp(listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Video<string> vid1 = new Video<string>(textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text, textBox7.Text, textBox8.Text, textBox9.Text);
            vid1.Disp(listBox1);
        }
    }
}
