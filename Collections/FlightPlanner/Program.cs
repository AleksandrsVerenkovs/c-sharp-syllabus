using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "../../flights.txt";

        private static void Main(string[] args)
        {
            var cities = new Cities();
            var singleCities = cities.CityList();
            var cityDictionary = cities.CityDictionary();
            var running = true;

            var posInputs = new char[3] { '#', '1', '2' };

            var dic = cityDictionary.Select(city => $"{city.Key}: {string.Join(" ", city.Value)}");

            do
            {
                Console.WriteLine($"What would you like to do?\nList cities: 1\nSelect starting city: 2\nExit program: #\n");
                Console.Write("Enter option: ");

                var input = char.Parse(Console.ReadLine());

                if (!posInputs.Contains(input))
                {
                    Console.WriteLine("Please chose one of options.");
                }
                else
                {
                    switch (input)
                    {
                        case '#':
                            running = false;
                            break;
                        case '1':
                            ShowCities(singleCities);
                            Console.WriteLine();
                            break;
                        case '2':
                            RoundTrip(cityDictionary);
                            break;
                        default:
                            break;
                    }
                }
            }
            while (running);
            Console.ReadLine();
        }
        public static void RoundTrip(Dictionary<string, List<string>> cityDictionary)
        {
            Console.WriteLine("Enter starting city.");
            var startCity = Console.ReadLine();
            PossibleDest(startCity, cityDictionary);

            var trips = new List<string>() { startCity };

            do
            {
                Console.Write("Where to?: ");
                var dest = Console.ReadLine();
                if (!cityDictionary.ContainsKey(dest))
                {
                    Console.WriteLine("No such destination.");
                }else if (dest == startCity)
                {
                    Console.WriteLine($"Travel path: {string.Join("->",trips)}->{startCity}\n");
                    return;
                }
                else
                {
                    trips.Add(dest);
                    PossibleDest(dest,cityDictionary);
                }
            } while (true);

        }
        public static void ShowCities(HashSet<string> cityList)
        {
            Console.WriteLine(string.Join("\n", cityList));
        }
        public static void PossibleDest(string cityFrom, Dictionary<string,List<string>> cityDictionary)
        {
            Console.WriteLine("\nPosible destinations: ");
            foreach (KeyValuePair<string, List<string>> city in cityDictionary)
            {
                if (city.Key == cityFrom)
                {
                    Console.WriteLine(string.Join("\n", city.Value));
                }
            }
            Console.WriteLine();
        }
    }
}
