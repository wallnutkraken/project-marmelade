using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class Plant
    {
        private int ID { get; set; }
        private string Name { get; set; }
        private string Type { get; set; }
        private int Lifetime { get; set; }
        private double ProcurementValue { get; set; }
        private double BookValue { get; set; }
        private double ScrapValue { get; set; }
        private double AnualDepreciation { get; set; }


        public Plant()
        {

        }
    }
}
