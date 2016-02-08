using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class ProductionCycle
    {
        public List<ProductionTask> TasksRequired { get; set; } = new List<ProductionTask>();
        public int AmountOfProducts { get; set; }
        public Product ProductsProduced { get; set; }

        public ProductionCycle():this(0,null)
        {
        }
        public ProductionCycle(int amountOfProductsNeeded, Product product)
        {
            AmountOfProducts = amountOfProductsNeeded;
            ProductsProduced = product;
        }
    }
}
