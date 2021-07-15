using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int first;
            int second;
            Console.WriteLine("Enter first INTEGER nr.");
            first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second INTEGER nr.");
            second = int.Parse(Console.ReadLine());
            Console.WriteLine(Compare(first, second));
            Console.ReadKey();
        }
        public static bool Compare(int num1, int num2)
        {
           if(num1 == 15 || num2 == 15)
            {
                return true;
            }
           if(Math.Abs(num1+num2) == 15)
            {
                return true;
            }
            return false;
        }
    }
}
