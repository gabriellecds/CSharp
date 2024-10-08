using Contributors.Entities;
using System.Globalization;

namespace Contributors
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<Account> list = new List<Account>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual ou company? (i/c): ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Annual Income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individuals(name, income, health)); 
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    list.Add(new Companies(name, income, employees));
                }
            }

            double sum = 0; 

            Console.WriteLine();
            Console.WriteLine("PAXES PAID: ");
            foreach(Account a in list)
            {
                Console.WriteLine(a.Name + ": $" + a.Taxes().ToString("F2", CultureInfo.InvariantCulture));
                sum += a.Taxes(); 
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $" + sum.ToString("F2", CultureInfo.InvariantCulture));
            

        }
    }
}