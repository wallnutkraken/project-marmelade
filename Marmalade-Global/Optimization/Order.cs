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
        public double TotalAmountOfIngredients { get; set; }
        public double TotalIngredientsPrice { get; set; }
        public double TotalSellingPrice { get; set; }
        public double ExpectedProfit { get; set; }
        List<Ingredient> TotalIngredientlist = new List<Ingredient>();

        public double CalculateTotalIngredientPrice()
        {
            // Calculate the price for all ingredients bought
            return 0.0;
        }

        public double CalcualteExpectedProfit()
        {
            // Calculate the expected profit, based on total
            // total ingredient prices and expected selling price.
            return 0.0;
        }
        public string BestSalesOption()
        {
            // Logic to figure out the best sales option
            return "";
        }

        public Order(int orderID, double weeklyBudget, double totalAmountOfIngredients,
            double totalIngredientsPrice, double totalSellingPrice, double expectedProfit)
        {
            OrderID = orderID; //Replace with list.count from controller
            WeeklyBudget = weeklyBudget;
            TotalAmountOfIngredients = totalAmountOfIngredients;
            TotalIngredientsPrice = totalIngredientsPrice;
            TotalSellingPrice = totalSellingPrice;
            ExpectedProfit = expectedProfit;
        }

        public override string ToString()
        {
            return OrderID + ";" + WeeklyBudget + ";" + TotalAmountOfIngredients + ";" +
                TotalIngredientsPrice + ";" + TotalSellingPrice + ";" + ExpectedProfit;
        }
    }
}
