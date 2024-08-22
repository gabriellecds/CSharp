using System;
using System.Globalization;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1, f2;

            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario: ");
            f1.nome = Console.ReadLine();
            f1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario: ");
            f2.nome = Console.ReadLine();
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.salario + f2.salario) / 2.00;

            Console.WriteLine("Salario medio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}