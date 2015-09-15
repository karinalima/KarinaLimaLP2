using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lp2_1509_heranca
{
    class Gerente
    {
        private double nome;
        private string Cpf;
        private DateTime Datanasc;
        private double _salario;
        private string Matricula;
        private string Areagerencia;
               
        
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Datanasc { get; set; }
        
        private string Matricula { get; set; }                   
        public string Areagerencia { get; set; }
        public double valoradc { get; set; }

        public void Set_salario(double salario)
        {
            _salario = _salario + valoradc;

        }
        public double Get_salario()
        {
            return _salario;
        }

    }
}
