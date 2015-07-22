using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Recuperacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio2();
        }

        static void Exercicio1()
        {

            string nome = Console.ReadLine();
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} tem {1} anos." , nome, idade);
    
        }

        static void Exercicio2() 
        {
            double raioDoCirculo = double.Parse(Console.ReadLine());
            double areaCirculo = 0;
            areaCirculo = Math.PI * Math.Pow(raioDoCirculo, 2);



        }

        static void Exercicio3() 
        {
        
        }

        static void Exercicio4() 
        { 

        }

        static void Exercicio5() 
        { 

        }







    }
}
