using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {       
        //TODO: Write a C# program to sum values of an array.
        private static void Main(string[] args)
        {
            List<int> myArr = new List<int>();
            var sum = 0;

            Console.WriteLine("Please enter a min number");
            int minNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            int maxNumber = int.Parse(Console.ReadLine());

           for( int i = minNumber; i<= maxNumber; i++)
            {
                sum += i;
            }

            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
            }
        }
}
