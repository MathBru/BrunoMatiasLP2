using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Aula_29_09
{
    class Program
    {
        static void Main(string[] args)
        {

            int valor = 0;

            while (valor != 5)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma Opção do Menu:");
                Console.WriteLine("\n 1-Consulta\n 2-Inserir Dados\n 3-Remover\n 4-Atualizar\n 5-Sair");
                valor = int.Parse(Console.ReadLine());

                switch (valor)
                {
                    case 1:
                        Consulta();
                        break;
                    case 2:
                        Inserir();
                        break;
                    case 3:
                        Atualizar();
                        break;
                    case 4:
                        Remover();
                        break;

                    default:

                        break;
                }

            }
            Console.WriteLine("Obrigado por usar esse programa!!!");

        }

        public static void ConsultaBd(string query)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pud=;");
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = query;
        }

        public static void Consulta()
        {
            Console.WriteLine("Consultando:\n");
           
            string q = "SELECT";
            ConsultaBd(q);
        }

        public static void Inserir()
        {
            Console.WriteLine("Inserindo:\n");
            string modelo = Console.ReadLine();
            string marca = Console.ReadLine();


            string q = "INSERT NOME";
            ConsultaBd(q);
        }

        public static void Atualizar()
        {
            Console.WriteLine("Atualizando:\n");
            string q = "UPDATE.......";
            ConsultaBd(q);
        }

        public static void Remover()
        {
            Console.WriteLine("Remover:\n");
            string q = "DELETE.......";
            ConsultaBd(q);
        }

    }
}
