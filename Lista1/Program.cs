using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio1();
            Exercicio3();
            Exercicio8();
        }

        static void Exercicio1()
        {
            int final = 1;
            int N = 0;
            N = int.Parse(Console.ReadLine());

            for(int i = 0; i < N; i++)
            {
                final *= N - i;
            }
            Console.WriteLine("Resultado é {0}:", final);
        }

        static void Exercicio3()
        {
            int cont = 0;
            int i = 0;
            int numerofunc = 0;
            string nome = " ";
            int salario = 0;
            int aumento;
            int salariofinal;

            Console.Write("Informe a quantidade de funcionários: ");
            numerofunc = int.Parse(Console.ReadLine());

            while (i < numerofunc)
            {
                i++;

                while (cont < numerofunc)
                {
                    cont = cont + i;

                    Console.Write("Informe o nome do funcionário: ");
                    nome = Console.ReadLine();

                    Console.Write("Informe o salario do funcionario: ");
                    salario = int.Parse(Console.ReadLine());
                }


                if (salario <= 2999)
                {
                    aumento = ((salario * 25) / 100);
                    salariofinal = aumento + salario;
                    Console.WriteLine("Funcionário : {0}", nome);
                    Console.WriteLine("Salário Atual : {0}", salario);
                    Console.WriteLine("Novo Salário : {0}", salariofinal);

                }
                if (salario >= 3000)
                {
                    if (salario <= 3999)
                    {
                        aumento = ((salario * 20) / 100);
                        salariofinal = aumento + salario;
                        Console.WriteLine("Funcionário : {0}", nome);
                        Console.WriteLine("Salário Atual : {0}", salario);
                        Console.WriteLine("Novo Salário : {0}", salariofinal);
                    }

                }
                if (salario >= 4000)
                {
                    if (salario <= 4999)
                   {
                        aumento = ((salario * 15) / 100);
                        salariofinal = aumento + salario;
                        Console.WriteLine("Funcionário : {0}", nome);
                        Console.WriteLine("Salário Atual : {0}", salario);
                        Console.WriteLine("Novo Salário : {0}", salariofinal);
                    }
                }
                if (salario >= 5000)
                {
                    aumento = ((salario * 15) / 100);
                    salariofinal = aumento + salario;
                    Console.WriteLine("Funcionário : {0}", nome);
                    Console.WriteLine("Salário Atual : {0}", salario);
                    Console.WriteLine("Novo Salário : {0}", salariofinal);
                }
            }
        }
               
             static void Exercicio8()
             {
            
            int final = 0;
            int N = 0;
            N = int.Parse(Console.ReadLine());
            
             
            for (int i = 0; i < N; i++)
            {
             
               final =+ i;
            } 

       
            Console.WriteLine("Seu resultado é {0}:", final);
             }
           
        }
    }
