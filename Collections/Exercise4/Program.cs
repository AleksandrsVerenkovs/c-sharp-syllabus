using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number.");
            var input = int.Parse(Console.ReadLine());

            var value = input;
            do
            {
                var arr = value.ToString().ToCharArray();
                var sum = 0;
                foreach (var i in arr)
                {
                    sum += (int)Math.Pow(int.Parse(i.ToString()), 2);
                }
                value = sum;

                if (value == 4)
                {
                    Console.WriteLine("not happy");
                    break;
                }
                if (value == 1)
                {
                    Console.WriteLine("happy");
                    break;
                }
            }
            while (value != 1);
            Console.ReadKey();
        }
    }
}
