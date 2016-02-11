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
        public double TotalSellingPrice { get; set; }

        public double CalculateTotalPriceForProduct()
        {
            return Product.ListPrice() * TotalKgAmount;
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
