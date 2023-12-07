using System;

namespace WebGoat.NET.Models.Products
{
    public class UnitsInStock
    {
        private short unitsInStock;

        public UnitsInStock(short UnitsInStock)
        {
            isUnitsInStockValidAmount(UnitsInStock);
            this.unitsInStock = UnitsInStock;
        }

        public short getUnitsInStock()
        {
            return this.unitsInStock;
        }

        private void isUnitsInStockValidAmount(int unitsInStock)
        {
            if(unitsInStock <= 0)
            {
                throw new ArgumentException("Units in stock must be more than 0");
            }
            if(unitsInStock > 1000)
            {
                throw new ArgumentException("Units amount must be less than 1000");
            }
        }
    }
}
