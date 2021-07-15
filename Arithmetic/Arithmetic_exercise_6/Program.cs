using System;

namespace CozaLozaWoza
{
    class Program
    {
        static void Main(string[] args)
        {
            for(var i = 1;i <= 110; i++)
            {
                if (i % 11 == 0 && i % 3 == 0) Console.WriteLine("Coza ");
                else if (i % 11 == 0) Console.WriteLine(i);
                else if (i % 15 == 0 || i % 21 == 0) Console.Write("CozaLoza ");
                else if (i % 7 == 0) Console.Write("Woza ");
                else if (i % 5 == 0) Console.Write("Loza ");
                else if (i % 3 == 0) Console.Write("Coza ");
                else Console.Write($"{i} ");

            }
        }
    }
}
