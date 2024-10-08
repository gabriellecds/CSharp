using System;
namespace Contributors.Entities
{
	abstract class Account
	{
		public string Name { get; set; }
		public double AnnualIncome { get; set; }

        protected Account(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Taxes(); 
	}
}

