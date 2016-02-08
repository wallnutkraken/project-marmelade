using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class ProductionLine
    {
        //   Product Product;
        public int Amount { get; set; }
        public DateTime Week { get; set; }

        public ProductionLine(int amount, DateTime week)
        {
            Amount = amount;
            Week = week;
        }
        public ProductionLine():this(0,default(DateTime))
        {
        }

    }
}
