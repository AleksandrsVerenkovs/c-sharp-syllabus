using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public Person()
        {
            FirstName = "John";
            LastName = "Doe";
            Address = "Baker St. 221b";
            Id = 0;
        }
        public Person(string firstName, string lastName, string address, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Id = id;
        }
        public virtual void Display() { }


    }
}
