﻿using Marmalade_Global;
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
        /// <summary>
        /// List of all the 
        /// </summary>
        List<WeeklyProduct> allWPLs = new List<WeeklyProduct>();
        /// <summary>
        /// 
        /// </summary>
        ProductionCycle pc = new ProductionCycle();
        /// <summary>
        /// 
        /// </summary>
        List<Machine> allMachines = new List<Machine>();

        public Scheduler()
        {
        }


        public List<WeeklyProduct> FindWPLs(int weekNr)
        {
            List<WeeklyProduct> result = allWPLs.FindAll(WPL => WPL.WeekNr == weekNr);
            return result;
        }

        void test()
        {
            int weekNr = 0;

            List<WeeklyProduct> list = FindWPLs(weekNr);

            foreach (WeeklyProduct weeklyProduct in list)
            {
                int number = CalcNrOfIterationsForPC(pc, weeklyProduct);

                for (int i = 0; i < number; i++)
                {
                    pc.Simulate(allMachines);
                }
            }
        }

        public int CalcNrOfIterationsForPC(ProductionCycle productionCycle, WeeklyProduct weeklyProduct)
        {
            double amountOfProducts = weeklyProduct.TotalKgAmount / (weeklyProduct.Product.Size * 100);
            int amount = (int)amountOfProducts;
            double result = (double)amount / (double)productionCycle.AmountOfProducts;
            int resultInt = (int)Math.Ceiling(result);
            return resultInt;
        }


        //public void Run()
        //{
        //    // scheduling for the current Week // or a given week
        //    Calendar calendar = CultureInfo.InvariantCulture.Calendar;
        //    int weekNumber = calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Monday);

        //    // find all production lines for the week we are scheduling for
        //    List<ProductionLine> currentProductionLines = allProductionLines.FindAll(element => element.WeekNr == weekNumber);

        //    // calculate how many cycles we need to run in order to produce a productionLine and create a specific ProductionLineProductionCycle struct
        //    // then add it to the list of structs for this week
        //    int nrOfProductionCyclesNeeded = 0;
        //    List<PLPCStruct> PLPCStructs = new List<PLPCStruct>();
        //    foreach (ProductionLine productionLine in currentProductionLines)
        //    {
        //        ProductionCycle productionCycleRequired = allProductionCycles.Find(element => element.ProductProduced.Equals(productionLine.Product));

        //        nrOfProductionCyclesNeeded = productionLine.Amount / productionCycleRequired.AmountOfProducts;

        //        if ((double)productionLine.Amount % (double)productionCycleRequired.AmountOfProducts > 0)
        //        {
        //            nrOfProductionCyclesNeeded++;
        //        }

        //        PLPCStruct PLPCStruct = new PLPCStruct(productionCycleRequired, nrOfProductionCyclesNeeded);
        //        PLPCStructs.Add(PLPCStruct);
        //    }

        //    // on every PLPCstruct simulate production in manner of asigning the successive tasks to specific machineSchedules
        //    int i = 0;
        //    foreach (PLPCStruct PLPCLine in PLPCStructs)
        //    {
        //        i++;
        //        List<ProductionTask> successiveTasksForTank = PLPCLine.productionCycleNeeded.PCLRequired.FindAll(task => task.MachineTypeRequired == MachineType.Tank);
        //        List<ProductionTask> successiveTasksForFilling = PLPCLine.productionCycleNeeded.PCLRequired.FindAll(task => task.MachineTypeRequired == MachineType.Filling);

        //        List<MachineSchedule> tankMachinesSchedules = allMachineSchedules.FindAll(machineSchedule => machineSchedule.Machine.Type == MachineType.Tank);

        //        List<MachineSchedule> fillingMachinesSchedules = allMachineSchedules.FindAll(machineSchedule => machineSchedule.Machine.Type == MachineType.Filling);

        //        // finding a machine with a schedule with smallest duration
        //        // first calculate the duration of the before assigned tasks, then assign them, somewhere? Dont ask me where we'll find out later I guess.
        //        MachineSchedule leastBusyMachineSchedule = new MachineSchedule();
        //        TimeSpan assignedTime = default(TimeSpan);
        //        foreach (MachineSchedule item in tankMachinesSchedules)
        //        {
        //            foreach (ProductionTask productionTask in item.AssignedTasks)
        //            {
        //                //assignedTime = assignedTime + productionTask.Duration;
        //                //if (assignedTime < leastBusyMachineSchedule.AssignedTasks.)
        //                //{

        //                //}

        //            }
        //        }

        //    }


        //}

        //struct PLPCStruct
        //{
        //    public ProductionCycle productionCycleNeeded;
        //    public int amountOfProductionCyclesNeeded;

        //    public PLPCStruct(ProductionCycle pc, int amount)
        //    {
        //        productionCycleNeeded = pc;
        //        amountOfProductionCyclesNeeded = amount;
        //    }
        //}

        //ProductionLine productionLine = new ProductionLine();
        //ProductionCycle productionCycle = new ProductionCycle();
    }
}

