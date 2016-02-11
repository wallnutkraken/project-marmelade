using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class Order
    {
        public int OrderID { get; set; }
        public double WeeklyBudget { get; set; }
        public double TotalAmountOfProducts { get; set; }
        public double TotalProductPrice { get; set; }
        public double TotalSellingPrice { get; set; }
        public double ExpectedProfit { get; set; }

        public double CalculateTotalProductPrice() // Calculate the price for all ingredients bought
        {
            foreach (var weeklyProduct in G3Controller.WeeklyProductlist)
            {
                TotalProductPrice += weeklyProduct.CalculateTotalPriceForProduct();
            }
            return TotalProductPrice;
        }

        public double CalculateTotalSellingPrice() // Calculate the price for all ingredients bought
        {
            foreach (var Product in G3Controller.ProductList)
            {
                TotalSellingPrice += Product.GetProductPrice();
            }
            return TotalSellingPrice;
        }

        public double CalcualteExpectedProfit()
        {
            return TotalSellingPrice - TotalProductPrice;
        }

        public string BestSalesOption()
        {
            // Logic to figure out the best sales option
            return "";
        }

        public Order(double weeklyBudget)
        {
            OrderID = G3Controller.OrdersList.Count() + 1;
            WeeklyBudget = weeklyBudget;
            TotalAmountOfProducts = G3Controller.ProductList.Count();
            TotalProductPrice = CalculateTotalProductPrice();
            TotalSellingPrice = CalculateTotalSellingPrice();
            ExpectedProfit = CalcualteExpectedProfit();
        }

        public override string ToString()
        {
            return OrderID + ";" + WeeklyBudget + ";" + TotalAmountOfProducts + ";" +
                TotalProductPrice + ";" + TotalSellingPrice + ";" + ExpectedProfit;
        }
    }
}
