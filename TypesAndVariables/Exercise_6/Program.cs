using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ExitLoop = false;
            int Sum = 0;
            int ParsedInt;
            int Number;
            ConsoleKey breakLoop;

            while (!ExitLoop)
            {
                Console.WriteLine("Enter WHOLE numbers.");
                string Input = Console.ReadLine();
                if(!int.TryParse(Input, out Number))
                {
                    Console.WriteLine("You can enter only NUMBERS!");
                }
                else
                {
                ParsedInt = int.Parse(Input);
                Sum += ParsedInt;
                Console.WriteLine($"Total at the moment: {Sum}");
                Console.WriteLine("Do you wish to end process? [y/n]");
                breakLoop = Console.ReadKey(false).Key;
                    if(breakLoop == ConsoleKey.Y)
                    {
                        ExitLoop = true;
                    }
                Console.WriteLine();
                }
            }
        }
    }
}
