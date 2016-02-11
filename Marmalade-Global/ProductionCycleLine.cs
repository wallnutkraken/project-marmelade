using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Marmalade_Global
{
    public class ProductionCycleLine
    {
        public int AmountProduced { get; set; }
        public MachineType MachineTypeRequired { get; set; }
        public List<ProductionTask> ProductionTasksRequired { get; set; } = new List<ProductionTask>();

    }
}