using System;
using System.Globalization; 

namespace DollarRate
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorDeMoeda Total = new ConversorDeMoeda();

            Console.Write("Qual é a cotaçao do dólar? ");
            Total.Cotacao = double.Parse(Console.ReadLine()); 

            Console.Write("Quantos dólares você vai comprar? ");
            Total.Compra = double.Parse(Console.ReadLine());


            Console.Write("Valor a ser pago em reais = R$ " + Total.ValorAPagar().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
        }
    }
}