using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class MachineSchedule
    {
        public List<ProductionTask> AssignedTasks { get; set; } = new List<ProductionTask>();
        public int  WeekNr { get; set; }

        public MachineSchedule():this(0)
        {
        }
        public MachineSchedule(int weekNr)
        {
            WeekNr = weekNr;
        }

        public TimeSpan CalcTotalAssignedTime()
        {
            TimeSpan totalAssignedTime = new TimeSpan();

            foreach (ProductionTask task in AssignedTasks)
            {
                totalAssignedTime = totalAssignedTime + task.Duration;
            }

            return totalAssignedTime;
        }

    }
}
