using System;

namespace Piglet
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var points = 0;
            var stopGame = false;

            var roll = random.Next(1, 7);
            Console.WriteLine("Welcome to Piglet!");
            while (stopGame == false)
            {
                Console.WriteLine($"You rolled a {roll}!");
                if(roll == 1)
                {
                    points = 0;
                    Console.WriteLine("You got 0 points");
                    stopGame = true;
                }

                Console.WriteLine("Roll again? [y/n]");
                points += roll;

                var response = Console.ReadKey(true);
                if (response.KeyChar == 'n')
                {
                    stopGame = true;
                    Console.WriteLine($"You got {points} points.");
                }
            }

            Console.ReadKey();
        }
    }
}
