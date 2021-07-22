using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        //TODO: Write a C# program to test if an array contains a specific value.
        private static void Main(string[] args)
        {
            var myArray = new List<int>
            {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2265, 1457, 2456
            };

            Console.WriteLine("Write number to check: ");
            var num = int.Parse(Console.ReadLine());

            var isInArray = myArray.Contains(num);

            if(isInArray)
            {
                Console.WriteLine($"{num} is in array.");
            }
            else
            {
                Console.WriteLine($"{num} is NOT in array.");
            }
            Console.ReadKey();
        }
    }
}
