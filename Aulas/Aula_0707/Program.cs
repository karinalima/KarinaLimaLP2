using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_0707
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();

            c1.placa = "KKK - 1999";
            c1.modelo = "Palio";
            c1.consumoKmL = 60;

            Carro c2 = new Carro();

            c2.placa = "MDS - 1994 ";
            c2.modelo = "Civic";
            c2.consumoKmL = 123;

            //Se quiser copiar no objeto, copiar atributo por atributo.

            c2 = c1;

            Console.WriteLine(c1.placa);

        }
    }
}
