using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class Product
    {
        private int AmountOfIngredient { get; set; }
        private string ProductName { get; set; }
        private string Variety { get; set; }
        private double Size { get; set; }
        private string ContainerType { get; set; }
        private double FruitAmountPer100g { get; set; }
        private double ProductPrice { get; set; }
        private List<Ingredient> IngredientList = new List<Ingredient>();

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
    }
}
