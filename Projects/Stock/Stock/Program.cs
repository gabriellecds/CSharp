using System;
using System.Globalization; 

namespace Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product(); 

            Console.WriteLine("Entre os dados do produto: ");

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            p.Qte = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite a quantidade de produtos a ser adicionada ao estoque: ");
            int qte = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a ser removida do estoque: ");
            qte = int.Parse(Console.ReadLine());

            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}