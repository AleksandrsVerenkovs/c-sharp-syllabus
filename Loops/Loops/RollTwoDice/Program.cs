using System;

namespace RollTwoDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.Write("Desired sum: ");
            var desSum = int.Parse(Console.ReadLine());

            
            var diceRoll = 0;

            while (diceRoll != desSum)
            {
                var dice1 = random.Next(1, 7);
                var dice2 = random.Next(1, 7);
                diceRoll = dice1 + dice2;

                Console.WriteLine($"{dice1} and {dice2} = {diceRoll}");
            }
            Console.ReadKey();
        }
    }
}
