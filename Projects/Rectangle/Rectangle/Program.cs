using System;
using System.Globalization;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();

            Console.WriteLine("Entre com a largura e a altura do retangulo: ");

            r.Largura = double.Parse(Console.ReadLine());
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Area = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture)); ;

        }
    }
}