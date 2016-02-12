using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class Product
    {
        /// <summary>
        /// The amount of different ingredients needed in this product.
        /// </summary>
        public int AmountOfIngredient { get; set; }

        /// <summary>
        /// The name of the product.
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// The Variety of the product (the quality).
        /// </summary>
        public string Variety { get; set; }

        /// <summary>
        /// The Size of this product (weight in g).
        /// </summary>
        public double Size { get; set; }

        /// <summary>
        /// The container the product will be in.
        /// </summary>
        public string ContainerType { get; set; }

        /// <summary>
        /// The selling price on this product.
        /// </summary>
        public double ProductPrice { get; set; }

        /// <summary>
        /// A list of ingredients used in this product
        /// </summary>
        public List<Ingredient> IngredientList = new List<Ingredient>();

        /// <summary>
        /// Calculates the price for the ingredients used in the product.
        /// </summary>
        /// <returns></returns>
        public double ListPrice()
        {
            string HoldingOneOfTheListPrices = "";
            double totalPriceForIngredients = 0;

            for (int i = 0; i < IngredientList.Count(); i++)
            {
                HoldingOneOfTheListPrices = IngredientList[i].ToString();

                string[] numbers = HoldingOneOfTheListPrices.Split(';');
                double gatheredNumbers = double.Parse(numbers[1]);

                totalPriceForIngredients = (totalPriceForIngredients + gatheredNumbers);
            }

            return totalPriceForIngredients;
        }

        /// <summary>
        /// Full-args constructor, that adds the ingredients given to the ingredient list.
        /// </summary>
        /// <param name="amountOfIngredient"></param>
        /// <param name="productName"></param>
        /// <param name="variety"></param>
        /// <param name="size"></param>
        /// <param name="containerType"></param>
        /// <param name="fruitAmountPer100g"></param>
        /// <param name="productPrice"></param>
        /// <param name="IngredientOne"></param>
        /// <param name="IngredientTwo"></param>
        public Product(int amountOfIngredient, string productName,
            string variety, double size, string containerType,
            double fruitAmountPer100g, double productPrice,
            Ingredient IngredientOne, Ingredient IngredientTwo)
        {
            AmountOfIngredient = amountOfIngredient;
            ProductName = productName;
            Variety = variety;
            Size = size;
            ContainerType = containerType;
            ProductPrice = productPrice;

            for (int i = 0; i < amountOfIngredient; i++)
            {
                IngredientList.Add(IngredientOne);
                IngredientList.Add(IngredientTwo);
            }
        }
        public Product() : this(0,"","",0.0,"",0.0,0.0,null,null)
        {
        }

        public override string ToString()
        {
            string HoldingOneOfTheListElements = "";
            string TypesContainedInList = "";
            for (int i = 0; i < IngredientList.Count(); i++)
            {
                HoldingOneOfTheListElements = IngredientList[i].ToString();

                string[] words = HoldingOneOfTheListElements.Split(';');

                TypesContainedInList = (TypesContainedInList + words[0] + ";");
            }
            return AmountOfIngredient + ";" + ProductName + ";" + Variety + ";" +
                Size + ";" + ContainerType + ";" +
                ProductPrice + ";" + TypesContainedInList;
        }

        /// <summary>
        /// Simply returns the ProductPrice (Laziness).
        /// </summary>
        /// <returns></returns>
        public double GetProductPrice()
        {
            return ProductPrice;
        }
    }
}
