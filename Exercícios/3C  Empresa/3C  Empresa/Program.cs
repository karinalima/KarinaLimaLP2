using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C__Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            double folhapg = 0;

            List<Gerente> Gerentes = new List<Gerente>();
            List<Empregado> Empregados = new List<Empregado>();
            List<Terceirizado> Terceirizados = new List<Terceirizado>();

            Console.WriteLine("Digite a quantidade de funcionários:");
            int qtfuncionario = int.Parse(Console.ReadLine());

            int ndegerentes = 0;
            int ndeempregados = 0;
            int ndeterceirizados = 0;
           

            for (int i = 0; i < qtfuncionario; i++)
            
            {
                Console.WriteLine("Seu cargo na Empresa: (Empregado/ Teceirizado/ Gerente) ");
                string tpfunc = Console.ReadLine();

                if (tpfunc == "Empregado")
                {
                   Empregado empregado = new Empregado();

                    Console.WriteLine("Nome: ");
                    empregado.Nome = Console.ReadLine();
                    Console.WriteLine("CPF: ");
                    empregado.Cpf = Console.ReadLine();
                    Console.WriteLine("Data de nascimento: ");
                    empregado.Datanasc = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Matrícula: ");
                    empregado.Matricula = Console.ReadLine();
                    Console.WriteLine("Salário: ");
                    empregado.Salario = double.Parse(Console.ReadLine());                   

                    Empregados.Add(empregado);

                    ndeempregados++ ;
                    folhapg += empregado.Salario + empregado.vale;
                }
                
                else if (tpfunc == "terceirizado")
                {
                    Terceirizado terceirizado = new Terceirizado();

                    Console.WriteLine("Nome: ");
                    terceirizado.Nome = Console.ReadLine();
                    Console.WriteLine("CPF: ");
                    terceirizado.Cpf = Console.ReadLine();
                    Console.WriteLine("Data de nascimento: ");
                    terceirizado.Datanasc = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Matrícula: ");
                    terceirizado.Matricula = Console.ReadLine();
                    Console.WriteLine("CNPJ da empresa do terceirizado: ");
                    terceirizado.cnpj = Console.ReadLine();
                    Terceirizados.Add(terceirizado);

                    ndeterceirizados++;
                    folhapg += terceirizado._salario;
                    
                }

                

                else if (tpfunc == "gerente")
                {
                    Gerente gerente = new Gerente();

                    Console.WriteLine("Nome: ");
                    gerente.Nome = Console.ReadLine();
                    Console.WriteLine("CPF: ");
                    gerente.Cpf = Console.ReadLine();
                    Console.WriteLine("Data de Nascimento: ");
                    gerente.Datanasc = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Matrícula: ");
                    gerente.Matricula = Console.ReadLine();
                    Console.WriteLine("Área gerencia: ");
                    gerente.Areagerencia = Console.ReadLine();
                    Console.WriteLine("Salário: ");
                    gerente._salario = int.Parse(Console.ReadLine());
                    gerente.vale = gerente.Vale();
                    Gerentes.Add(gerente);

                    ndegerentes++;
                    folhapg += gerente._salario + gerente.vale;
                    
                }

            }

            
               Console.WriteLine("Quantia Total do pagamento: R${0}" ,folhapg);
            
            Console.ReadKey();
        }

        }

    }
}
