using System;

namespace CheckOddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number;
            Console.WriteLine("Enter INTEGER nr.");
            Number = int.Parse(Console.ReadLine());
            Console.WriteLine(OddOrEven(Number));
            Console.WriteLine("\nbye!");
            return;
        }
        public static string OddOrEven(int number)
        {
            if(number == 0)
            {
                return "Odd Number";
            }
            return number % 2 == 0 ? "Even Number" : "Odd Number"; 
        }
    }
}
