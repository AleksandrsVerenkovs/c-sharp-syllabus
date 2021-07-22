using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter INT number.");
            var input = int.Parse(Console.ReadLine());

            for(int i = 1; i <= input;i++)
            {
                if (i % 15 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else
                {
                    Console.Write($"{i} ");
                }
                if (i % 20 == 0) Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
