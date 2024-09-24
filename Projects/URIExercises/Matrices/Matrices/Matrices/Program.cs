using System;
using System.Globalization;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] a = Console.ReadLine().Split(' ');
            int m = int.Parse(a[0]);
            int n = int.Parse(a[1]);
            int i, j; 

            int[,] mat = new int[m, n];

            for(i = 0; i < m; i++)
            {
                string[] v = Console.ReadLine().Split(' ');

                for(j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(v[j]); 
                }
            }

            int value = int.Parse(Console.ReadLine());

            for(i = 0; i < m; i++)
            {
                for(j = 0; j < n; j++)
                {
                    if (mat[i, j] == value)
                    {
                        Console.WriteLine("Position " + i + ", " + j + ":");

                        string left = (j > 0) ? "Left: " + mat[i, j - 1] : null;
                        string right = (j < n - 1) ? "Right: " + mat[i, j + 1] : null;
                        string down = (i < m - 1) ? "Down: " + mat[i + 1, j] : null;
                        string up = (i > 0) ? "Up: " + mat[i - 1, j] : null;

                        if (left != null) Console.WriteLine(left);
                        if (right != null) Console.WriteLine(right);
                        if (down != null) Console.WriteLine(down);
                        if (up != null) Console.WriteLine(up);
                    }
                }
            }

            Console.WriteLine();

        }
    }
}