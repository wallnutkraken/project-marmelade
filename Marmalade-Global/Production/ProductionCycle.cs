using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class ProductionCycle
    {
        public List<ProductionCycleLine> PCLRequired { get; set; } = new List<ProductionCycleLine>();
        public int AmountOfProducts { get; set; }
        public Product ProductProduced { get; set; }
        public ProductionCycle(int amountOfProductsNeeded, Product product)
        {
            AmountOfProducts = amountOfProductsNeeded;
            ProductProduced = product;
        }
        public ProductionCycle():this(0,null)
        {
        }

    }
}
