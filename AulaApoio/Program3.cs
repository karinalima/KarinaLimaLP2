using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaApoio
{
    class Program3
    {
        static void Main3(string[] args)
        {
            /* Faça um programa que leia um numero n e n numeros inteiros, determine se esses numeros formam uma sequencia par, impar ou neutra.
               Seq Par: A soma das posiçoes pares(P) é maior que a das posiçoes imapres(I): P > I
               Seq Impar: I > P
               Seq Neutra: I = P          CONSIDERE 0 COMO PAR */
            int n = int.Parse(Console.ReadLine());
            List<int> numeros = new List<int>();
            int seqpar = 0;
            int seqimp = 0;

            for (int i = 0; i < n; i++)
                numeros.Add(int.Parse(Console.ReadLine()));

            for (int i = 0; i < numeros.Count; i++)
            {
                if (i%2 == 0)
                    seqpar += numeros[i];
                else
                    seqimp += numeros[i];
            }
            if (seqpar>seqimp)
                Console.WriteLine("sequencia impar");
            if (seqimp>seqpar)
                Console.WriteLine("sequencia par");
            if (seqpar==seqimp)
    		 Console.WriteLine("sequencia neutra");
        }

      
    }
}
