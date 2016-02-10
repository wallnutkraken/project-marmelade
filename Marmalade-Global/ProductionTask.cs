using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class ProductionTask
    {
        public TimeSpan Duration { get; set; }
        public MachineType MachineTypeRequired { get; set; }

        public ProductionTask(TimeSpan duration, MachineType machineTypeRequired)
        {
            Duration = duration;
            MachineTypeRequired = machineTypeRequired;
        }
        public ProductionTask():this(default(TimeSpan), (MachineType)0)
        {

        }
    }
}
