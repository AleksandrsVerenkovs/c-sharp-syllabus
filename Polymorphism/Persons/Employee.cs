using System;

namespace Persons
{
    class Employee: Person
    {
        public string JobTitle { get; set; }
        public Employee(string jobTitle)
        {
            JobTitle = jobTitle;
        }
        public override void Display()
        {
            Person dd = new Person();
            Console.WriteLine($"#{base.Id}: {base.FirstName} {base.LastName}\nJob: {JobTitle}\nAddress: {base.Address}");
        }
    }
}
