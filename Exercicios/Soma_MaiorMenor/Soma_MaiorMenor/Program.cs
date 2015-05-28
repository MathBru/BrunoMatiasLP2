using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_MaiorMenor
{
    internal class Program
    {
        private static void Main(string[] a11rgs)
        {
            var soma = 0;
            int maior;
            int menor;

            Console.WriteLine("Digite a quantidade de numeros: ");

            var quantidade = int.Parse(Console.ReadLine());
            var numero = int.Parse(Console.ReadLine());
            maior = numero;
            menor = numero;

            for (int i = 0; i < quantidade - 1; i++)
            {
                maior = Math.Max(maior, numero);
                menor = Math.Min(menor, numero);
                soma += numero;

                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("A soma é {0}, o maior número é {1} e o menor é {2}", soma, maior, menor);
        }
    }
}
