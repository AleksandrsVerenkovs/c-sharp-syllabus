using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance;
            int hours;
            int minutes;
            int seconds;

            Console.WriteLine("Enter distance (meters).");
            distance = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter hours");
            hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minutes.");
            minutes = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter seconds.");
            seconds = int.Parse(Console.ReadLine());

            double totalSeconds = hours * 3600 + minutes * 60 + seconds;
            double totalHours =  hours + minutes/60 + seconds/3600;
            double metersPerSecond = Math.Round(distance / totalSeconds,8);
            double distanceInKm = distance / 1000;
            double kilometersPerHour = distanceInKm / totalHours;
            double kilometersToMiles = distance / 1609;
            double milesPerHour = kilometersToMiles / totalHours;

            Console.WriteLine($"Your speed in meters/second is {metersPerSecond}\nYour speed in km/h is {kilometersPerHour}\nYour speed in miles/h is {milesPerHour}");

        }
    }
}
