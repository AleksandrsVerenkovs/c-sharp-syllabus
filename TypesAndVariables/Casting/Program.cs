using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            first();
            second();
            Console.ReadKey();
        }

        static void first()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;

            int sum = a + b + c + d + e;
            Console.WriteLine(sum);
        }

        static void second()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            double d = 4.2;
            float e = 5.3f;

            double sum = Math.Round(a + b + c + d + e,2);
            Console.WriteLine(sum);
        }
    }
}
