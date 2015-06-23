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

            int[] funcionarios = new Funcionario[];

            for (int i = 0; i <= numFuncionarios; i++)
            {
                string nome = Console.ReadLine();
                string cpf = Console.ReadLine();
                DateTime DataNasc = Console.ReadLine();
                double salario = Console.ReadLine();
                DateTime dataAdmissao = Console.ReadLine();
            }
        }
    }
}
