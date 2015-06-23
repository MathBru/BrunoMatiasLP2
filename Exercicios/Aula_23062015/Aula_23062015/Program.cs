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

           


            for (int i = 0; i <= numFuncionarios; i++)
            {
                string nome = Console.ReadLine();
                string cpf = Console.ReadLine();
                DateTime DataNasc = Console.ReadLine();
                double salario = Console.ReadLine();
                DateTime dataAdmissao = Console.ReadLine();
              

             

                if (dataAdmissao >= 2014)
                {
                    double aumento = 423.45;
                    salario += aumento;

                }

                else if (dataAdmissao >= 2010 || dataAdmissao <= 2013 )
                {
                    salario += (salario / 100) * 9.84;
                }

                else if (dataAdmissao >= 2000 || dataAdmissao <= 2009)
                {
                    salario += (salario / 100) * 16.4;
                }

                else if (dataAdmissao <= 1999)
                {
                    salario += (salario / 100) * 22.6;
                }

            }














        }
    }
}
