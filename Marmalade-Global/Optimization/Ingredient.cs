using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class Ingredient
    {
        /// <summary>
        /// The type of Ingredient (name)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// How much weight they can get of this Type
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// The price for ingredients pr. kg.
        /// </summary>
        public double IngredientPrice { get; set; }

        /// <summary>
        /// full args constructor, nothing special here.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="weight"></param>
        /// <param name="ingredientprice"></param>
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
