using System;

namespace LargestNumber
{
    class Program
    {
        //TODO: Write a C# program to to find the largest of three numbers.
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");
            var input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");
            var input3 = int.Parse(Console.ReadLine());

            var inputArr = new int[] { input1, input2, input3 };
            int largerstInt = 1;

            foreach(int num in inputArr)
            {
                if (num > largerstInt) largerstInt = num;
            }

            Console.WriteLine(
                $"Input the 1st number: {input1}\n" +
                $"Input the 2nd number: {input2}\n" +
                $"Input the 3rd number: {input3}\n" +
                $"Largest number : {largerstInt}");
            Console.ReadKey();

         
        }
    }
}
