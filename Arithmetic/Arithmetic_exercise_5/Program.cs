using System;

namespace Arithmetic_exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNr;
            var randomNr = new Random();
            var selectedNr = randomNr.Next(1, 100);

            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            inputNr = int.Parse(Console.ReadLine());
            Console.WriteLine(DidIGuessNumber(selectedNr,inputNr));


        }
        static string DidIGuessNumber(int num, int inputNr)
        {
            if(num > inputNr)
            {
                return $"Sorry, you are too low.  I was thinking of {num}.";
            }
            if(num < inputNr)
            {
                return $"Sorry, you are too high.  I was thinking of {num}";
            }
            return $"You guessed it!  What are the odds?!?";
        }
    }
}
