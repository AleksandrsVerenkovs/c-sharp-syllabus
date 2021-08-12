using System;

namespace Exercise_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int First;
            int Second;
            Console.WriteLine("Enter first INTEGER nr.");
            First = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second INTEGER nr.");
            Second = int.Parse(Console.ReadLine());
            Console.WriteLine(Checker.Compare(First, Second));
            Console.ReadKey();
        }
    }
}
