using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Avaliação
{
    class Program
    {
        static void Main(string[] args)
        {
            Double sal, val,salf;
            Console.WriteLine("Informe o saldo médio");
            sal = double.Parse(Console.ReadLine());
            if (sal < 501)
            {
                Console.WriteLine("Saldo Médio insuficiente para crédito");
            }
            else
            {
                if (sal >= 501 && sal <= 1000)
                {
                    val = (sal * 30) / 100;
                    salf = sal + val;
                    Console.WriteLine("Foi concedido 30% de créditos bônus em sua conta\nSaldo:" +salf);
                }
                else
                {
                    if (sal >= 1001 && sal <= 3000)
                    {
                        val = (sal * 40) / 100;
                        salf = sal + val;
                        Console.WriteLine("Foi concedido 40% de créditos bônus em sua conta\nSaldo:" +salf);
                    }
                    else
                    {
                        if (sal>3000)
                        {
                            val = (sal * 50) / 100;
                            salf = sal + val;
                            Console.WriteLine("Foi concedido 50% de créditos bônus em sua conta\nSaldo:"+salf);
                        }
                    }
                }
            }
            Console.WriteLine("Tecle <ENTER> para sair");
            Console.ReadLine();
        }
    }
}
