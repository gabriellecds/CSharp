using System;
using System.Globalization;

namespace FirstProject
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string name = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int room = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preco do produto:");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu ultimo nome, idade e altura (mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');

            Console.WriteLine(name);
            Console.WriteLine(room);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(vet[0]);
            Console.WriteLine(vet[1]);
            Console.WriteLine(vet[2]);

            Console.ReadLine();

        }
    }
}
