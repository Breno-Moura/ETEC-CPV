using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, delta, x1, x2, raizdelta;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);
            if (a != 0 && b != 0 && c != 0)
            {
                delta = (b * b) - 4 * a * c;
                label5.Text = ("Delta = " + delta);
                if (delta > 0)
                {
                    raizdelta = Math.Sqrt(delta);
                    x1 = (b + raizdelta) / 2 * a;
                    x2 = (b - raizdelta) / 2 * a;
                    label5.Text = ("X1 = " + x1 + "\nX2 = " + x2);
                }
                else
                {
                    label5.Text = ("O valor do delta é negativo\nNão é possível realizar o cálculo");
                }
           if (a == 0 || b == 0 || c == 0)
           {
                label5.Text = ("Um dos valores é = 0\nNão é possível realizar o cálculo");
           }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label5.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
