﻿using BanksAccount.Entities;

namespace BanksAccount
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.WithDraw(10.0);
            acc2.WithDraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);


            //Account acc = new Account(1001, "Alex", 0.0);
            //BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            ////Upcasting
            //Account acc1 = bacc;
            //Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            //Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            ////Downcasting
            //// erro:  BusinessAccount bacc4 = acc2;
            //BusinessAccount bacc4 = (BusinessAccount)acc2;
            //bacc4.Loan(100.0);

            //// erro: BusinessAccount bacc5 = (BusinessAccount)acc3;
            //// savings account nao é compativel com o business account,
            //// mas o compilador nao preve isso, o erro é só quando erra.
            //// tem que testar:
            //if(acc3 is BusinessAccount)
            //{
            //    // BusinessAccount bacc5 = (BusinessAccount)acc3;
            //    BusinessAccount bacc5 = acc3 as BusinessAccount; 
            //    bacc5.Loan(200.0);
            //    Console.WriteLine("Loan!");
            //}

            //if(acc3 is SavingsAccount)
            //{
            //    // SavingsAccount bacc5 = (SavingsAccount)acc3;
            //    SavingsAccount bacc5 = acc3 as SavingsAccount; 
            //    bacc5.UpdateBalance();
            //    Console.WriteLine("Update!");
            //}

        }
    }
}