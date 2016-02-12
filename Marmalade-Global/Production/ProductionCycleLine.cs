using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global.Production
{
    class ProductionCycleLine
    {
        public int NrOfiterations { get; set; }
        public MachineType MachineTypeRequired { get; set; }

        public List<ProductionTask> ProductionTasksRequired { get; set; } = new List<ProductionTask>();

        public ProductionCycleLine(int nrOfIterations, MachineType machineType)
        {
            NrOfiterations = nrOfIterations;
            MachineTypeRequired = machineType;
        }
        public ProductionCycleLine():this(0,default(MachineType))
        {
        }
        /// <summary>
        /// Part of schedule creating
        /// </summary>
        /// <param name="allMachines"></param>
        /// <returns></returns>
        public MachineEntry findMachine(List<MachineEntry> allMachines)
        {
            List<MachineEntry> specificMachines = allMachines.FindAll(machineX => machineX.Type == MachineTypeRequired);

            TimeSpan lowestTimespan = TimeSpan.MaxValue;
            MachineEntry machine = new MachineEntry();

            foreach (MachineEntry item in specificMachines)
            {
                List<ProductionTask> assignedTasks = item.MachineSchedule.AssignedTasks;
                TimeSpan totalAssignedTime = new TimeSpan(0, 0, 0);
                foreach (var smtgh in assignedTasks)
                {
                    totalAssignedTime += smtgh.Duration;
                }
                if (lowestTimespan >= totalAssignedTime)
                {
                    lowestTimespan = totalAssignedTime;
                    machine = item;
                }
            }
            return machine;
        }

        /// <summary>
        /// Part of Schedule creating
        /// </summary>
        /// <param name="allMachines"></param>
        public void Simulate(List<MachineEntry> allMachines)
        {
            MachineEntry machine = findMachine(allMachines);

            foreach (ProductionTask task in ProductionTasksRequired)
            {
                machine.MachineSchedule.AssignedTasks.Add(task);
            }
        }
    }
}
