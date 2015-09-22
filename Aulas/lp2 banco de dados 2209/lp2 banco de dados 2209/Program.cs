using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace lp2_banco_de_dados_2209
{
    class Program
    {

        static void Main(string[] args)

        {
            Console.WriteLine("Escreva o nome do usuário:");
            string nome = Console.ReadLine(); 
            string query = "INSERT into Pessoa(Nome) VALUES ('"+ nome +"')";
            string strConn = "Server=localhost;Database=test;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(strConn);

            MySqlCommand command = new MySqlCommand();

            command.Connection = conn;
            command.CommandText = query;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();

        }
    }
}
