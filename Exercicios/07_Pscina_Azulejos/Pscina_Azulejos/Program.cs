using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pscina_Azulejos
{
    class Program
    {
        static void Main(string[] args)
        {

            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int[,] pisc = new int[m, n];

            int defeitoTotal = 0;

            for (int i = 0; i < m; i++)
            {
                int defeitoLinha = 0;
                for (int j = 0; j < n; j++)
                {
                    pisc[i, j] = int.Parse(Console.ReadLine());
                    if (pisc[i, j] == 1)
                    {
                        defeitoTotal++;
                        defeitoLinha++;
                    }
                }

                Console.WriteLine("A linha {0} tem {1} azulejos defeituosos.", i, defeitoLinha);
            }

            Console.WriteLine("Total de {0} azulejos defeituosos.", defeitoTotal);

            for (int i = 0; i < n; i++)
            {
                int defeitoColuna = 0;

                for (int j = 0; j < m; j++)
                {
                    if (pisc[j, i] == 1)
                    {
                        defeitoColuna++;
                    }
                }

                Console.WriteLine("A coluna {0} tem {1} azulejos defeituosos.", i, defeitoColuna);
            }

            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Gasto total: {0}", defeitoTotal * preco);

        }
    }
}
