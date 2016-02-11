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
<<<<<<< HEAD
        public int WeekNr { get; set; }

        public ProductionLine(int amount, int weekNr, Product product)
        {
            Amount = amount;
            WeekNr = weekNr;
            Product = product;
        }
        public ProductionLine() : this(0, 0, null)
=======
        public int WeekNo { get; set; }

        public ProductionLine(int amount, int week, Product product)
        {
            Amount = amount;
            WeekNo = week;
            Product = product;
        }
        public ProductionLine() : this(0, default(int), null)
>>>>>>> 3ef72cd8a7e59e88ee3d872909b18a98567d39ab
        {
        }

    }
}
