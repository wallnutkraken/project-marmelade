using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class Scheduler
    {
        private List<ProductionLine> allProductionLines = new List<ProductionLine>();
        private List<ProductionCycle> allProductionCycles = new List<ProductionCycle>();
        private List<Machine> allMachines = new List<Machine>();

        public Scheduler()
        {
            // create a dummy product
            Product berryJam = new Product();
            // create a dummy productionLine for the product
            ProductionLine productionLine = new ProductionLine(10, DateTime.Now, berryJam);

            // create some ProductionTasks
            TimeSpan duration = new TimeSpan(1, 0, 0);
            ProductionTask tankProduction = new ProductionTask(duration, MachineType.Tank);
            ProductionTask tankProduction1 = new ProductionTask(duration, MachineType.Tank);
            ProductionTask tankProduction3 = new ProductionTask(duration, MachineType.Tank);
            ProductionTask tankProduction2 = new ProductionTask(duration, MachineType.Tank);
            ProductionTask fillingProduction = new ProductionTask(duration, MachineType.Filling);

            // create a productionCycle and assign productionTasks to one productionCycle
            ProductionCycle productionCycle = new ProductionCycle(5, berryJam);
            productionCycle.TasksRequired.Add(tankProduction);
            productionCycle.TasksRequired.Add(tankProduction1);
            productionCycle.TasksRequired.Add(tankProduction2);
            productionCycle.TasksRequired.Add(tankProduction3);
            productionCycle.TasksRequired.Add(fillingProduction);

            // create some machines and machine schedules for created machines
            Machine machine1 = new Machine(MachineType.Tank);
            MachineSchedule machine1Schedule = new MachineSchedule(machine1, DateTime.Now);
            Machine machine2 = new Machine(MachineType.Filling);
            MachineSchedule machine2Schedule = new MachineSchedule(machine2, DateTime.Now);
            Machine machine3 = new Machine(MachineType.Tank);
            MachineSchedule machine3Schedule = new MachineSchedule(machine3, DateTime.Now);

            // collection of machine Schedules
            List<MachineSchedule> allMachineSchedules = new List<MachineSchedule>();
            allMachineSchedules.Add(machine1Schedule);
            allMachineSchedules.Add(machine2Schedule);
            allMachineSchedules.Add(machine3Schedule);
            allMachines.Add(machine1);
            allMachines.Add(machine2);
            allMachines.Add(machine3);


        }

        
        int howManyCyclesWeNeedToRun()
        {

            int thisManyCyclesWeNEedToRun = this.productionLine.Amount / productionCycle.AmountOfProducts;

            return thisManyCyclesWeNEedToRun;
        }
        
    }
}
