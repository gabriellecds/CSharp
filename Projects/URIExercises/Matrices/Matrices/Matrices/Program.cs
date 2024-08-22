using System;
using System.Globalization;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            double[,] A = new double[N, N];
            double[,] alt = new double[N, N]; 

            int i, j;

            for(i=0; i<N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                for (j=0; j<N; j++)
                {
                    A[i, j] = double.Parse(s[j]); 
                }
            }

            double soma = 0.0;

            //for (i = 0; i < N; i++)
            //{
            //    for (j = 0; j < N; j++)
            //    {
            //        if (A[i,j] > 0)
            //        {
            //            soma += A[i, j]; 
            //        }
            //    }
            //}

            //Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));


            //int linha = int.Parse(Console.ReadLine());
            //Console.Write("LINHA ESCOLHIDA: ");

            //for (j = 0; j < N; j++)
            //{
            //    Console.Write(A[linha, j] + " ");

            //}
            //Console.WriteLine();

            //int coluna = int.Parse(Console.ReadLine());
            //Console.Write("COLUNA ESCOLHIDA: ");

            //for (i = 0; i < N; i++)
            //{
            //    Console.Write(A[i, coluna] + " ");

            //}
            //Console.WriteLine();


            //Console.Write("DIAGONAL PRINCIPAL: ");

            //for (i = 0; i < N; i++)
            //{
            //    Console.Write(A[i, i] + " ");
            //}
            //Console.WriteLine();

            Console.WriteLine("MATRIZ ALTERADA: ");
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    

                    if (A[i, j] < 0)
                    {
                        alt[i, j] = A[i, j] * A[i, j];

                        A[i, j] = alt[i, j];

                    }

                    Console.Write(A[i, j] + " ");

                }

                Console.WriteLine();
            }

        }
    }
}