using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double a, b, c, d, m;

            a = double.Parse(textBox2.Text);
            b = double.Parse(textBox3.Text);
            c = double.Parse(textBox4.Text);
            d = double.Parse(textBox5.Text);
            m = (a + b + c + d) / 4;
            label9.Text = m.ToString();
        }
    }
}
