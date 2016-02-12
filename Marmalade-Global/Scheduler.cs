using Marmalade_Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Marmalade_Global.Production;

namespace Marmalade_Global
{
    class Scheduler
    {
        /// <summary>
        /// list of all of ours weekly products
        /// </summary>
        List<WeeklyProduct> allWPLs = new List<WeeklyProduct>();
        /// <summary>
        /// just a object of Production Cycle for testing purposes
        /// </summary>
        ProductionCycle pc = new ProductionCycle();
        /// <summary>
        /// List of all the machines that we have
        /// </summary>
        List<MachineEntry> allMachines = new List<MachineEntry>();

        /// <summary>
        /// JUST FOR TESTING
        /// fill up all the lists and create objects
        /// </summary>
        public void fillLists()
        {
            Product product = new Product();
            product.Size = 10;

            allWPLs.Add(new WeeklyProduct(product, 20));
            allWPLs.Add(new WeeklyProduct(product, 40));
            allWPLs.Add(new WeeklyProduct(product, 60));
            allWPLs.Add(new WeeklyProduct(product, 10));

            ProductionCycle x = new ProductionCycle();
            x.AmountOfProducts = 100;
            x.ProductProduced = product;

            pc = x;

            ProductionCycleLine pc1 = new ProductionCycleLine(2, MachineType.Tank);
            ProductionCycleLine pc2 = new ProductionCycleLine(1, MachineType.Filling);

            x.PCLsRequired.Add(pc1);
            x.PCLsRequired.Add(pc2);

            List<ProductionTask> productionTasksRequired1 = pc1.ProductionTasksRequired;
            List<ProductionTask> productionTasksRequired2 = pc2.ProductionTasksRequired;

            /// remove machineType from tasks one DAY!!!!
            ProductionTask task1 = new ProductionTask(new TimeSpan(1, 1, 1), MachineType.Tank);
            ProductionTask task2 = new ProductionTask(new TimeSpan(2, 1, 1), MachineType.Tank);
            ProductionTask task3 = new ProductionTask(new TimeSpan(0, 1, 1), MachineType.Tank);
            ProductionTask task4 = new ProductionTask(new TimeSpan(5, 1, 1), MachineType.Tank);
            ProductionTask task5 = new ProductionTask(new TimeSpan(6, 1, 1), MachineType.Tank);

            ProductionTask task01 = new ProductionTask(new TimeSpan(1, 1, 1), MachineType.Filling);
            ProductionTask task02 = new ProductionTask(new TimeSpan(1, 1, 1), MachineType.Filling);
            ProductionTask task03 = new ProductionTask(new TimeSpan(1, 1, 1), MachineType.Filling);
            ProductionTask task04 = new ProductionTask(new TimeSpan(1, 1, 1), MachineType.Filling);
            ProductionTask task05 = new ProductionTask(new TimeSpan(1, 1, 1), MachineType.Filling);


            productionTasksRequired1.Add(task1);
            productionTasksRequired1.Add(task2);
            productionTasksRequired1.Add(task3);
            productionTasksRequired1.Add(task4);
            productionTasksRequired1.Add(task5);
            productionTasksRequired2.Add(task01);
            productionTasksRequired2.Add(task02);
            productionTasksRequired2.Add(task03);
            productionTasksRequired2.Add(task04);
            productionTasksRequired2.Add(task05);

            MachineEntry tank1 = new MachineEntry(MachineType.Tank);
            MachineEntry tank2 = new MachineEntry(MachineType.Tank);
            MachineEntry tank3 = new MachineEntry(MachineType.Tank);
            MachineEntry tank4 = new MachineEntry(MachineType.Tank);
            MachineEntry tank5 = new MachineEntry(MachineType.Tank);
            MachineEntry tank6 = new MachineEntry(MachineType.Tank);

            MachineSchedule msc1 = new MachineSchedule(tank1, 1);
            MachineSchedule msc2 = new MachineSchedule(tank2, 1);
            MachineSchedule msc3 = new MachineSchedule(tank3, 1);
            MachineSchedule msc4 = new MachineSchedule(tank4, 1);
            MachineSchedule msc5 = new MachineSchedule(tank5, 1);
            MachineSchedule msc6 = new MachineSchedule(tank6, 1);

            MachineEntry filling1 = new MachineEntry(MachineType.Filling);
            MachineEntry filling2 = new MachineEntry(MachineType.Filling);
            MachineEntry filling3 = new MachineEntry(MachineType.Filling);
            MachineEntry filling4 = new MachineEntry(MachineType.Filling);

            MachineSchedule msc01 = new MachineSchedule(filling1, 1);
            MachineSchedule msc02 = new MachineSchedule(filling2, 1);
            MachineSchedule msc03 = new MachineSchedule(filling3, 1);
            MachineSchedule msc04 = new MachineSchedule(filling4, 1);

            msc01.AssignedTasks.Add(task01);
            msc01.AssignedTasks.Add(task02);

            msc1.AssignedTasks.Add(task1);
            msc1.AssignedTasks.Add(task3);

            allMachines.Add(tank1);
            allMachines.Add(tank2);
            allMachines.Add(tank3);
            allMachines.Add(tank4);
            allMachines.Add(tank5);
            allMachines.Add(tank6);
            allMachines.Add(filling1);
            allMachines.Add(filling2);
            allMachines.Add(filling3);
            allMachines.Add(filling4);



        }

        public Scheduler()
        {
        }

        /// <summary>
        /// Find all the products that need to be done in specific week
        /// </summary>
        /// <param name="weekNr"></param>
        /// <returns></returns>
        public List<WeeklyProduct> FindWPLs(int weekNr)
        {
            List<WeeklyProduct> result = allWPLs.FindAll(WPL => WPL.WeekNumber == weekNr);
            return result;
        }

        /// <summary>
        /// This method creates schedule for all the machines 
        /// </summary>
        /// <param name="weekNumber"></param>
        public void CreateScheduleForAllMachines(int weekNumber)
        {
            List<WeeklyProduct> list = FindWPLs(weekNumber);

            foreach (WeeklyProduct weeklyProduct in list)
            {
                int number = CalcNrOfIterationsForPC(pc, weeklyProduct);

                for (int i = 0; i < number; i++)
                {
                    pc.Simulate(allMachines);
                }
            }
        }
        /// <summary>
        /// Calculates number of iterations for our 'main' loop in CreateScheduleForAllMachines method
        /// </summary>
        /// <param name="productionCycle"></param>
        /// <param name="weeklyProduct"></param>
        /// <returns></returns>
        public int CalcNrOfIterationsForPC(ProductionCycle productionCycle, WeeklyProduct weeklyProduct)
        {
            double amountOfProducts = weeklyProduct.TotalKgAmount / (weeklyProduct.Product.Size * 100);
            double amount = amountOfProducts;
            double result = amount / productionCycle.AmountOfProducts;
            int resultInt = (int)Math.Ceiling(result);
            return resultInt;
        }

    }
}

