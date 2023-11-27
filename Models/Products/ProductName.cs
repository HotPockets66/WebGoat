using System;
using System.Text.RegularExpressions;

namespace WebGoat.NET.Models.Products
{
    public class ProductName
    {
        private string productName;

        public ProductName(string productName)
        {
            this.productName = productName;
        }

        public string GetProductName()
        {
            return productName;
        }

        private void IsProductNameCharactersAmountValid(string productName)
        {
            // Checks if the product character length is less than 0 characters and if so throw an exception
            if (productName.Length <= 0)
            {
                throw new ArgumentException("Product name cannot be less than 0 characters");
            }
            // Checks if the product character length is more than 40 characters and if so throw an exception
            if (productName.Length > 40)
            {
                throw new ArgumentException("Product name cannot be more than 30 characters");
            }
        }

        // Checks if the product name is equal to the regular expression
        private string IsProductNameValid(string productName)
        {
            Regex regex = new Regex("^[a-zA-ZÆØÅæøå]+$");

            if (regex.IsMatch(productName))
            {
                return productName;
            }
            else
            {
                throw new ArgumentException("Product name must contain A-Z, a-z and ÆØÅ");
            }
        }
    }
}
