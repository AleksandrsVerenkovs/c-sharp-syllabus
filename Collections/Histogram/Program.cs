using System;
using System.Collections.Generic;
using System.IO;

namespace Histogram
{
    class Program
    {
        private const string Path = "../../midtermscores.txt";

        private static void Main(string[] args)
        {
            var dicList = new Dictionary<int, string>() {
            { 0,"" },
            { 1,""},
            { 2,"" },
            { 3,""},
            { 4,"" },
            { 5,""},
            { 6,"" },
            { 7,"" },
            { 8,""},
            { 9,"" },
            { 10,"" },
            };
            var readText = File.ReadAllLines(Path);

            var arr = new List<int>();
            foreach (var s in readText)
            {
                var i = s.Split();
                foreach (var num in i)
                {
                    arr.Add(int.Parse(num));
                }
            }

            foreach (var item in arr)
            {
                dicList[AddToSegment(item)] += "*";
            }

            Console.WriteLine($"00-09: {dicList[0]}\n10-19: {dicList[1]}\n20-29: {dicList[2]}\n30-39: {dicList[3]}\n40-49: {dicList[4]}\n50-59: {dicList[5]}\n60-69: {dicList[6]}\n70-79: {dicList[7]}\n80-89: {dicList[8]}\n90-99: {dicList[9]}\n  100: {dicList[10]}");
            Console.ReadLine();
        }
        public static int AddToSegment(int value)
        {
            var segment = 0;
            for (var i = 1; i <= 10; i++)
            {
                var start = int.Parse(i + "0");
                if (value < 9)
                {
                    segment = 0;
                    break;
                }
                else if (value < start)
                {
                    segment = i - 1;
                    break;
                }
                else
                {
                    segment = 10;
                }
            }
            return segment;
        }
    }
}
