using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
        private static void Main(string[] args)
        {
            var enteredName = "fdf";
            var nameHashset = new HashSet<string>();
            do
            {
                Console.Write("Enter name: ");
                enteredName = Console.ReadLine();
                nameHashset.Add(enteredName);
            }
            while (enteredName != "");
            Console.WriteLine($"Unique name list contains: {string.Join(" ", nameHashset)}");
            Console.ReadLine();
        }
    }
}
