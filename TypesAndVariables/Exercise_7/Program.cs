using System;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperCaseCounter = 0;
            string writtenText;
            Console.WriteLine("Write something");
            writtenText = Console.ReadLine();

            char[] charrArr = writtenText.ToCharArray();
            foreach(var i in charrArr)
            {
                if(Char.IsUpper(i) && Char.IsLetter(i))
                {
                    upperCaseCounter++;
                }
            }
            Console.WriteLine($"You had {upperCaseCounter} upper case characters.");
            Console.ReadKey();
        }
    }
}
