using System;

namespace WebGoat.NET.Models.Products
{
    public class UnitsOnOrder
    {
        private short unitsOnOrder;

        public UnitsOnOrder(short unitsOnOrder)
        {
            isUnitsOnOrderValid(unitsOnOrder);
            this.unitsOnOrder = unitsOnOrder;
        }

        private short getUnitsOnOrder()
        {
            return unitsOnOrder;
        }

        private void isUnitsOnOrderValid(short unitsOnOrder)
        {
            if(unitsOnOrder < 0)
            {
                throw new ArgumentException("Units on order cannot be less than 1");
            }
            if(unitsOnOrder >= 1000)
            {
                throw new ArgumentException("Units on order cannot be more than 1000");
            }
        }
    }
}
