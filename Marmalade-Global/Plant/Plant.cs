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
        private double Lifetime { get; set; }
        private double ProcurementValue { get; set; }
        private double BookValue { get; set; }
        private double ScrapValue { get; set; }
        private double AnualDepreciation { get; set; }
        private double YearsUsed { get; set; }


        public Plant() { }

        public Plant(string name, string type, double lifetime, double procurementvalue, double scrapvalue, double yearsused)
        {
            Name = name;
            Type = type;
            Lifetime = lifetime;
            ProcurementValue = procurementvalue;
            YearsUsed = yearsused;
            ScrapValue = scrapvalue;
            AnualDepreciation = CalculateAnualDepreciation(Lifetime, ProcurementValue, ScrapValue);
            BookValue = CalculateBookValue(ProcurementValue, AnualDepreciation, Lifetime, YearsUsed);
        }

        public double CalculateAnualDepreciation(double lifetime, double procval, double scrapval)
        {
            double result = 0.0;
            return Math.Round(result = 1 / lifetime * (procval - scrapval), 2);
        }
        public double CalculateBookValue(double procval, double anualdepr, double lifetime, double yearsused)
        {
            double result = 0.0;
            return Math.Round(result = procval * anualdepr * (lifetime - yearsused), 2);
        }
    }
}
