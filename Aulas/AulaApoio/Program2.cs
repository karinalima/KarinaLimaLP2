using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaApoio
{
    class Program2
    {
        static void Main(string[] args)
        {
             /** Faça um programa q leia um numero N, inteiro. Em seguida leia N vezes os 3 lados
               de um triangulo e decida, para cada um, se ele é escaleno, isósceles ou equilátero.
              * 
               Caso seja escaleno, determine se é retangulo. */

            int N = int.Parse(Console.ReadLine());
            int lado1 = int.Parse(Console.ReadLine());
            int lado2 = int.Parse(Console.ReadLine());
            int lado3 = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                if (lado1 == lado2 && lado2 == lado3)
                    Console.WriteLine("Equilátero");

                if ((lado1 == lado2 && lado2 != lado3) || (lado1 == lado3 && lado2 != lado1) || (lado3 == lado2 && lado2 != lado1))
                    Console.WriteLine("Isóceles");

                else if (lado1 != lado2 && lado2 != lado3)
                {
                    Console.WriteLine("Escaleno");

                    if (lado1 < lado3 && lado3 > lado2)
                    {
                       int pitagoras = (lado2 * lado2) + (lado1 * lado1);
                       
                       if (pitagoras == lado3 * lado3)
                           Console.WriteLine("Retangulo");
                    }

                    if (lado3 < lado1 && lado1 > lado2)
                    {
                        int pitagoras = (lado2 * lado2) + (lado3 * lado3);

                        if (pitagoras == lado1 * lado1)
                            Console.WriteLine("Retangulo");
                    }

                    if (lado3 < lado2 && lado2 > lado1)
                    {
                        int pitagoras = (lado3 * lado3) + (lado1 * lado1);

                        if (pitagoras == lado2 * lado2)
                            Console.WriteLine("Retangulo");
                    }
                    
                }
            }
                
        }

       
    }
}
