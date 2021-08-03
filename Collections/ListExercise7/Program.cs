using System;
using System.Collections.Generic;

namespace ListExercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            var cont = "White";
            var result = colors.Contains(cont) ? "Found element" : "There is no such element";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
