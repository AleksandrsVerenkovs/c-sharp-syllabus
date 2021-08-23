using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * - Create an instant of class Student and an instant of class Employee with proper values for the attributes.
             * - Display the content of each class using Display() method.
             */
            var student = new Student(22,"Monty","English","Cherry St 44",6.7);
            var employee = new Employee("Sailor");

            student.Id = 33;
            student.FirstName = "Sherlock";
            student.Display();
            employee.Display();

            Console.ReadKey();
        }
    }
}