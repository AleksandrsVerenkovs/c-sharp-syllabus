using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            int startKilometers = 0;
            int liters = 0;

            Console.WriteLine();

            Car car = new Car(0);
            Car car1 = new Car(0);

            for (int i = 0; i < 1; i++)
            {
                Console.Write("Enter first reading: ");
                startKilometers = int.Parse(Console.ReadLine());
                Console.Write("Enter liters reading: ");
                liters = int.Parse(Console.ReadLine());
                car.FillUp(startKilometers, liters);

                Console.Write("Enter first reading: ");
                startKilometers = int.Parse(Console.ReadLine());
                Console.Write("Enter liters reading: ");
                liters = int.Parse(Console.ReadLine());
                car1.FillUp(startKilometers, liters);
            }

            Console.WriteLine("Kilometers per liter are " + car.CalculateConsumption(startKilometers, liters) + " gasHog:" + car.GasHog());
            Console.WriteLine("Car1 Kilometers per liter are " + car1.CalculateConsumption(startKilometers, liters) + " economyCar:" + car.EconomyCar());
            Console.ReadKey();
        }
    }
}
