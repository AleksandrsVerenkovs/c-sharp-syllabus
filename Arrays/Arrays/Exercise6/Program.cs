using System;
using System.Linq;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            var arr1 = Enumerable.Repeat(0,10).Select(i => random.Next(1,100)).ToArray();

            var arr2 = new int[arr1.Length];
            Array.Copy(arr1, arr2, arr1.Length);

            arr1[arr1.Length - 1] = -7;

            Console.WriteLine(string.Join(" ",arr1));
            Console.WriteLine(string.Join(" ", arr2));
            Console.ReadKey();
        }
    }
}
