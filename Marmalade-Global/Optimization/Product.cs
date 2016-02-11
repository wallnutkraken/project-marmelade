using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class Product
    {
        public int AmountOfIngredient { get; set; }
        public string ProductName { get; set; }
        public string Variety { get; set; }
        public double Size { get; set; }
        public string ContainerType { get; set; }
        public double FruitAmountPer100g { get; set; }
        public double ProductPrice { get; set; }
        public List<Ingredient> IngredientList = new List<Ingredient>();

        public double ListPrice() //Takes the price for all ingredients and puts them together.
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
            FruitAmountPer100g = fruitAmountPer100g;
            ProductPrice = productPrice;

            for (int i = 0; i < amountOfIngredient; i++)
            {
                IngredientList.Add(IngredientOne);
                IngredientList.Add(IngredientTwo);
            }
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
                Size + ";" + ContainerType + ";" + FruitAmountPer100g + ";" +
                ProductPrice + ";" + TypesContainedInList;
        }

        public double GetProductPrice()
        {
            return ProductPrice;
        }
    }
}
