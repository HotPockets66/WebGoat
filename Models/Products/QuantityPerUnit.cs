using System;

namespace WebGoat.NET.Models.Products
{
    public class QuantityPerUnit
    {
        private int quantityPerUnit;

        public QuantityPerUnit(int quantityPerUnit)
        {
            isQuantityPerUnitValidAmount(quantityPerUnit);
            this.quantityPerUnit = quantityPerUnit;
        }

        public int getQuantityPerUnit()
        {
            return quantityPerUnit;
        }

        private void isQuantityPerUnitValidAmount(int quantityPerUnit)
        {
            if(quantityPerUnit <= 0)
            {
                throw new ArgumentException("Quantity amount must be more than 0");
            }
            if(quantityPerUnit > 1000)
            {
                throw new ArgumentException("Quantity amount must be less than 1000");
            }
        }
    }
}
