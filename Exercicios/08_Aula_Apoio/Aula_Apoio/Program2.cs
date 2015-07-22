using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Apoio
{
    class Program2
    {
        static void Main2(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double raiz = 0;


            for (int i = 0; i < N; i++)
            {
                double ladoA = double.Parse(Console.ReadLine());
                double ladoB = double.Parse(Console.ReadLine());
                double ladoC = double.Parse(Console.ReadLine());


                if (ladoA == ladoB && ladoB == ladoC)
                {
                    Console.WriteLine("O Triangulo é Equilátero!");
                }

                else if (ladoA != ladoB && ladoB != ladoA)
                {
                    Console.WriteLine("O triangulo é Escaleno!");

                    if (ladoA > ladoB && ladoA > ladoC)
                    {
                        raiz = ladoB * ladoB + ladoC * ladoC;
                        raiz = Math.Sqrt(raiz);
                        if (raiz == ladoA)
                        {
                            Console.WriteLine("Esse triangulo é Retângulo");
                        }

                    }


                    if (ladoB > ladoA && ladoB > ladoC)
                    {
                        raiz = ladoA * ladoA + ladoC * ladoC;
                        raiz = Math.Sqrt(raiz);
                        if (raiz == ladoB)
                        {
                            Console.WriteLine("Esse triangulo é Retângulo");
                        }

                    }

                    if (ladoC > ladoA && ladoC > ladoB)
                    {
                        raiz = ladoA * ladoA + ladoB * ladoB;
                        raiz = Math.Sqrt(raiz);
                        if (raiz == ladoC)
                        {
                            Console.WriteLine("Esse triangulo é Retângulo");
                        }
                        else
                        {
                            Console.WriteLine("Esse triangulo não é RetÂngulo");
                        }

                    }

                    else
                    {
                        Console.WriteLine("O triangulo é Isósceles!");
                    }





                }



                   
                




            }

        }
    }
}
