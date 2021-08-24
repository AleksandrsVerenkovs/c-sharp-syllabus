using System;

namespace Exercise_1
{
    public class Checker
    {
        public static bool Compare(int num1, int num2)
        {
            if (num1 == 15 || num2 == 15 || Math.Abs(num1 + num2) == 15) return true;
            return false;
        }
    }
}
