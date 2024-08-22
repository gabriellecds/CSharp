using System;
using System.Globalization;


namespace RepetitionStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string tipo1, tipo2, tipo3;

            tipo1 = Console.ReadLine();

            if (tipo1 == "vertebrado")
            {
                tipo2 = Console.ReadLine();

                if (tipo2 == "ave")
                {
                    tipo3 = Console.ReadLine();

                    if (tipo3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (tipo3 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if (tipo2 == "mamifero")
                {
                    tipo3 = Console.ReadLine();

                    if (tipo3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (tipo3 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else if (tipo1 == "invertebrado")
            {
                tipo2 = Console.ReadLine();

                if (tipo2 == "inseto")
                {
                    tipo3 = Console.ReadLine();

                    if (tipo3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (tipo3 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (tipo2 == "anelideo")
                {
                    tipo3 = Console.ReadLine();

                    if (tipo3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (tipo3 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }





        }
    }
}