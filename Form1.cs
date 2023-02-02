using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int pocetPrvku = int.Parse(textBox1.Text);
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            if(a>b)
            {
                double c = a;
                a = b;
                b = c;
            }
            double[] pole = new double[pocetPrvku];
            GenerovatCislaDoPole(pole, a, b, pocetPrvku);
            ZobrazitDoListbox(pole,listBox1);
        }
        static private void  GenerovatCislaDoPole(double[] pole, double a, double b, int pocetPrvku)
        {
            Random rnd = new Random();
            for(int i = 0;i< pocetPrvku;i++)
            {
                double cislo = rnd.NextDouble() * (b - a) + a;
                pole[i] = cislo;
            }
        }
        static private void ZobrazitDoListbox(double[] pole, ListBox listBox)
        {
            foreach(double x in pole)
            {
                listBox.Items.Add(x);
            }
        }
    }
}
