using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaApoio
{
    class Program
    {
        static void Main2(string[] args)
        {
            
                /* Leia os numeros N, P, Q, inteiros.
                   Imprima tds os multiplos de N no intervalo [P;Q] P & Q inclusive */

            int N = int.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());
            int Q = int.Parse(Console.ReadLine());
            for (int i = P; i <= Q; i++)
            {
                if (i % N == 0)
                {
                    Console.WriteLine(i);
                }
                
            }
            
        }

      
    }
}
