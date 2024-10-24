using System.Globalization;
using Contract.Entities;
using Contract.Services; 

namespace Contract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture); 
            Console.Write("Contract Value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter the number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contracts myContract = new Contracts(contractNumber, contractDate, contractValue);

            ContractService contractService = new ContractService(new PaypalTaxService());
            contractService.ProcessContract(myContract, months);

            Console.WriteLine("Installments: ");
            foreach(Installment installment in myContract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}