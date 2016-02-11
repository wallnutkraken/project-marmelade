using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global.Production
{
    class ProductionCycleLine
    {
        public int AmountProduced { get; set; }
        public MachineType MachineTypeRequired { get; set; }

        public List<ProductionTask> ProductionTasksRequired { get; set; } = new List<ProductionTask>();
    }
}
