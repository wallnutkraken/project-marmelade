using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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
            ProductionLine productionLine = new ProductionLine(10, 7, berryJam);
            allProductionLines.Add(productionLine);

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
            allProductionCycles.Add(productionCycle);

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

        public void Run()
        {
            // scheduling for the current Week
            Calendar calendar = CultureInfo.InvariantCulture.Calendar;
            int weekNumber = calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Monday);

            // find all production lines for the week we are scheduling for
            List<ProductionLine> currentProductionLines = allProductionLines.FindAll(element => element.WeekNr == weekNumber);

            // calculate how many cycles we need to run in order to produce all productionLines
            int nrOfProductionCyclesNeeded = 0;
            List<ProductionCycleAmount> allStructs = new List<ProductionCycleAmount>();
            foreach (ProductionLine item in currentProductionLines)
            {
                ProductionCycle productionCycleRequired = allProductionCycles.Find(element => element.ProductsProduced.Equals(item.Product));

                nrOfProductionCyclesNeeded = item.Amount / productionCycleRequired.AmountOfProducts;

                ProductionCycleAmount AmountOfPCToRun = new ProductionCycleAmount(productionCycleRequired, nrOfProductionCyclesNeeded);
                allStructs.Add(AmountOfPCToRun);
            }

            foreach (ProductionCycleAmount item in allStructs)
            {
                int nrOftasksToIterateFor = item.productionCycleNeeded.TasksRequired.Count;

                for (; i < length; i++)
                {

                }
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
