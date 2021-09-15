using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_30
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4, n5, n6, n7, n8, n9, n10;
            double r1, r2, r3, r4, r5, r6, r7, r8, r9, r10;
            double q = 2;
            n1 = double.Parse(textBox1.Text);
            r1 = Math.Pow(n1, q);
            label12.Text = ("" + r1);
            n2 = double.Parse(textBox2.Text);
            r2 = Math.Pow(n2, q);
            label18.Text = ("" + r2);
            n3 = double.Parse(textBox3.Text);
            r3 = Math.Pow(n3, q);
            label17.Text = ("" + r3);
            n4 = double.Parse(textBox4.Text);
            r4 = Math.Pow(n4, q);
            label19.Text = ("" + r4);
            n5 = double.Parse(textBox5.Text);
            r5 = Math.Pow(n5, q);
            label20.Text = ("" + r5);
            n6 = double.Parse(textBox6.Text);
            r6 = Math.Pow(n6, q);
            label21.Text = ("" + r6);
            n7 = double.Parse(textBox7.Text);
            r7 = Math.Pow(n7, q);
            label13.Text = ("" + r7);
            n8 = double.Parse(textBox8.Text);
            r8 = Math.Pow(n8, q);
            label14.Text = ("" + r8);
            n9 = double.Parse(textBox9.Text);
            r9 = Math.Pow(n9, q);
            label15.Text = ("" + r9);
            n10 = double.Parse(textBox10.Text);
            r10 = Math.Pow(n10, q);
            label16.Text = ("" + r10);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
            label21.Text = "";
            textBox1.Focus();
        }
    }
}
