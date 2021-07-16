using System;
using System.Collections.Generic;

namespace Arithmetic_exercise_8
{
    class Program
    {
        
        public class Employee
        {
            public string Name;
            public double BasePay;
            public int WorkedHours;

            public Employee(string name, double basePay, int workedHours)
            {
                Name = name;
                BasePay = basePay;
                WorkedHours = workedHours;
            }
        }
        static void Main(string[] args)
        {

            List<Employee> Employees = new List<Employee>();
            Employees.Add(new Employee("Employee 1", 7.50, 35));
            Employees.Add(new Employee("Employee 2", 8.20, 47));
            Employees.Add(new Employee("Employee 3", 10.00, 73));

            foreach(var person in Employees)
            {
                Console.WriteLine($"{person.Name} salary: {Salary(person.WorkedHours,person.BasePay)}");
            }
            Console.ReadKey();
        } 
        public static string Salary(int hours,double hourlyRate)
        {
            double overtimeHourlyRate = 1.5 * hourlyRate;
            double baseSalary = hours * hourlyRate;
            double overtimePay = (hours - 40) * overtimeHourlyRate;
            int maxSalary = 720;

            if (hourlyRate < 8) return $"No, no. Hourly rate {hourlyRate} is too low!";
            if (hours > 60) return $"You salary is {maxSalary}$. Sorry, but not more than 60h work time.";
            if (hours > 40 && hours <= 60) return $"You salary is {baseSalary + overtimePay}$.";
            return $"You salary is {baseSalary}$ .";

        }

    }
}

