using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_0311
{
    class ContaEspecial : ContaBancaria
    {
        protected double Limite { get; set; }

        public  override void  Sacar(double saque)
        {
           
            if (Saldo + Limite < saque)
            {
                Console.WriteLine("Impossível sacar");
            }
        }
    }
}
