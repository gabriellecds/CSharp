using System;
using System.Globalization;

namespace Vectors
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            string[] nome = new string[N];
            double[] compra = new double[N];
            double[] venda = new double[N];

            int i;

            for(i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                nome[i] = s[0];
                compra[i] = double.Parse(s[1]);
                venda[i] = double.Parse(s[2]);
            }

            double totalCompra = 0.0;
            double totalVenda = 0.0;

            for(i = 0; i < N; i++)
            {
                totalCompra += compra[i];
                totalVenda += venda[i]; 
            }

            double[] lucro = new double[N];
            double totalLucro = 0.0;

            int count10 = 0;
            int count20 = 0;
            int count20mais = 0; 

            for(i = 0; i < N; i++)
            {
                lucro[i] = venda[i] - compra[i];
                totalLucro += lucro[i];

                if (lucro[i] < (compra[i] * 0.1))
                {
                    count10++; 
                }
                else if (lucro[i] >= (compra[i] * 0.1) && lucro[i] <= (compra[i] * 0.2))
                {
                    count20++; 
                }
                else if (lucro[i] > (compra[i] * 0.2))
                {
                    count20mais++;
                }
            }

            Console.WriteLine("Lucro abaixo de 10%: " + count10);
            Console.WriteLine("Lucro entre 10% e 20%: " + count20);
            Console.WriteLine("Lucro acima de 20%: " + count20mais);
            Console.WriteLine("Valor total de compra: " + totalCompra);
            Console.WriteLine("Valor total de venda: " + totalVenda);
            Console.WriteLine("Lucro total: " + totalLucro);



        }
    }
}