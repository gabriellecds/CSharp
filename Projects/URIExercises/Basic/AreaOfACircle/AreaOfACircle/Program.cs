using System;
using System.Globalization;

namespace AreaOfACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            double A;

            double R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = pi * (Math.Pow(R, 2));

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}