using System;

namespace TenBillion
{
    class Program
    {
        //TODO Write a C# program that reads an positive integer and count the number of digits the number (less than ten billion) has.
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            var input = long.Parse(Console.ReadLine());
            var inputLength = input.ToString().ToCharArray().Length;

            if(input <= 0 ) Console.WriteLine("That's not possitive integer.");
            else Console.WriteLine($"This number consists of: {inputLength} digits.");
            Console.ReadKey();
        
        }
    }
}
