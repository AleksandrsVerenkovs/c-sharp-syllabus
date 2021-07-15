using System;

namespace Product1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 1;
            int last = 10;

            int result = 1;

            for(var i = first; i <= last; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
