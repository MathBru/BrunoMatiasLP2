using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Viagem
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroCarros = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int numeroDePessoas = 0;

            List<Carro1> Carros = new List<Carro1>();

            for (int i = 0; i < numeroCarros; i++)
            {
                Carro1 carros = new Carro1();
                               
                
                string modelo = Console.ReadLine();
                string marca = Console.ReadLine();
                string placa = Console.ReadLine();
                int capPassageiros = int.Parse(Console.ReadLine());
                                
                carros.SetModelo(modelo);
                carros.SetMarca(marca);
                carros.SetPlaca(placa);
                carros.SetCapacidadePassageiros(capPassageiros);
                carros.SetValueToId();
                                                
                carros.GetModelo();
                carros.GetMarca();
                carros.GetPlaca();
                carros.GetId();
                Carros.Add(carros);

                Console.WriteLine();
            }

            int numeroDeCarroCheio = 0;

            int ide = 1;
            


            while (ide != -1)
            {
                
                    ide = int.Parse(Console.ReadLine());
                    
                    if (ide == -1)
                    {
                        break;
                    }

                
                

                if (ide > Carros.Count)
                {
                    Console.WriteLine("Carro Inválido");
                    
                }

                if (ide <= Carros.Count)
                {
                    if (Carros[ide - 1].GetCapacidadePassageiros() > 0)
                    {
                        int vagas = Carros[ide - 1].GetCapacidadePassageiros();
                        vagas--;
                        Carros[ide - 1].SetCapacidadePassageiros(vagas);
                        numeroDePessoas++;

                        if (vagas == 0)
                        {
                            numeroDeCarroCheio++;
                        }
                    }

                    else
                    {
                        Console.WriteLine("Carro Lotado");
                        
                        if (numeroDeCarroCheio == numeroCarros)
                        {
                            break;
                        }

                    }
                }

                
            }

            for (int j = 0; j < numeroCarros; j++)
            {
                Console.WriteLine("Carro"+ (j + 1) + ": " + Carros[j].GetModelo() + " - " +Carros[j].GetMarca() + "(" + Carros[j].GetPlaca() + ")") ;
                Console.WriteLine("Passageiros");
                Console.WriteLine("Vagas Restantes: " + Carros[j].GetCapacidadePassageiros());
                Console.WriteLine();
            }

            Console.WriteLine("Número de pessoas na viagem: " + numeroDePessoas);




        }
    }
}
