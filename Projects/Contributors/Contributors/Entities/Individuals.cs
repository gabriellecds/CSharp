using System;
namespace Contributors.Entities
{
	class Individuals : Account
	{
		public double Health { get; set; }
        double taxes; 

        public Individuals(string name, double annualIncome, double health) : base(name, annualIncome)
        {
            Health = health;
        }

        public override double Taxes()
        {
            if(AnnualIncome < 20000.00)
            {
                taxes = AnnualIncome * 0.15;

                if (Health != 0)
                {
                    taxes = taxes - (Health / 2); 
                }
            }
            else if(AnnualIncome >= 20000.00)
            {
                taxes = AnnualIncome * 0.25;
                if (Health != 0)
                {
                    taxes = taxes - (Health / 2);
                }
            }

            return taxes;
        }
    }
}

