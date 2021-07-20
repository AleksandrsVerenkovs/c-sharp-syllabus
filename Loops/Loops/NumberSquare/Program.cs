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

            //List<int> baseNumber = new List<int>();
            var baseNum = new int[maxVal];

            var increment = 0;
            for (int j = 0; j <= maxVal; j++)
            {
                //if(minVal + increment > maxVal)
                //{
                //    increment = 0;
                //}
                baseNum[j] = minVal + j;
                increment = j;
            }

            for ( int i = minVal; i<= maxVal; i++)
            {
                
                Console.WriteLine(string.Join(' ',baseNum));
            }

            Console.ReadKey();
        }
    }
}
