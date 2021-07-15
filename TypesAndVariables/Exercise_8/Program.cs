using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double minutes;
            Console.WriteLine("Enter minutes.");
            minutes = int.Parse(Console.ReadLine());
            double years = Math.Round(minutes / 525600,0);
            double remainingMin = minutes % 525600;
            double days = Math.Round(remainingMin / 1440,0);
            
            Console.WriteLine($"Year/s: {years} \nDays: {days}");
        }
    }
}
