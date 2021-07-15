using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars;
            int seatsInACar;
            int drivers;
            int passengers;

            double carsNotDriven;
            double carsDriven;
            double carpoolCapacity;
            double averagePassengersPerCar;



            cars = 100; 
            seatsInACar = 4;
            drivers = 28;
            passengers = 90;
            carsNotDriven = cars - drivers;
            carsDriven =  drivers ;
            carpoolCapacity = cars * seatsInACar;
            averagePassengersPerCar = (carsDriven * seatsInACar) / passengers;

            Console.WriteLine($"There are {cars} cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + carsNotDriven + " empty cars today.");
            Console.WriteLine("We can transport " + carpoolCapacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + averagePassengersPerCar + " in each car.");
            Console.ReadKey();
        }
    }
}