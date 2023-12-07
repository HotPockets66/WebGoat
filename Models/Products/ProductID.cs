using System;

namespace WebGoat.NET.Models.Products
{
    public class ProductID
    {
        private int productID;

        public ProductID(int productID)
        {
            isProductIDValid(productID);
            this.productID = productID;
        }

        public int getProductID()
        {
            return productID;
        }

        private void isProductIDValid(int productID)
        {
            if(productID <= 0)
            {
                throw new ArgumentException("Product ID cannot be less or equal to 0.");
            }
        }
    }
}
