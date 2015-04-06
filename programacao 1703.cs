using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula17032015
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int soma = 0;
            int i = 0;
            int media = 0;

            Console.WriteLine("Escreva uma quantidade indefinida de números positivos. (PS: para saber a média de todos os números informados, digite o número 0)");

            while (n != 0) 
            {
                n = int.Parse(Console.ReadLine());

                if (n < 0){
                    while (n < 0)
                    {
                        Console.WriteLine("Escreva um número POSITIVO.");
                        n = int.Parse(Console.ReadLine());
                    }
                }

                soma = soma + n;
                i++;
                if (n == 0){
                    i--;
                }
            }

            media = soma / i;
            Console.WriteLine("A média é igual a {0}", media);


        }
    }
}
