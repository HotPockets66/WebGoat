using System;

namespace WebGoat.NET.Models.Products
{
    public class SupplierID
    {
        private int supplierID;

        public SupplierID(int supplierID)
        {
            isSuplierIDValid(supplierID);
            this.supplierID = supplierID;
        }

        public int getSupplierID()
        {
            return supplierID;
        }

        private void isSuplierIDValid(int supplierID)
        {
            if(supplierID <= 0)
            {
                throw new ArgumentException("Supplier ID Cannot be less or equal to 0");
            }
        }
    }
}
