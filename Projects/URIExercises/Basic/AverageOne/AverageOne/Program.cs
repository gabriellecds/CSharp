using System;
using System.Globalization;

namespace AverageOne
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] beginningDay = Console.ReadLine().Split(' ');
            string[] beginningTime = Console.ReadLine().Split(':');

            string[] finishingDay = Console.ReadLine().Split(' ');
            string[] finishingTime = Console.ReadLine().Split(':');

            int firstDay = int.Parse(beginningDay[1]);
            int lastDay = int.Parse(finishingDay[1]);

            int hourI = int.Parse(beginningTime[0]);
            int minutesI = int.Parse(beginningTime[1]);
            int secondsI = int.Parse(beginningTime[2]);

            int hourF = int.Parse(finishingTime[0]);
            int minutesF = int.Parse(finishingTime[1]);
            int secondsF = int.Parse(finishingTime[2]);

            int totalSegundosInicio = secondsI + minutesI * 60 + hourI * 3600 + firstDay * 86400;
            int totalSegundosFim = secondsF + minutesF * 60 + hourF * 3600 + lastDay * 86400;

            int duracaoTotalSegundos = totalSegundosFim - totalSegundosInicio;

            int dias = duracaoTotalSegundos / 86400;
            duracaoTotalSegundos %= 86400;

            int horas = duracaoTotalSegundos / 3600;
            duracaoTotalSegundos %= 3600;

            int minutos = duracaoTotalSegundos / 60;
            duracaoTotalSegundos %= 60;

            int segundos = duracaoTotalSegundos;


            Console.WriteLine($"{dias} dia(s)");
            Console.WriteLine($"{horas} hora(s)");
            Console.WriteLine($"{minutos} minuto(s)");
            Console.WriteLine($"{segundos} segundo(s)");

            Console.ReadLine();

        }
    }
}