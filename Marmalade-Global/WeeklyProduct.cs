using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class WeeklyProduct
    {
        private Product Product { get; set; }
        private double TotalKgAmount { get; set; }

        public double CalculateTotalPriceForProduct()
        {
            // To be filled in
            return 0.0;
        }

        public WeeklyProduct(Product product, double totalKgAmount)
        {
            Product = product;
            TotalKgAmount = totalKgAmount;
        }

        public override string ToString()
        {
            return Product.ToString() + ";" + TotalKgAmount;
        }
    }
}
