﻿using System;
using System.Globalization;
using System.Security.AccessControl;

namespace Store.Entities
{
	class UsedProduct : Product
	{

		public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base (name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name
                + " (used) $"
                + base.PriceTag()
                + " (Manufacture Date: "
                + ManufactureDate
                + ")";
        }
    }
}

