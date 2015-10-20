using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
             MySqlConnection conn = new MySqlConnection ("Server = localhot; Database = Test; Uid = root; Pwd =");
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            while(true)
            {
                Menu();  
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("Insira seus dados:");
                Pessoa p = new Pessoa();    
                Console.WriteLine("insira seu nome:");
                p.Nome = Console.ReadLine();
                Console.WriteLine("Insira seu sobrenome:");
                p.Sobrenome = Console.ReadLine();
                Console.WriteLine("Insira seu Peso:");
                p.Peso = double.Parse(Console.ReadLine());
                Console.WriteLine("Insira sua Altura:");
                p.Altura = double.Parse(Console.ReadLine());
                Console.WriteLine("Insira seu telefone:");
                p.Telefone = Console.ReadLine();
                string q = String.Format("Insert into Pessoa (Nome, Sobrenome, Peso, Altura, Telefone) values ('{0}', '{1}', '{2}', '{3}', '{4}')", p.Nome, p.Sobrenome, p.Peso, p.Altura, p.Telefone);

                Inserir(q);
            }
            else if (opcao == 2)
            {
                int n = int.Parse(Console.Readline());
                while (n == 1||n==2)
                {
                    if (n == 1)
                    {
                        Console.WriteLine("Digite um nome: ");
                        string nome = Console.ReadLine();
                        string query = String.Format("SELECT Id, Nome, Sobrenome FROM Pessoa WHERE Nome = {0}", nome);
                    }
                }

            }
            }
            
            
        }
        public static void Menu()
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1- Inserir");
            Console.WriteLine("2- Consultar");

        }
        public static void Inserir(string query)
        {
            command.CommandText = query;
            conn.Open();
        }

        public static MySqlDataReader ConsultaPeloNome(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn); 

        }

    


        }
    }
}
