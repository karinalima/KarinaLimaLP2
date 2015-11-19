using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.SqlClient;

namespace Exercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario user = new Usuario();
            
            string query = "INSERT INTO USUARIO (Login, Senha) VALUES (@login, @senha)";
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=");
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            

            bool logar = false;

            while (logar == false)
            {
                conn.Open();
                Console.WriteLine("Digite seu login: ");
                string login = Console.ReadLine();
                Console.WriteLine("Digite sua senha: ");
                string senha = Console.ReadLine();
                string query = "INSERT INTO USUARIO (Login, Senha) VALUES (@login, @senha)";
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.commandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.read())
                    {

                        user.Id = reader.GetInt32(0);
                        user.Nome = reader.GetString(1);
                        user.Dataultimoacesso = DateTime.Now;
                        logar = true;
                    }

                }
                else
                {
                    Console.WriteLine(" O Login ou Senha estão incorreto");
                }
                if (logar == true)
                {
                    reader.Close();
                    Console.WriteLine("Login realizado com sucesso!");
                    cmd.CommandText = String.Format("INSERT INTO USUARIO (Dataultimoacesso) VALUES ('{0}')");
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();


                }
                else
                    Console.WriteLine("Falha no login");
               
            } 
         
          
        }
    }
}

