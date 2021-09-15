using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    public class Conta
    {

        public int numero { get; set; }
        public double saldo { get; private set; }
        public Conta()
        {
                
        }

        public Cliente Titular { get; set; }

        public void Deposita(double valoroperacao)
        {
            this.saldo += valoroperacao;
        }
        public void Sacar(double valoroperacao)
        {
            this.saldo -= valoroperacao;
        }
    }
}
