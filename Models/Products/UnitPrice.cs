using System;

namespace WebGoat.NET.Models.Products
{
    public class UnitPrice
    {
        private decimal unitPrice;

        public UnitPrice(decimal unitPrice)
        {
            isUnitPriceDigitsValid(unitPrice);
            isUnitPriceValidAmount(unitPrice);
            this.unitPrice = unitPrice;
        }

        public decimal getUnitPrice()
        {
            return this.unitPrice;
        }

        private void isUnitPriceValidAmount(decimal unitPrice)
        {
            if (unitPrice <= 0)
            {
                throw new ArgumentOutOfRangeException("Unit price must be more than 0");
            }
            if (unitPrice >= 5000)
            {
                throw new ArgumentException("Unit price must be less than 5000");
            }
        }

        private decimal isUnitPriceDigitsValid(decimal unitPrice)
        {
            return Math.Round(unitPrice, 2);
        }
    }
}
