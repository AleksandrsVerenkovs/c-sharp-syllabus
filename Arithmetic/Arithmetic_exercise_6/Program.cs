using System;
using System.Collections.Generic;
using System.Linq;

namespace CozaLozaWoza
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 110; i++)
            {
                if (i % 11 == 0 && i % 3 == 0)
                {
                    Console.Write("Coza\n");
                }
                else if (i % 11 == 0)
                {
                    Console.Write($"{i}\n");
                }
                else if (i % 21 == 0)
                {
                    Console.Write("CozaWoza ");
                }
                else if (i % 15 == 0)
                {
                    Console.Write("CozaLoza ");
                }
                else if (i % 7 == 0)
                {
                    Console.Write("Woza ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Loza ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Coza ");
                }
                else
                {
                    Console.Write($"{i} ");
                }

            }
        }

    }
    public class CozaLoza
    {
        public static List<string> PrintPattern()
        {
            var arr = Enumerable.Range(1, 110).Select(num => NameOrNumber(num)).ToList();
            return arr;
        }
        public static string NameOrNumber(int num)
        {
            if (num % 11 == 0 && num % 3 == 0)
            {
                return "Coza\n";
            }
            else if (num % 11 == 0)
            {
                return $"{num}\n";
            }
            else if (num % 21 == 0)
            {
                return "CozaWoza ";
            }
            else if (num % 15 == 0)
            {
                return "CozaLoza ";
            }
            else if (num % 7 == 0)
            {
                return "Woza ";
            }
            else if (num % 5 == 0)
            {
                return "Loza ";
            }
            else if (num % 3 == 0)
            {
                return "Coza ";
            }
            else
            {
                return $"{num} ";
            }
        }
    }
}
