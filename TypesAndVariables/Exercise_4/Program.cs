using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            int yearOfBirth;

            Console.WriteLine("What's your name?");
            name = Console.ReadLine();
            Console.WriteLine("Year of birth?");
            yearOfBirth = int.Parse(Console.ReadLine());

            Console.WriteLine("My name is {0} and I was born in {1}.",name,yearOfBirth);
            Console.ReadKey();
        }
    }
}
