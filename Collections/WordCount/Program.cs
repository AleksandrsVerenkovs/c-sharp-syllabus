using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileText = File.ReadAllText("../../lear.txt");
            var lines = fileText.Split('\n').Count();
            var words = fileText.Split(new string[] { "\'", " ","," }, StringSplitOptions.RemoveEmptyEntries);
            var chars = fileText.Count();


            Console.WriteLine($"Lines = {lines}");
            Console.WriteLine($"Words = {fileText.Split(new string[] {"\'"," ","," },StringSplitOptions.RemoveEmptyEntries).Count()}");
            Console.WriteLine($"Chars = {chars}");


            Console.ReadLine();
        }
    }
}
