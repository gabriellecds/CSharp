

using EnumExample.Entities;
using EnumExample.Entities.Enums;

namespace EnumExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //Converter o enum para string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //Converter o string para enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);

        }
    }
}