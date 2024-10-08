using System;
namespace Contributors.Entities
{
	class Companies : Account
	{
		public int Employees{ get; set; }
        double taxes; 

        public Companies(string name, double annualIncome, int employees) : base(name, annualIncome)
        {
            Employees = employees;
        }

        public override double Taxes()
        {
            if(Employees <= 10)
            {
                taxes = AnnualIncome * 0.16; 
            }
            else
            {
                taxes = AnnualIncome * 0.14; 
            }

            return taxes; 
        }
    }
}

