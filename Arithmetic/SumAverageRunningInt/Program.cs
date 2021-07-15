using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowerBound = 1;
            int upperBound = 100;
            var sum = SumOfAll(lowerBound, upperBound);
            var average = Average(sum, upperBound);

            Console.WriteLine($"The sum of {lowerBound} to {upperBound} is {sum}\nThe average is {average}");

        }
        static int SumOfAll(int lowerNr, int upperNr)
        {
            int sum = 0;
            for (var number = lowerNr; number <= upperNr; ++number)
            {
                sum += number;
            }
            return sum;
        }
        static double Average(int sum, int upperNr)
        {
            return (double)sum / (double)upperNr;
        }
    }
}