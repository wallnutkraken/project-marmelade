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
        public DateTime Week { get; set; }

        public ProductionLine(int amount, DateTime week, Product product)
        {
            Amount = amount;
            Week = week;
            Product = product;
        }
        public ProductionLine() : this(0, default(DateTime), null)
        {
        }

    }
}
