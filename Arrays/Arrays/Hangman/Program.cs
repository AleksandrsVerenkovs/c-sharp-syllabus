using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = false;
            do
            {
                Random random = new Random();
                var tryCount = 7;
                HashSet<char> wrongLetter = new HashSet<char>();

                var wordList = new string[5] { "mammoth", "leviathan", "sabath", "imbecile", "foxtrot" };

                var wordInList = wordList[random.Next(0, 5)];
                var wordArr = wordInList.ToCharArray();
                var hiddenWord = new string('_', wordArr.Length).ToCharArray();

                while (tryCount > 0)
                {
                    Console.WriteLine($"\nWord: {string.Join(' ', hiddenWord)}\n");
                    Console.WriteLine($"Trys left: {tryCount}");
                    Console.WriteLine($"Misses: {string.Join(' ', wrongLetter)}\n");

                    Console.Write("Guess: ");
                    var guess = char.Parse(Console.ReadLine());

                    for (int i = 0; i < wordArr.Length; i++)
                    {
                        if (wordArr[i] == guess)
                        {
                            hiddenWord[i] = guess;
                        }
                    }

                    if (!Array.Exists(wordArr, elem => elem == guess))
                    {
                        wrongLetter.Add(guess);
                        tryCount--;
                    }

                    var isWon = Array.Exists(hiddenWord, elem => elem == '_');

                    if (!isWon)
                    {
                        Console.WriteLine("You smart cookie!");
                        break;
                    }
                }

                if (tryCount == 0)
                {
                    Console.WriteLine("Sorry, better luck next time!");
                }

                Console.WriteLine("Play again? [y/n]");
                var response = Console.ReadKey(true);

                if(response.KeyChar == 'y')
                {
                    playAgain = playAgain == true;
                }
            } while (playAgain);
            Console.ReadKey();
        }
    }
}
