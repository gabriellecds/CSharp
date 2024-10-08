using Store.Entities;
using System.Globalization; 

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>(); 

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported? (c/u/i): ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i' || ch == 'I')
                {
                    Console.Write("Custom fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Product imported = new ImportedProduct(name, price, customFee);
                    list.Add(imported);
                }
                else if (ch == 'u' || ch == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    Product used = new UsedProduct(name, price, date);
                    list.Add(used);
                }
                else if (ch == 'c' || ch == 'C')
                {
                    Product common = new Product(name, price);
                    list.Add(common); 
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");

            foreach(Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}