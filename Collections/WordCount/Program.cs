using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

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
            var regexText = Regex.Replace(text, @"[\n\']|(  )|(, )"," ");
            var words = regexText.Split(' ').Count();
            return words;
        }

        public static int CharCount(string text)
        {
            var chars = text.Count();
            return chars;
        }
    }
}
