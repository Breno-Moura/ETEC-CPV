using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_____Exercicio_29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int I = 0;
            for (I = 0; I <= 200; I += 2)
            {
                MessageBox.Show("Número= " + I.ToString()+"\nEnter para exibir o proximo numero");
            }
        }
    }
}
