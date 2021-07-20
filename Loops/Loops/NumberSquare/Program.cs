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

            var baseNum = new int[maxVal];

            //Create base number array
            var increm = 0;
            for(int i = 0; i < maxVal; i++)
            {
                //if (i + increm > maxval)
                //{
                //    increm = 0;
                //}
                baseNum[i] = minVal + increm;
                increm++;
            }

            var plusOne = 0;
            for ( int i = 1; i<= maxVal; i++)
            {
                foreach (var num in baseNum)
                {
                    if(num + plusOne > maxVal)
                    {
                        Console.Write(minVal);
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
