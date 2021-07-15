using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int First;
            int Second;
            Console.WriteLine("Enter first INTEGER nr.");
            First = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second INTEGER nr.");
            Second = int.Parse(Console.ReadLine());
            Console.WriteLine(Compare(First, Second));
            Console.ReadKey();
        }
        public static bool Compare(int num1, int num2)
        {
            if (num1 == 15 || num2 == 15 || Math.Abs(num1 + num2) == 15) return true;
            return false;
        }
    }
}
