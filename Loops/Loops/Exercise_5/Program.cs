using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word.");
            var firstWord = Console.ReadLine();
            Console.WriteLine("Enter second word.");
            var secondWord = Console.ReadLine();

            var numOfDots = 30 - firstWord.Length - secondWord.Length;

            Console.WriteLine($"{firstWord}{new string('.',numOfDots)}{secondWord}");
            Console.ReadKey();
        }
    }
}
