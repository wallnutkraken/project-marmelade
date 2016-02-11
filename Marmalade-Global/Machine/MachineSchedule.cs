using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class MachineSchedule
    {
        public MachineEntry ScheduledMachine { get; set; }
        public List<ProductionTask> AssignedTasks { get; set; } = new List<ProductionTask>();

        public DateTime  WeekNr { get; set; }

        public MachineSchedule():this(null,default(DateTime))
        {
        }
        public MachineSchedule(MachineEntry machine,DateTime weekNr)
        {
            ScheduledMachine = machine;
            WeekNr = weekNr;
        }
    }
}
