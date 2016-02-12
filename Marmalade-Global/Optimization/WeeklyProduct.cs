using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class WeeklyProduct
    {
        /// <summary>
        /// Takes a product object from the Product.cs class.
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// User input on the total Kg amount of the product there is to be made.
        /// </summary>
        public double TotalKgAmount { get; set; }
        public int WeekNumber { get; set; }

        /// <summary>
        /// The total price selling this amount of products will be worth.
        /// </summary>
        public double TotalSellingPrice { get; set; }

        /// <summary>
        /// Calculation on the total buying price for this product, it uses a method from Product.cs
        /// to get the price needed on this product, and then times it with the TotalKgAmount.
        /// </summary>
        /// <returns></returns>
        public double CalculateTotalPriceForProduct()
        {
            return Product.ListPrice() * TotalKgAmount;
        }

        /// <summary>
        /// Calculation on the total selling price for this product, it uses a method from Product.cs
        /// to get the selling price needed on this product, and then times it with the TotalKgAmount.
        /// </summary>
        /// <returns></returns>
        public double CalculateTotalSellingPrice()
        {

            return TotalSellingPrice += Product.GetProductPrice() * TotalKgAmount;

        }

        /// <summary>
        /// Full-args constructor, taking 2 parameters, and get the TotalSellingPrice by using the
        /// calculation place within this class.
        /// </summary>
        /// <param name="product"></param>
        /// <param name="totalKgAmount"></param>
        public WeeklyProduct(Product product, double totalKgAmount)
        {
            Product = product;
            TotalKgAmount = totalKgAmount;
            TotalSellingPrice = CalculateTotalSellingPrice();
        }

        public override string ToString()
        {
            return Product.ToString() + ";" + TotalKgAmount + ";" + TotalSellingPrice.ToString();
        }
    }
}
