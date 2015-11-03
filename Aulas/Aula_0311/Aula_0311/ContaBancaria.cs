using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_0311
{
    class ContaBancaria
    {
        public string Cliente { get; set;}
        public string Num_Conta { get; set; }
        public double Saldo { get; set; }


        public void Sacar(double sacar)
        {
            Saldo -= sacar;

            if (Saldo < 0)
            {
                Console.WriteLine("Saldo não pode ser negativo!!");
            }
        }

        public void Depositar(double deposito)
        {
            Saldo += deposito;
        }
    }
}
