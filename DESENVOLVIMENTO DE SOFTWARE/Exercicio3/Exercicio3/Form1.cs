using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double raio, altura, resultado, r2;
            raio = double.Parse(textBox1.Text);
            r2 = raio * raio;
            altura = double.Parse(textBox2.Text);
            resultado = 3.14159 * r2 * altura;
            label7.Text = resultado.ToString();
        }

        private void raio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
