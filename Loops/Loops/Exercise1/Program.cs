using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            Console.WriteLine("The first 10 natural numbers are: ");
            for (var j = 0; j< 10; j++)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadKey();
            /*
            todo - write a program in C# to display the first 10 natural numbers
            for (......) 
            {
              Console.WriteLine(i);
            }
            */
        }
    }
}
