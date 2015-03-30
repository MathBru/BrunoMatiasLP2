using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vogais
{
    class Program
    {
        static void Main(string[] args)
        {
            //O programa deve ler uma mensagem de entrada padrão e dizer quantas vogais exitem na mensagem.


            string texto;
            int i; 
            char[] vogais = { 'a', 'e', 'i', 'o', 'u' }; 
            int total = 0; 


            Console.WriteLine("Digita uma mensagem de entrada:");
            texto = Console.ReadLine(); 

            for (i = 0; i < texto.Length - 1; i++) 
               
                {
                    if (texto[i] = 'a')
                    {
                        total++;
                    }
                    else if (texto[i] = 'e')
                    {
                        total++;
                    }

                    else if (texto[i] = 'i')
                    {
                        total++;
                    }

                    else if (texto[i] = 'o')
                    {
                        total++;
                    }

                    else if (texto[i] = 'u')
                    {
                        total++;
                    }

                }
            Console.Write("O total de vogais é: {0}", total); 
         
            
        }
    }
}
