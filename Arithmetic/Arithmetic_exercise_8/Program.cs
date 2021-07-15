using System;

namespace Arithmetic_exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int workHours;

            Console.WriteLine("Enter work hours.");
            workHours = int.Parse(Console.ReadLine());
            Console.WriteLine(Salary(workHours));
            Console.ReadKey();
        } 
        public static string Salary(int hours)
        {
            int hourlyRate = 8;
            double overtimeHourlyRate = 1.5 * hourlyRate;
            int baseSalary = hours * hourlyRate;
            double overtimePay = (hours - 40) * overtimeHourlyRate;
            int maxSalary = 720;

            if (hours > 60) return $"You salary is {maxSalary}$.\nSorry, but not more than 60h work time.";
            if (hours > 40 && hours <= 60) return $"You salary is {baseSalary + overtimePay}$.";
            return $"You salary is {baseSalary}$ .";

        }

    }
}

