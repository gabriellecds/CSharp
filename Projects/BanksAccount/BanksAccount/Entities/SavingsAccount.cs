﻿using System;
namespace BanksAccount.Entities
{
	sealed class SavingsAccount : Account
	{

		public double InterestRate { get; set; }

		public SavingsAccount()
		{
		}

		public SavingsAccount(int number, string holder, double balance, double interestRate)
			: base (number, holder, balance)
		{
			InterestRate = interestRate; 
		}

		public void UpdateBalance()
		{
			Balance += Balance * InterestRate; 
		}

        public sealed override void WithDraw(double amount)
        {
			base.WithDraw(amount);
			Balance -= 2.0; 
        }
    }
}

