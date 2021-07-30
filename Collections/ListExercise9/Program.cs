﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            Console.WriteLine(string.Join(",", firstList));

            var secondList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };
            Console.WriteLine(string.Join(",", secondList));

            var completeList = firstList.Concat(secondList);
            Console.WriteLine(string.Join(",", completeList));
            Console.ReadLine();
        }
    }
}
