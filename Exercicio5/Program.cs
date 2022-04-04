using System;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Produto p = new Produto();

            System.Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Quantidade: ");
            p.Quantidade =  int.Parse(Console.ReadLine());
            Console.Write("Valor: ");
            p.Valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("dados do produto: Nome: {0}, Quantidade {1}, Preço {2}. Valor total: {3}",
            p.Nome,p.Quantidade,p.Valor,p.ValorTotalEmEstoque());
            
            Console.WriteLine("Digite a quantidade de produtos a ser retirado");
            p.RemoverProdutos(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("dados do produto: Nome: {0}, Quantidade {1}, Preço {2}. Valor total: {3}", p.Nome,p.Quantidade,p.Valor,p.ValorTotalEmEstoque());
            
            Console.WriteLine("Digite a quantidade de produtos a ser adicionado");
            p.AdicionarProdutos(Convert.ToInt32(Console.ReadLine()));
            
            Console.WriteLine("dados do produto: Nome: {0}, Quantidade {1}, Preço {2}. Valor total: {3}", p.Nome,p.Quantidade,p.Valor,p.ValorTotalEmEstoque());
        }
    }
}