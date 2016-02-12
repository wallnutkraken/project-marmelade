using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class PlantController
    {
        static List<Plant> plants = new List<Plant>();
        public static void RegisterPlant(string name, string type, double lifetime, double procurementvalue, double scrapvalue, double yearsused)
        {
            Plant newPlant = new Plant(name, type, lifetime, procurementvalue, scrapvalue, yearsused);
            plants.Add(newPlant);
        }
    }
}
