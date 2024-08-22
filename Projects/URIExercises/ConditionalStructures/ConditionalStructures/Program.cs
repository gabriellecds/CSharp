using System;
using System.Globalization;

namespace ConditionalStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            double n1, n2, n3, n4, average;

            n1 = double.Parse(vet[0]);
            n2 = double.Parse(vet[1]);
            n3 = double.Parse(vet[2]);
            n4 = double.Parse(vet[3]);

            double w1, w2, w3, w4;
            w1 = 2.0;
            w2 = 3.0;
            w3 = 4.0;
            w4 = 1.0;

            double pesos = w1 + w2 + w3 + w4;

            average = ((n1 * w1) + (n2 * w2) + (n3 * w3) + (n4 * w4)) / pesos;

            Console.WriteLine("Media: " + average.ToString("F1", CultureInfo.InvariantCulture));

            if (average >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (average >= 5.0 && average <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                double notaExame = double.Parse(Console.ReadLine());
                Console.WriteLine("Nota do exame: "+ notaExame.ToString("F1", CultureInfo.InvariantCulture));

                average = (average + notaExame) / 2;

                if (average >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: "+ average.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + average.ToString("F1", CultureInfo.InvariantCulture));

                }
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }

            Console.ReadLine();
        }
    }
}