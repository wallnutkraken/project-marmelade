using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marmalade_Global.Production;

namespace Marmalade_Global
{
    class MachineSchedule
    {
        public Machine Machine { get; set; }
        public List<ProductionTask> AssignedTasks { get; set; } = new List<ProductionTask>();

        public int  WeekNr { get; set; }

        public MachineSchedule():this(null,0)
        {
        }
        public MachineSchedule(Machine machine,int weekNr)
        {
            Machine = machine;
            WeekNr = weekNr;
        }



    }
}
