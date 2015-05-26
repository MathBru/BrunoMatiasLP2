using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Apoio
{
    class Program
    {
        static void Main2(string[] args)
        {
            int P = int.Parse(Console.ReadLine());
            int Q = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int multiplo = 0;

            for (int i = P; i <= Q; i++)
            {
                multiplo = N * i;
                Console.WriteLine(" {0} \r", multiplo);
            }

           

        }
    }
}
