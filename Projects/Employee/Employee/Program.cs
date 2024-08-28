using System;
using System.Globalization;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();

            Console.Write("Nome: ");
            e.Nome = Console.ReadLine();

            Console.Write("Salario bruto: ");
            e.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            e.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Funcionario: " + e);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porcentagem = double.Parse(Console.ReadLine());
            Console.WriteLine();

            e.AumentarSalario(porcentagem);

            Console.WriteLine("Dados atualizados: " + e);
        }
    }
}