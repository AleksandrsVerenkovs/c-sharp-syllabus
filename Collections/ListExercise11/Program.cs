using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var strList = new List<string>();

            strList.Add("wolf");
            strList.Add("bear");
            strList.Add("eagle");
            strList.Add("fish");
            strList.Add("fox");
            strList.Add("horse");
            strList.Add("dog");
            strList.Add("walrus");
            strList.Add("shark");
            strList.Add("crow");

            strList.Insert(4, "CAT");
            strList[strList.IndexOf(strList.Last())] = "pigeon";
            strList.Sort();

            var hasFoobar = strList.Contains("Foobar") ? true : false;
            Console.WriteLine($"Contains Foobar: {hasFoobar}");

            foreach (var i in strList)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
