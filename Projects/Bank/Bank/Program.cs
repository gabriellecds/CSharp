using System.Globalization;
using Bank.Entities;
using Bank.Entities.Exceptions;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                acc.Withdraw(withdraw);

                Console.Write("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine();
            }
            catch(DomainException e)
            {
                Console.WriteLine("Error: " + e.Message); 
            }
        }
    }
}