﻿using Action.Entities; 

namespace Action
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD Case", 80.90));

            // objeto do tipo delegate Action
            Action<Product> act = UpdatePrice;
            list.ForEach(act);

            // chamando a funcao delgate direto: 
            // list.ForEach(UpdatePrice);

            // expressao lambda:
            // Action<Product> act = p => { p.Price += p.Price * 0.1; };
            // list.ForEach(act);
            // OU colocar diretamente no argumento do ForEach :
            //  list.ForEach(p => { p.Price += p.Price * 0.1; }); 

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1; 
        }
    }
}