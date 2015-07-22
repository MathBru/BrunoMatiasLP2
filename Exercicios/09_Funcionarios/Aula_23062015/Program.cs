using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_23062015
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFuncionarios = int.Parse(Console.ReadLine());
            Funcionario[] funcionarios = new Funcionario[numFuncionarios];

            for (int i = 0; i <= numFuncionarios; i++)
            {
                //Ler dados:
                string nome = Console.ReadLine();
                string cpf = Console.ReadLine();
                DateTime DataNasc = DateTime.Parse(Console.ReadLine());
                decimal salario = decimal.Parse(Console.ReadLine());
                DateTime dataAdmissao = DateTime.Parse(Console.ReadLine());

                //Criar objeto funcionario:



                //Salvar valores em funcionarios:

            }
        }
    }
}
