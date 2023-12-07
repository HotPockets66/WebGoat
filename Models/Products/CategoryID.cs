using System;

namespace WebGoat.NET.Models.Products
{
    public class CategoryID
    {
        private int categoryID;

        public CategoryID(int categoryID)
        {
            isCategoryIDValid(categoryID);
            this.categoryID = categoryID;
        }

        public int getCategoryID()
        {
            return categoryID;
        }

        private void isCategoryIDValid(int categoryID)
        {
            if (categoryID <= 0)
            {
                throw new ArgumentException("Category ID cannot be less or equal to 0.");
            }
        }
    }
}
