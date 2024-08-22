using System;
using System.Globalization;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;

            p1 = new Person();
            p2 = new Person();

            Console.WriteLine("Dados da primeira pessoa: ");
            p1.name = Console.ReadLine();
            p1.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            p2.name = Console.ReadLine();
            p2.age = int.Parse(Console.ReadLine());

            if(p1.age > p2.age)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.name);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.name);
            }
        }
    }
}