using System;
using System.Globalization;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {

            Student s = new Student();

            Console.Write("Nome do aluno: ");
            s.Nome = Console.ReadLine();

            Console.WriteLine("Digite as tres notas do aluno: ");
            s.N1 = double.Parse(Console.ReadLine());
            s.N2 = double.Parse(Console.ReadLine());
            s.N3 = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTA FINAL: " + s.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if(s.NotaFinal() >= 60.0)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");

                double falta = 60 - s.NotaFinal();
                Console.WriteLine("FALTARAM " + falta.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }

        }
    }
}