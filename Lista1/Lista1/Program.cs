using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio1();
        }

        static void Exercicio1()
        {
            //Faça um programa que leia um número N e calcule o fatorial desse número.

            int numero;
            int fatorial = 1;

            numero = int.Parse(Console.ReadLine());

            while (numero > 0)
            {
                fatorial *= numero;
                numero--;
            }

            Console.WriteLine(fatorial);
        }

        static void Exercicio2()
        {

            int numero;
            double soma = 0;
            int fatorial = 0;

            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                double division = fatorial *= numero / (numero * 2) + 1;
                numero--;

                if (i % 2 == 0)
                {
                    soma -= division;
                }
                else
                {
                    soma += division;
                }

            }

            Console.WriteLine(soma);

        }

        static void Exercicio3()
        {
             
            int numeroFuncionarios = 0;
            var salarioFuncionarios = new Dictionary<string, decimal>();

            Console.WriteLine("Informe o numero de Funcionários");
            numeroFuncionarios = int.Parse(Console.ReadLine());

            for (var i = 0; i < numeroFuncionarios; i++)
            {
                Console.WriteLine("Informe o nome do Funcionário:");
                string name = Console.ReadLine();

                Console.WriteLine("Informe o salário do Funcionário:");
                decimal salario = Decimal.Parse(Console.ReadLine());

                salarioFuncionarios.Add(name, salario);
            }

            foreach (var funcionarioSalario in salarioFuncionarios)
            {
                string nome = funcionarioSalario.Key;
                decimal salario = funcionarioSalario.Value;
                decimal novoSalario = salario;

                if (salario > 0 || salario < 2999)
                {
                    novoSalario += (salario * 25)/100;
                }

                if (salario > 3000 || salario < 3999)
                {
                    novoSalario += (salario * 20)/100;
                }

                if (salario > 4000 || salario > 4999)
                {
                    novoSalario += (salario * 15) / 100;
                }

                if (salario > 5000 || salario < 5999)
                {
                    novoSalario += (salario * 10) / 100;
                }

                if (salario > 6000 || salario < 6999)
                {
                    novoSalario += (salario * 5) / 100;
                }
 

                Console.WriteLine("Funcionário {0}: Antigo Salário = R${1}, reajuste = R${2}.", nome, salario, novoSalario);
            }
            
        }

        static void Exercicio4()
        {
            int primeirojogador = 0;
            int segundoJogador = 0;
            string jgp;
            string jgs;

            Console.WriteLine("Partida de pingue-pongue!!\r\n Digite 1 caso o ponto seja do JOGADOR1, ou 2 caso ponto seja do JOGADOR2:\r\n ");

            Console.WriteLine("Nome do Jogador 1:");
            jgp = Console.ReadLine();

            Console.WriteLine("Nome do Jogador 2:");
            jgs = Console.ReadLine();


            while (true)
            {

                int pontuacao;
                pontuacao = int.Parse(Console.ReadLine());

                if (pontuacao == 1)
                {
                    primeirojogador++;
                }
                else
                {
                    segundoJogador++;
                }

                if (primeirojogador >= 21 || segundoJogador >= 21)
                {

                    if (primeirojogador - segundoJogador >= 2)
                    {
                        Console.WriteLine("{0} é o Vencedor!!", jgp);
                        break;
                    }
                    if (segundoJogador - primeirojogador >= 2)
                    {
                        Console.WriteLine("{0} é o Vencedor!!", jgs);
                        break;
                    }


                }
                    Console.Clear();
                    Console.WriteLine("Placar:\n{0}: {1}\n{2}: {3}", jgp, primeirojogador, jgs, segundoJogador);
                }
            }
        
        static void Exercicio5()
        {
            
             double distanciaRest = 600;
             double combustivelRest = 50;
             double distanciaPerc;
             double combustivelUsa;
             double desempenhoMedio;

             while (true)
             {
                 Console.WriteLine("Qual foi a distancia percorrida?(KM)");
                 distanciaPerc = double.Parse(Console.ReadLine());

                 Console.WriteLine("Quanto gastou de combustivel?(Litros)");
                 combustivelUsa = double.Parse(Console.ReadLine());

                 distanciaRest -= distanciaPerc;
                 combustivelRest -= combustivelUsa;


                 if (combustivelRest <= 0)
                 {
                     Console.WriteLine("O carro parou antes de chegar por falta de combustível.");
                     break;
                 }

                 if (distanciaRest <= 0)
                 {
                     Console.WriteLine("O carro chegou ao seu destino. ");
                     break;
                 }


                 Console.WriteLine("Distancia restante: {0}Km \n Combustível restante: {1}L", distanciaRest, combustivelRest);
             }

             desempenhoMedio = (600 - distanciaPerc) / (50 - combustivelUsa);
             Console.WriteLine("O desempenho médio do carro foi:{0}Km/L", desempenhoMedio);
              


        }

        static void Exercicio6()
        {
            
        }

        static void Exercicio7()
        {

            
        }
                                    
        static void Exercicio8()
        {
            //Faça um programa que leia um número N e calcule e mostre como resposta a soma de todos dos números inteiros entre 1 e N. 

            int numero;
            int soma = 0;

            numero = int.Parse(Console.ReadLine());

            while (numero > 0)
            {
                soma += numero;
                numero--;
            }

            Console.WriteLine(soma);
        }

              
    }
}
