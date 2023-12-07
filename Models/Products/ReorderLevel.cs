using System;

namespace WebGoat.NET.Moels.Products
{
    public class ReorderLevel
    {
        private short reorderLevel;

        public ReorderLevel(short reorderLevel)
        {
            isReorderLevelValid(reorderLevel);
            this.reorderLevel = reorderLevel;
        }

        public short getReorderLevel()
        {
            return reorderLevel;
        }

        private void isReorderLevelValid(short reorderLevel)
        {
            if (reorderLevel <= 0)
            {
                throw new ArgumentException("Reorder level cannot be less than 0");
            }
            if (reorderLevel > 50)
            {
                throw new ArgumentException("Reorder level cannot be more than 50");
            }
        }
    }
}
