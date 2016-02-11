using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class ProductionLine
    {
        public Product Product { get; set; }
        public int Amount { get; set; }
        public int WeekNr { get; set; }

        public ProductionLine(int amount, int weekNr, Product product)
        {
            Amount = amount;
            WeekNr = weekNr;
            Product = product;
        }
        public ProductionLine() : this(0, 0, null)
        {
        }
    }
}
