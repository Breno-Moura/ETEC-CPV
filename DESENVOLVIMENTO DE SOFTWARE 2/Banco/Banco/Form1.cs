using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta c;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.numero = 1;
            Cliente cliente = new Cliente("Topper");
            c.Titular = cliente;
            textoTitular.Text = c.Titular.Nome;
            textoNumero.Text = Convert.ToString(c.numero);
            textoSaldo.Text = Convert.ToString(c.saldo);
            this.c = new Conta();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String valordigitado = textoValor.Text;
            double valoroperacao = Convert.ToDouble(valordigitado);
            this.c.Deposita(valoroperacao);
            textoSaldo.Text = Convert.ToString(this.c.saldo);
            MessageBox.Show("Deposito realizado com sucesso");
            textoValor.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String valordigitado = textoValor.Text;
            double valoroperacao = Convert.ToDouble(valordigitado);
            this.c.Sacar(valoroperacao);
            textoSaldo.Text = Convert.ToString(this.c.saldo);
            MessageBox.Show("Saque realizado com sucesso");
            textoValor.Focus();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
