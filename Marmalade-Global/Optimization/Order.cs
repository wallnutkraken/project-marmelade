using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class Order
    {
        /// <summary>
        /// The ID given to an order, the id is given by using a list in G3Controller +1.
        /// </summary>
        public int OrderID { get; set; }

        /// <summary>
        /// The weekly input used for calculations, a parameter given by the user through GUI.
        /// </summary>
        public double WeeklyBudget { get; set; }

        /// <summary>
        /// The amount of different products that will be made in this order (one week of work).
        /// </summary>
        public double TotalAmountOfProducts { get; set; }

        /// <summary>
        /// The total price for creating all the products (the total price for ingredients).
        /// </summary>
        public double TotalProductPrice { get; set; }

        /// <summary>
        /// The total selling price for selling all the products made during this order.
        /// </summary>
        public double TotalSellingPrice { get; set; }

        /// <summary>
        /// The difference between the selling price and buying price.
        /// </summary>
        public double ExpectedProfit { get; set; }

        /// <summary>
        /// Calculates the buying price for creating the products, by using a method placed in weeklyproduct.cs.
        /// This method gets the price for the ingredients from product.cs and times it with the weight
        /// given in the WeeklyProduct.cs.
        /// </summary>
        /// <returns></returns>
        public double CalculateTotalProductPrice() 
        {
            foreach (var weeklyProduct in G3Controller.WeeklyProductlist)
            {
                TotalProductPrice += weeklyProduct.CalculateTotalPriceForProduct();
            }
            return TotalProductPrice;
        }

        /// <summary>
        /// Calculates the selling price for selling all the products, by using a method placed in weeklyproduct.cs.
        /// This method gets selling price for the products times with their weight given in the weeklyproduct.cs.
        /// </summary>
        /// <returns></returns>
        public double CalculateTotalSellingPrice()
        {
            foreach (var WeeklyProduct in G3Controller.WeeklyProductlist)
            {
                TotalSellingPrice += WeeklyProduct.CalculateTotalSellingPrice();
            }
            return TotalSellingPrice;
        }

        /// <summary>
        /// A simple calculation that gives the difference between selling and buying price
        /// </summary>
        /// <returns></returns>
        public double CalcualteExpectedProfit()
        {
            return TotalSellingPrice - TotalProductPrice;
        }

        /// <summary>
        /// Not yet implemented
        /// </summary>
        /// <returns></returns>
        public string BestSalesOption()
        {
            // Logic to figure out the best sales option
            return "";
        }

        /// <summary>
        /// Constructor that takes 1 parameter, and fills in the rest of information using
        /// the calculations within the class, and get the ID from the List<Order> within the
        /// G3Controller. (+1 to the list for new ID)
        /// </summary>
        /// <param name="weeklyBudget"></param>
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
