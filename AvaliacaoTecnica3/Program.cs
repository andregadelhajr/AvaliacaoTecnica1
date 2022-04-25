using System;

namespace AvaliacaoTecnica3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] produto = { "Paracetamol", "Dorflex", "Deocil", "LisaDor"};
            int[] estoque = { 10, 20, 5, 8}; // quantidade dos prudutos lista no array acima por indice

            Console.WriteLine("---------------- Sistema estoque ----------------\n\n");

            string opcao;
            char op;

            Console.Write("Realizar consulta (S: sim/N: Não): ");
            op = char.Parse(Console.ReadLine());

            while (op == 's' || op == 'S')
            {
                Console.Clear();
                Console.WriteLine("---------------- Sistema estoque ----------------\n\n");

                do
                {
                    Console.WriteLine("Escolha um produto para verificar no estoque");
                    Console.Write("Opção: ");
                    opcao = Console.ReadLine();
                    if (string.Compare(opcao, "") == 0)
                    {
                        Console.WriteLine("Nome do Produto Obrigatório, Tente novamente\n");
                    }
                } while (string.Compare(opcao, "") == 0);


                int possui = 0;
                int qtd = 0;

                for (int i = 0; i < produto.Length; i++)
                {

                    if (string.Compare(opcao, produto[i]) == 0 && estoque[i] > 0)
                    {
                        possui = 2;
                        qtd = estoque[i];
                        break;
                    }
                    else
                    {
                        possui = 1;
                    }

                }

                if (possui == 2)
                {
                    Console.WriteLine($"\nPossui {qtd} desse produto no estoque\n");
                }
                else
                {
                    Console.WriteLine("\nNão a esse produto no estoque");
                }

                Console.WriteLine($"Total produtos no estoque: {produto.Length}\n");
                Console.WriteLine("Produtos ordenados:");
                Array.Sort(produto);
                foreach (string p in produto) Console.WriteLine(p);

                Console.Write("Realizar Nova consulta (S: sim/N: Não): ");
                if (Console.ReadKey().Key == ConsoleKey.N)
                {
                    Console.Clear();
                    Console.Write("\n\nEncerrando\n\n");
                    break;
                }
            }

            

        }
    }
}
