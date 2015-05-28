using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirando_Ferrugem
{
    class Program
    {
                
        static void Main(string[] args)
        {
            Solucao2();
        }

        static void Solucao1()
        {
            var numero = 0;
            var soma = 0;
            var quantidade = 0;

            Console.WriteLine("Digite os números para calcular a média. Ao terminar digite 0.");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                quantidade++;
                soma += numero;
                numero = int.Parse(Console.ReadLine());
            }

            var media = 0;
            media = soma / quantidade;

            Console.WriteLine("A média é igual a {0}", media);
        }

        static void Solucao2()
        {
            var numero = 0;
            var numeros = new List<int>();

            Console.WriteLine("Digite os números para calcular a média. Ao terminar digite 0.");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                numeros.Add(numero);
                numero = int.Parse(Console.ReadLine());
            }

            var soma = 0;

            for (int i = 0; i < numeros.Count; i++)
            {
                soma += numeros[i];
            }

            var media = soma/numeros.Count;

            Console.WriteLine("A média é igual a {0}", media);
        }


    
        }
    }
}
