using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppNaLichoběžníky
{
    public partial class Form1 : Form
    {
        public double f(double a)
        {
            return Math.Sin(a);
        }

        static double What(double a, double e)
        {
            return (a / e);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a; double b; double n;

            a = numericUpDown2.DecimalPlaces;
            b = numericUpDown3.DecimalPlaces;
            n = numericUpDown4.DecimalPlaces;

            double součet = 0;
            double x = a;

            double krokH = (b - a) / n;
            součet = (f(a) + f(b)) / 2;

            for (int i = 0; i < n; i++)
            {
                x += krokH;
                součet += f(x);
            }

            double násobek = součet * krokH;
            string jejda = násobek.ToString(); // jejda je výsledek bez toho Main

            double výsledek = Convert.ToDouble(jejda);

            jejda += What(f(a) + f(b), 2);
            
            double konec = výsledek * krokH;
            string faktkonec = konec.ToString();

            textBox1.Text = faktkonec;

            

        }
    }
}
