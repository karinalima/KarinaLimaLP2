using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_0707
{
    class Carro
    {
        public string placa;
        public string modelo;
        public double consumoKmL;
        public double qtdCombustivelL;

        public double AutonomiaKm()
        {
            double autonomia = consumoKmL * qtdCombustivelL;
            return autonomia;
        }
    }
}
