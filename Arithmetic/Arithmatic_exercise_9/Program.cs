using System;

namespace Arithmatic_exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight;
            double height;
            double BMI;


            Console.WriteLine("Enter Your height (in CM).");
            height = Math.Round(int.Parse(Console.ReadLine())/ 2.54,2);
            Console.WriteLine("Enter Your weight (in kg.)");
            weight = Math.Round(int.Parse(Console.ReadLine())*2.2046);

            BMI = Math.Round((weight * 703) / Math.Pow(height, 2),0);
            if (BMI < 18.5) Console.WriteLine($"\nYour BMI is {BMI}, You are UNDERWEIGHT.");
            else if (BMI > 25) Console.WriteLine($"\nYour BMI is {BMI}, You are OVERDERWEIGHT.");
            else Console.WriteLine($"\nYour BMI is {BMI}, you have OPTIMAL WEIGHT.");
            Console.ReadKey();

        }
    }
}
