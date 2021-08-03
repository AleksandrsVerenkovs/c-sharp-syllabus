using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        /**
           * Origination:
           * Audi -> Germany
           * BMW -> Germany
           * Honda -> Japan
           * Mercedes -> Germany
           * VolksWagen -> Germany
           * Tesla -> USA
           */

        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            var carList = array.ToList();
            foreach (var car in carList)
            {
                Console.WriteLine($"{car} -> {Country(car)}");
            }

            Console.WriteLine();

            var carHash = new HashSet<string>(array);
            foreach (var car in carHash)
            {
                Console.WriteLine($"{car} -> {Country(car)}");
            }

            Console.WriteLine();

            var carDictionary = carHash.ToDictionary(key => key, value => Country(value));
            foreach (var car in carDictionary)
            {
                Console.WriteLine($"{car.Key} -> {car.Value}");
            }

            Console.ReadLine();
        }
        public static string Country(string car)
        {
            var country = "";
            if (car == "Tesla")
            {
                country = "USA";
            }
            else if (car == "Honda")
            {
                country = "Japan";
            }
            else
            {
                country = "Germany";
            }
            return country;
        }
    }
}
