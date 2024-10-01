using OrderEnum.Entities.Enums;
using OrderEnum.Entities;
using System.Globalization;

namespace OrderEnum
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Enter the client's data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Enter the order's data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, email, date);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int qty = int.Parse(Console.ReadLine());

                Product product = new Product(productName, price);

                OrderItem orderItem = new OrderItem(qty, price, product);

                order.AddItem(orderItem); 
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);

        }
    }
}