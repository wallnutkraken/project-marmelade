using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class Ingredient
    {
        private string Type { get; set; }
        private double Weight { get; set; }
        private double IngredientPrice { get; set; }

        public Ingredient(string type, double weight, double ingredientprice)
        {
            Type = type;
            Weight = weight;
            IngredientPrice = ingredientprice;
        }

        public override string ToString()
        {
            return Type + ";" + Weight + ";" + IngredientPrice;
        }
    }
}
