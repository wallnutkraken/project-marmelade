using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marmalade_Global.Production;

namespace Marmalade_Global
{
    class ProductionCycle
    {

        public List<ProductionCycleLine> PCLsRequired { get; set; } = new List<ProductionCycleLine>();
        public int AmountOfProducts { get; set; }
        public Product ProductProduced { get; set; }

        public ProductionCycle(int amountOfProductsNeeded, Product product)
        {
            AmountOfProducts = amountOfProductsNeeded;
            ProductProduced = product;
        }
        public ProductionCycle() : this(0, null)
        {

        }


    }
}
