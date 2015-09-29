using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C__Empresa
{
    public class Empregado : Funcionario
    {
        
        public double Salario { get; set; }
        public virtual double vale()
       
        {
            double vale = Salario * (8 / 100);

            if (vale > 750)
            {
                return 750;
            }
                return vale;
        }
         
                               
        }
    }
}
