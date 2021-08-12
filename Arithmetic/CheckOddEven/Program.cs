using System;

namespace CheckOddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter INTEGER nr.");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(IsEven.OddOrEven(number));
            Console.WriteLine("\nbye!");
            return;
        }
    }
    public class IsEven
    {
        public static string OddOrEven(int number)
        {
            if (number == 0)
            {
                return "Odd Number";
            }
            return Math.Abs(number) % 2 == 0 ? "Even Number" : "Odd Number";
        }
        public static string FullMessage(int number)
        {
            return $"{OddOrEven(number)}\nbye!";
        }
    }
}
