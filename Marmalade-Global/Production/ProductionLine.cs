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
        public int WeekNo { get; set; }

        public ProductionLine(int amount, int week, Product product)
        {
            Amount = amount;
            WeekNo = week;
            Product = product;
        }
        public ProductionLine() : this(0, default(int), null)
        {
        }

    }
}
