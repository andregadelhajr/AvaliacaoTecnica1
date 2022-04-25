using System;

namespace AvaliacaoTecnica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sorteio = new Random().Next(1, 5);

            string resp = "s";
            int A = 0;//qtd de acertos
            int E = 0;//qtd de erros
            int passouPertoMais = 0;
            int passouPertoMenos = 0;

            while (resp == "s")
            {
                Console.WriteLine("Tente descobrir o número entre 1 a 5");
                int chute = int.Parse(Console.ReadLine());

                if (sorteio == chute)
                {
                    Console.Write("Parabéns, você acertou. ");
                    Console.WriteLine("Pensei em: {0}", sorteio);
                    Console.WriteLine("Tente novamente: (s/n)");
                    resp = Console.ReadLine();
                    A++;
                }
                else
                {
                    Console.Write("Errou. Tente de novo. ");
                    Console.WriteLine($"Pensei em: {sorteio}");

                    if (chute == sorteio - 1)
                    {
                        passouPertoMais++;
                    }else if (chute == sorteio + 1)
                    {
                        passouPertoMenos++;
                    }

                    Console.WriteLine("Tente novamente: (s/n)");
                    resp = Console.ReadLine();
                    E++;
                }
            }

            int TJogadas= A + E;

            Console.WriteLine("Você jogou um total de {0} vezes", TJogadas);
            Console.WriteLine("Você teve um total de acertos de {0} e erros de {1}", A, E);
            Console.WriteLine("Você teve um total de vezes que se aproximou ao número sorteado faltando:");
            Console.WriteLine("Um para mais {0} ", passouPertoMais);
            Console.WriteLine("Um para menos {0} ", passouPertoMenos);

        }
    }
}
