using System;
using System.IO;
using System.Linq;

namespace WordCount
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fileText = File.ReadAllText("../../lear.txt");
            var lines = LineCount(fileText);
            var words = WordCount(fileText);
            var chars = CharCount(fileText);

            Console.WriteLine($"Lines = {lines}");
            Console.WriteLine($"Words = {words}");
            Console.WriteLine($"Chars = {chars}");
            Console.ReadLine();
        }
        public static int LineCount(string text)
        {
            var lines = text.Split('\n').Count();
            return lines;
        }

        public static int WordCount(string text)
        {

            var words = text.Replace("\'", " ").Replace(", ", " ").Replace("  ", " ").Replace("\n", " ").Split(' ').Count();
            return words;
        }

        public static int CharCount(string text)
        {
            var chars = text.Count();
            return chars;
        }
    }
}
