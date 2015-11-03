using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_0311
{
    class ContaPoupanca : ContaBancaria
    {
        protected double DiaDeRendimento { get; set;}

        public void CalcularNovoSaldo(double taxa)
        {
            Saldo = Saldo + (Saldo * taxa / 100);
          
        }
    }
}
