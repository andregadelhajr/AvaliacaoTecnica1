using System;
using System.Collections.Generic;

// Sistema que informa o total de vendas e a comissão de funcionários

// O número de índices (quantidade de posições do array) deve ser pedido ao usuário.
// A partir daí criar o array. 
// Da mesma forma com o array produtos (efetuar a abstração da classe)

namespace AvaliacaoTecnica1
{
    internal class Program
    {

        public class Vendedor
        {
            public int ID { get; set; }
            public double Valor { get; set; }
            public int TotalVendas { get; set; }
            public double SomaValores { get; set; }
            public double comissoes { get; set; }


            public Vendedor(double valor)
            {
                this.Valor = valor;
            }
            public void SomaVendas()
            {
                TotalVendas++;
            }
            public void SomarValores(double venda)
            {
                double soma = SomaValores + venda;
                SomaValores = soma;

            }
            public double Comissao()
            {
                double comissao;
                if (TotalVendas <= 5)
                {
                    comissao = SomaValores * 0.004;
                    comissoes = comissao;

                }
                else if (TotalVendas >= 6 && TotalVendas <= 10)
                {
                    comissao = SomaValores * 0.013;
                    comissoes = comissao;
                }
                else if (TotalVendas >= 11 && TotalVendas <= 15)
                {
                    comissao = SomaValores * 0.03;
                    comissoes = comissao;
                }
                else if (TotalVendas >= 16)
                {
                    comissao = SomaValores * 0.05;
                    comissoes = comissao;
                }

                return comissoes;
            }

            public override string ToString()
            {
                return "\nId do vendedor: " + ID 
                    + "\nValor total das vendas: " + SomaValores 
                    + "\nTotal de vendas: " + TotalVendas 
                    + "\nComissão total: " + Comissao();
            }
        }

        public class Produto
        {
            public string NomeProduto { get; set; }

            public Produto(string nomeProduto)
            {
                this.NomeProduto = nomeProduto;
            }
        }


        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor();
            List<Vendedor> vend = new List<Vendedor>();
            List<Produto> produto = new List<Produto>();

            Console.WriteLine("Digite a quantidade de produtos disponíveis: ");
            int nProdutos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ID do vendedor: ");
            vendedor.ID = int.Parse(Console.ReadLine());


            int[] v = new int[nProdutos];
            int quantidade = nProdutos;

            for (int i = 0; i < nProdutos; i++)
            {

                Console.WriteLine($"Quantidade de produtos: {quantidade}");
                Console.WriteLine($"Digite o nome do produto {i + 1}: ");
                string nomeProduto = Console.ReadLine();
                Console.WriteLine($"Digite o valor do produto {i + 1}: ");
                double valor = double.Parse(Console.ReadLine());

                produto.Add(new Produto(nomeProduto));
                vend.Add(new Vendedor(valor));

                vendedor.SomaVendas();
                vendedor.SomarValores(valor);
                quantidade--;
            }
            
            Console.WriteLine(vendedor.ToString());
        }
    }
}
