using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace Exercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 1;
            while (opcao != 0)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Consultar");
                Console.WriteLine("0 - Sair");
                 opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {

                    case 1:
                        Inserir();
                        break;

                    case 2:
                        Consultar();
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }


            }

            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=");
            conn.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
        }
      
        public static void Inserir()
        {
                Console.WriteLine("Insira seus Dados");
                Pessoa p = new Pessoa();    
                Console.WriteLine("Nome:");
                p.Nome = Console.ReadLine();
                Console.WriteLine("Sobrenome:");
                p.Sobrenome = Console.ReadLine();
                Console.WriteLine("Peso:");
                p.Peso = double.Parse(Console.ReadLine());
                Console.WriteLine("Altura:");
                p.Altura = double.Parse(Console.ReadLine());
                Console.WriteLine("Telefone:");
                p.Telefone = Console.ReadLine();


                string q = string.Format(new CultureInfo("en"), "INSERT INTO PESSOA(Nome, Sobrenome, Peso, Altura, Telefone");

            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=");
            conn.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = q;
            command.ExecuteNonQuery();

        }
        

        public static void Consultar()
        {
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("1 - Consultar pelo ID");
            Console.WriteLine("2 - Consultar pelo Nome");
            int opcao = int.Parse(Console.ReadLine());

            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=");
            conn.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            
            command.ExecuteNonQuery();

            if (opcao == 1)
            {
                Console.WriteLine("Digite um Nome: ");
                string nome = Console.ReadLine();

                string str = string.Format("SELECT * FROM peoples WHERE Nome = '{0}'", nome);
                command.CommandText = str;
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("ID:{0}  NOME:{1}  SOBRENOME:{2}",
                                           reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                    }
                    reader.Close();
                    Console.WriteLine("");
                    Console.WriteLine("---> Deseja ver o registro completo de um desses Nomes?? 1-SIM / 0-NÃO");
                    int novo = int.Parse(Console.ReadLine());

                    if (novo != 0)
                    {
                        Console.WriteLine("---> Escolha um ID e digite!!");
                        int novoId = int.Parse(Console.ReadLine());

                        string strr = string.Format("SELECT * FROM peoples WHERE Id = {0}", novoId);
                        command.CommandText = strr;
                        reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            Console.WriteLine("ID:{0}  NOME:{1}  SOBRENOME:{2}  PESO:{3}  ALTURA:{4}  TELEFONE:{5}",
                                               reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                               reader.GetDouble(3), reader.GetDouble(4), reader.GetString(5));
                        }
                        reader.Close();
                    }
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Não existe o NOME {0} no sistema!!", nome);
                    Console.WriteLine("");
                }
                
            }

            else if (opcao == 2)
                    {
                        
                        Console.WriteLine("Digite um ID: ");
                        int id = int.Parse(Console.ReadLine());
                        
                        string str = string.Format("SELECT * FROM peoples WHERE Id = '{0}'", id);
                        command.CommandText = str;

                        MySqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("ID:{0}  NOME:{1}  SOBRENOME:{2}  PESO:{3}  ALTURA:{4}  TELEFONE:{5}",
                                                   reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                                   reader.GetDouble(3), reader.GetDouble(4), reader.GetString(5));
                            }
                        }
                        else
                        {
                            Console.WriteLine("INFORMAÇÃO IMPORTANTE: Não existe o ID {0} no sistema!!", id);
                            Console.WriteLine("");
                        }
                        reader.Close();
                    }
                }
                
                                  
        }
      
    }
               
    

