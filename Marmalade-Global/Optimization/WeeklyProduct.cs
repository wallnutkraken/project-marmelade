using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class WeeklyProduct
    {
        public Product Product { get; set; }
        public double TotalKgAmount { get; set; }
        public int WeekNumber { get; set; }

        public double CalculateTotalPriceForProduct()
        {
            // To be filled in
            return 0.0;
        }

        public WeeklyProduct(Product product, double totalKgAmount, int weekNumber)
        {
            Product = product;
            TotalKgAmount = totalKgAmount;
            WeekNumber = weekNumber;
        }

        public override string ToString()
        {
            return Product.ToString() + ";" + TotalKgAmount;
        }
    }
}
