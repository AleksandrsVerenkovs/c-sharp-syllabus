using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            String myName;
            String myEyes;
            String myTeeth;
            String myHair;

            int myAge;
            int myHeight;
            int myWeight;
            double myHeightInCm;
            double myWeightInKg;

            myName = "Zed A. Shaw";
            myAge = 35;
            myHeight = 74;  // inches
            myWeight = 180; // lbs
            myWeightInKg = Math.Round(180 * 0.453592,2);
            myHeightInCm = myHeight * 2.54;
            myEyes = "Blue";
            myTeeth = "White";
            myHair = "Brown";

            Console.WriteLine("Let's talk about " + myName + ".");
            Console.WriteLine("He's " + myHeightInCm + " centimeters tall.");
            Console.WriteLine("He's " + myWeightInKg + " kilos heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + myEyes + " eyes and " + myHair + " hair.");
            Console.WriteLine("His teeth are usually " + myTeeth + " depending on the coffee.");

            Console.WriteLine("If I add " + myAge + ", " + myHeight + ", and " + myWeight
                               + " I get " + (myAge + myHeight + myWeight) + ".");

            Console.ReadKey();
        }
    }
}