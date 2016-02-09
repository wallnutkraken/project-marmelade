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
        private List<MachineSchedule> allMachineSchedules = new List<MachineSchedule>();

        public Scheduler()
        {
            // create a dummy product
            Product berryJam = new Product();
            // create a dummy productionLine for the product
            ProductionLine productionLine = new ProductionLine(11, 7, berryJam);
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
            MachineSchedule machine1Schedule = new MachineSchedule(machine1, CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(DateTime.Now,CalendarWeekRule.FirstDay,DayOfWeek.Monday));
            Machine machine2 = new Machine(MachineType.Filling);
            MachineSchedule machine2Schedule = new MachineSchedule(machine2, CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Monday));
            Machine machine3 = new Machine(MachineType.Tank);
            MachineSchedule machine3Schedule = new MachineSchedule(machine3, CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Monday));

            // collection of machine Schedules
            List<MachineSchedule> allMachineSchedules = new List<MachineSchedule>();
            allMachineSchedules.Add(machine1Schedule);
            allMachineSchedules.Add(machine2Schedule);
            allMachineSchedules.Add(machine3Schedule);
            allMachines.Add(machine1);
            allMachines.Add(machine2);
            allMachines.Add(machine3);
        }

        public MachineSchedule findMachineScheduleWithLowestAssignedTime()
        {
            TimeSpan lowestAssignedDuration = new TimeSpan(0,0,0);
            MachineSchedule result = new MachineSchedule();
            foreach (MachineSchedule  machineSchedule in allMachineSchedules)
            {
                TimeSpan assignedTime = machineSchedule.CalcTotalAssignedTime();
                if (assignedTime <= lowestAssignedDuration)
                {
                    result = machineSchedule;
                }
            }
            return result;
        } 

        public void Run()
        {
            // scheduling for the current Week // or a given week
            Calendar calendar = CultureInfo.InvariantCulture.Calendar;
            int weekNumber = calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Monday);

            // find all production lines for the week we are scheduling for
            List<ProductionLine> currentProductionLines = allProductionLines.FindAll(element => element.WeekNr == weekNumber);

            // calculate how many cycles we need to run in order to produce a productionLine and create a specific ProductionLineProductionCycle struct
            // then add it to the list of structs for this week
            int nrOfProductionCyclesNeeded = 0;
            List<PLPCStruct> PLPCStructs = new List<PLPCStruct>();
            foreach (ProductionLine productionLine in currentProductionLines)
            {
                ProductionCycle productionCycleRequired = allProductionCycles.Find(element => element.ProductsProduced.Equals(productionLine.Product));

                nrOfProductionCyclesNeeded = productionLine.Amount / productionCycleRequired.AmountOfProducts;

                if ((double)productionLine.Amount % (double)productionCycleRequired.AmountOfProducts > 0)
                {
                    nrOfProductionCyclesNeeded++;
                }

                PLPCStruct PLPCStruct = new PLPCStruct(productionCycleRequired, nrOfProductionCyclesNeeded);
                PLPCStructs.Add(PLPCStruct);
            }

            // on every PLPCstruct simulate production in manner of asigning the successive tasks to specific machineSchedules
            int i = 0;
            foreach (PLPCStruct PLPCLine in PLPCStructs)
            {
                i++;
                List<ProductionTask> successiveTasksForTank = PLPCLine.productionCycleNeeded.TasksRequired.FindAll(task => task.MachineTypeRequired == MachineType.Tank);
                List<ProductionTask> successiveTasksForFilling = PLPCLine.productionCycleNeeded.TasksRequired.FindAll(task => task.MachineTypeRequired == MachineType.Filling);

                List<MachineSchedule> tankMachinesSchedules = allMachineSchedules.FindAll(machineSchedule => machineSchedule.Machine.Type == MachineType.Tank);

                List<MachineSchedule> fillingMachinesSchedules = allMachineSchedules.FindAll(machineSchedule => machineSchedule.Machine.Type == MachineType.Filling);

                // finding a machine with a schedule with smallest duration
                // first calculate the duration of the before assigned tasks, then assign them, somewhere? Dont ask me where we'll find out later I guess.
                MachineSchedule leastBusyMachineSchedule = new MachineSchedule();
                TimeSpan assignedTime = default(TimeSpan);
                foreach (MachineSchedule item in tankMachinesSchedules)
                {
                    foreach (ProductionTask productionTask in item.AssignedTasks)
                    {
                        //assignedTime = assignedTime + productionTask.Duration;
                        //if (assignedTime < leastBusyMachineSchedule.AssignedTasks.)
                        //{

                        //}

                    }
                }

            }


        }

        struct PLPCStruct
        {
            public ProductionCycle productionCycleNeeded;
            public int amountOfProductionCyclesNeeded;

            public PLPCStruct(ProductionCycle pc, int amount)
            {
                productionCycleNeeded = pc;
                amountOfProductionCyclesNeeded = amount;
            }
        }

    }
}
