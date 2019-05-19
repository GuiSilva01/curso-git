using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Adivinhacao
{

    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random(); // criando uma instancia de Random
            int numeroSecreto = aleatorio.Next(1, 11); // gerando um numero aleatorio

            int nivel;
            int totalTentativa = 0;
            double pontosPerdidos;
            double pontos = 1000;
            int chute = 0;
            int somaChute = 0;


            do
            {
                Console.WriteLine("Qual o nivel de Dificuldade?");
                Console.WriteLine("(1)Facil  (2)Medio  (3)Dificil");
                Console.Write("Escolha:");
                nivel = Convert.ToInt16(Console.ReadLine());
                Console.Clear(); // Limpar Tela

                switch (nivel)// um switch para definir o total de tentativa e o nivel do jogo
                {
                    case 1:
                        totalTentativa = 15;
                        Console.WriteLine("******");
                        Console.WriteLine("FÁCIL");
                        Console.WriteLine("******");
                        break;
                    case 2:
                        totalTentativa = 10;
                        Console.WriteLine("******");
                        Console.WriteLine("MEDIO");
                        Console.WriteLine("******");
                        break;
                    case 3:
                        totalTentativa = 5;
                        Console.WriteLine("******");
                        Console.WriteLine("DIFICIL");
                        Console.WriteLine("******");
                        break;
                    default:
                        Console.WriteLine("***********************");
                        Console.WriteLine("Essa Opção nao é valida");
                        Console.WriteLine("***********************");
                        break;
                }
            }
            while (!(nivel > 0 && nivel <= 3));


            for (int i = 1; i <= totalTentativa; i++)// Loop Principal das tentativas
            {


                Console.WriteLine("Qual o seu {0} Chute de 0 a 10? ", i);
                chute = Convert.ToInt32(Console.ReadLine());// Variavel que armazena o chute do usuario

                if(chute != numeroSecreto)
                {
                    somaChute = somaChute + chute;
                }

                pontosPerdidos = (pontos - somaChute) /  2 ;

                if (chute < 0) //Garantir que nao chute numeros negativos
                {
                    Console.WriteLine("Erro nao pode chutar numeros negativos\n");
                }

                if (chute == numeroSecreto) // validacao do chute
                {
                    Console.WriteLine("Parabens Voce Acertou");
                    Console.WriteLine("Sua Pontuacao {0}", pontosPerdidos.ToString("F2"));
                    break;
                }
                else
                {
                    if (chute < numeroSecreto)
                    {
                        Console.WriteLine("************************************************************");
                        Console.WriteLine("Seu numero é menor que o numero secreto ! Tente novamente...");
                        Console.WriteLine("************************************************************\n\n");
                    }
                    else
                    {
                        if (chute > numeroSecreto)
                        {
                            Console.WriteLine("************************************************************");
                            Console.WriteLine("Seu numero é maior que o numero secreto ! tente novamente...");
                            Console.WriteLine("************************************************************\n\n");
                        }

                    }
                }
                if (i == totalTentativa)
                {
                    Console.Clear();
                    Console.WriteLine("*****************************");
                    Console.WriteLine("Voce Perdeu Tente novamente !");
                    Console.WriteLine("*****************************");

                }



            }
        }
    }
}
