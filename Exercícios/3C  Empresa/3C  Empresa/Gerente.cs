using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C__Empresa
{
    public class Gerente :Funcionario 
    {
        public double _salario { get; set; }
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

        public override double Vale()
           
        {
            double vale = _salario * (65 / 1000);
        
    
                if (vale > 750)
                {
                    vale = 750;
                }

                else
                {
                    return vale;
                }
        }  
    }
}
