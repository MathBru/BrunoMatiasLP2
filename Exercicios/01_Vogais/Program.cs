using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vogais_
{
    class Program
    {
        static void Main(string[] args)
        {

            //O programa deve ler uma mensagem de entrada padrão e dizer quantas vogais exitem na mensagem.


                char frase;
	            int i, contador = 0;
         
            Console.WriteLine("Digite uma mensagem de entrada padrão:");
            texto = int.Parse(Console.ReadLine());


            for (int i = 0; i < texto.Length; i++)
            {
                if((frase[i]=='a')||(frase[i]=='i')||(frase[i]=='e')||(frase[i]=='o')||(frase[i]=='u'))
		        {
			        contador++;
		        }
            }
            

             
            


        }

    }
}
