using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_0311
{
    class Program
    {
        static void Main(string[] args)
        {
           

            ContaBancaria cliente = new ContaBancaria();

            cliente.Cliente = Console.ReadLine();
            cliente.Num_Conta = Console.ReadLine();
            cliente.Saldo = double.Parse(Console.ReadLine());

          

        }
    }
}
