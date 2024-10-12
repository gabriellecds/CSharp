using CarRental.Entities;

namespace CarRental.Services
{
	class RentalService
	{
		public double PricePerHour { get; private set; }
		public double PricePerDay { get; private set; }

        private ITaxService _taxService; 

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;  
        }

        public void ProcessInvoice(Rental rental)
        {
            TimeSpan durantion = rental.Finish.Subtract(rental.Start);

            double basicPayment = 0.0;

            if(durantion.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(durantion.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(durantion.TotalDays); 
            }

            double tax = _taxService.Tax(basicPayment);

            rental.Invoice = new Invoice(basicPayment, tax); 
        }
    }
}

