using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{
    class Program
    {
        private const int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {
            var s = new Program();

            Console.WriteLine("Total number of people surveyed " + NumberedSurveyed);
            Console.WriteLine($"Approximately {s.CalculateEnergyDrinkers(NumberedSurveyed)} bought at least one energy drink");
            Console.WriteLine($"{s.CalculatePreferCitrus(NumberedSurveyed)} of those prefer citrus flavored energy drinks.");
            Console.ReadLine();

        }

        public double CalculateEnergyDrinkers(int numberSurveyed)
        {
            return Math.Floor(numberSurveyed * PurchasedEnergyDrinks);
            //throw new Exception("Sorry, no code written :(");
        }

        public double CalculatePreferCitrus(int numberSurveyed)
        {
            return Math.Floor((numberSurveyed * PurchasedEnergyDrinks) * PreferCitrusDrinks);
            //throw new Exception("Sorry, no code written :(");
        }
    }
}
