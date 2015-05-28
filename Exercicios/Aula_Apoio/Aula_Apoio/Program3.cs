using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Apoio
{
    class Program3
    {
        static void Main3(string[] args)
        {

          int n = int.Parse(Console.ReadLine());
            int[] seq = new int[n];

            for(int i = 0; i < n; i++)
            {
                seq[i] = int.Parse(Console.ReadLine());
            }

            int somaPar = 0, somaImpar = 0;
            for(int i = 0; i< n; i++)
            {
                if (i % 2 == 0)
                    somaPar += seq[i];
                else
                    somaImpar += seq[i];
            }

            if (somaPar > somaImpar)
                Console.WriteLine("Sequência Par");
            else if (somaImpar > somaPar)
                Console.WriteLine("Sequência Ímpar");
            else
                Console.WriteLine("Sequência Neutra");
        

        }
    }
}
