namespace WebGoat.NET.Models.Products
{
    public class Discontinued
    {
        private bool discontinued;

        public Discontinued(bool discontinued)
        {
            this.discontinued = discontinued;
        }

        public bool getDiscontinued()
        {
            return discontinued;
        }
    }
}
