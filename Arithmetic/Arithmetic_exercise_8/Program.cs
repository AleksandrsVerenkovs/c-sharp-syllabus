using System;
using System.Collections.Generic;

namespace Arithmetic_exercise_8
{
    public class Program
    {

        public class Employee
        {
            public string Name;
            public decimal BasePay;
            public int WorkedHours;

            public Employee(string name, decimal basePay, int workedHours)
            {
                Name = name;
                BasePay = basePay;
                WorkedHours = workedHours;
            }
        }
        static void Main(string[] args)
        {

            List<Employee> Employees = new List<Employee>();
            Employees.Add(new Employee("Employee 1", 7.5M, 35));
            Employees.Add(new Employee("Employee 2", 8.20M, 47));
            Employees.Add(new Employee("Employee 3", 10.00M, 73));

            foreach (var person in Employees)
            {
                Console.WriteLine($"{person.Name} salary: {Salary(person.WorkedHours, person.BasePay)}");
            }
            Console.ReadKey();
        }
        public static string Salary(int hours, decimal hourlyRate)
        {
            decimal overtimeHourlyRate = 1.5M * hourlyRate;
            decimal baseSalary = hours > 40 ? 40 * hourlyRate : hours * hourlyRate;
            decimal overtimePay = (hours - 40) * overtimeHourlyRate;
            decimal maxSalary = 720M;

            if (hourlyRate < 8) return $"No, no. Hourly rate {hourlyRate}h is too low!";
            if (hours > 60) return $"You salary is {maxSalary:F}$. Sorry, but not more than 60h work time.";
            if (hours > 40 && hours <= 60) return $"You salary is {(baseSalary + overtimePay):F}$.";
            return $"You salary is {baseSalary:F}$.";

        }

    }
}

