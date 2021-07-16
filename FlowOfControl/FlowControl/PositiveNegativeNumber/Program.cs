using System;

namespace PositiveNegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number.");

            var input = int.TryParse(Console.ReadLine(), out int num);

            if (!input)
            {
                Console.WriteLine("Heeey, that's not a number!");
            }
            else
                {
                if (num>= 1) Console.WriteLine("Number is positive");
                else if (num <= -1) Console.WriteLine("Number is negative");
                else Console.WriteLine("Number is zero");
                }
            Console.ReadKey();
        }
    }
}
