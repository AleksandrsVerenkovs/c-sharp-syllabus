using System;

namespace GravityCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            double gravity = -9.81;  // Earth's gravity in m/s^2
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;
            double finalPosition = 0.5 * Math.Abs(gravity)* Math.Pow(fallingTime,2)+initialVelocity*fallingTime + initialPosition;
            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            Console.ReadKey();
        }
        public static double FinalPosition(double initVelocity, double fallingTime, double initPosition)
        {
            double gravity = -9.81;
            return (0.5 * Math.Abs(gravity) * Math.Pow(fallingTime, 2) + initVelocity * fallingTime + initPosition)*-1;
        }
    }
}
