using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class Scheduler
    {
        private List<ProductionLine> allProductionLines;
        private List<ProductionCycle> allProductionCycles;
        private List<Machine> allMachines;

        public Scheduler()
        {

        }



        ProductionLine productionLine = new ProductionLine();
        ProductionCycle productionCycle = new ProductionCycle();
                //for (; i < length; i++)
                //{

                //}
            }


        }

        struct ProductionCycleAmount
        {
            public ProductionCycle productionCycleNeeded;
            public int amountOfProductionCyclesNeeded;

            public ProductionCycleAmount(ProductionCycle pc, int amount)
            {
                productionCycleNeeded = pc;
                amountOfProductionCyclesNeeded = amount;
            }
        }
        
    }
}
