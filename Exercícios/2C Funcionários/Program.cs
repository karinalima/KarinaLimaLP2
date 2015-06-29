using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2C_Funcionários
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de funcionários:");
            int funcionarios = int.Parse(Console.ReadLine());

            string[] nomes = new string[funcionarios];

            string[] cpfs = new string[funcionarios];

            int[] datanascimento = new int[funcionarios];


            DateTime[] datadm = new DateTime[funcionarios];

            double salario;
            double[] salarios = new double[funcionarios];

            double salarioacrescentado;
            double[] salarioacresc = new double[funcionarios];



            for (int i = 0; i < funcionarios; i++)
            {
                Console.WriteLine("Nome do funcionario: ");
                nomes[i] = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Cpf do funcionario: ");
                cpfs[i] = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Data de nascimento: ");
                datanascimento[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Data de admissão na empresa: ");
                datadm[i] = DateTime.Parse(Console.ReadLine());


                Console.WriteLine("Salário: ");
                salarios[i] = double.Parse(Console.ReadLine());
                salario = salarios[i];

                DateTime[] datasDaTabela = new DateTime[6];
                datasDaTabela[0].AddYears(2014);
                datasDaTabela[1].AddYears(2010);
                datasDaTabela[2].AddYears(2013);
                datasDaTabela[3].AddYears(2000);
                datasDaTabela[4].AddYears(2009);
                datasDaTabela[5].AddYears(1999);

                for (int j = 0; j < funcionarios; j++)
                {

                    if (datadm[i] >= datasDaTabela[0])
                    {
                        salarioacrescentado = salario + 423.45;
                        salarioacresc[i] = salarioacrescentado;
                    }

                    else if (datadm[i] >= datasDaTabela[1] && datadm[i] <= datasDaTabela[2])
                    {
                        salarioacrescentado = salario + salario * 9.84 / 100;
                        salarioacresc[i] = salarioacrescentado;
                    }

                    else if (datadm[i] >= datasDaTabela[3] && datadm[i] <= datasDaTabela[4])
                    {
                        salarioacrescentado = salario + salario * 16.4 / 100;
                        salarioacresc[i] = salarioacrescentado;
                    }

                    else if (datadm[i] <= datasDaTabela[5])
                    {
                        salarioacrescentado = salario + salario * 22.6 / 100;
                        salarioacresc[i] = salarioacrescentado;
                    }
                }
            }

            for (int i = 0; i < funcionarios; i++)
            {
                Console.WriteLine("Nome: {0}", nomes[i]);
                Console.WriteLine("Cpf: {0}", cpfs[i]);
                Console.WriteLine("Data de Nascimento: {0}", datanascimento[i]);
                Console.WriteLine("Data de admissão: {0}", datadm[i]);
                Console.WriteLine("Salário: {0}", salarios[i]);
                Console.WriteLine("Novo Salario: {0}", salarioacresc[i]);
            }
        }
    }
}
