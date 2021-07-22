using System;
using System.Collections.Generic;

namespace NumberSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Min: ");
            var minVal = int.Parse(Console.ReadLine());
            Console.WriteLine("Max : ");
            var maxVal = int.Parse(Console.ReadLine());

            List<int> baseNum = new List<int>();

            //Create base number array
            var increm = 0;
            for(int i = 0; i <= maxVal-minVal; i++)
            {
                baseNum.Add(minVal + increm);
                increm++;
            }
            var plusOne = 0;
            for (int i = 0; i <= maxVal - minVal; i++)
            {
                var plusser = 0;
                foreach (var num in baseNum)
                {
                    if (num + plusOne > maxVal)
                    {
                        Console.Write(minVal + plusser);
                        plusser++;
                    }
                    else
                    {
                        Console.Write(num + plusOne);
                    }
                }

                Console.WriteLine();
                plusOne++;
            }

            Console.ReadKey();
        }
    }
}
