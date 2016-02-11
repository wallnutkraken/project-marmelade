using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class ProductionCycle
    {
        /// <summary>
        /// All tasks for the relevant week
        /// </summary>
        public List<ProductionTask> AllWeeklyTasks { get; set; } = new List<ProductionTask>();
        /// <summary>
        /// Amount of products made after one cycle
        /// </summary>
        public int AmountOfProducts { get; set; }
        /// <summary>
        /// The type of product produced
        /// </summary>
        public Product ProductsProduced { get; set; }

        public ProductionCycle():this(0,null)
        {
        }
        /// <param name="product">Type of product to be created</param>
        public ProductionCycle(int amountOfProductsNeeded, Product product)
        {
        }
    }
}
