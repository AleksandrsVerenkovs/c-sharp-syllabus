using System;

namespace Persons
{
    class Student:Person
    {
        public double Gpa { get; set; }
        public Student(int id,string firstName,string lastName,string address, double gpa): base(firstName,lastName,address,id)
        {
            Gpa = gpa;
        }
        public override void Display()
        {
            Console.WriteLine($"#{Id}: {FirstName} {LastName}\nGPA: {Gpa}\nAddress: {Address}");
        }
    }
}
