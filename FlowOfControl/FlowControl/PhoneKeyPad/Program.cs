using System;
using System.Collections.Generic;

namespace PhoneKeyPad
{
    class Program
    {
        public class PhoneCode
        {
         
            public char[] ABC = {'a','b','c'};
            public char[] DEF = { 'd', 'e', 'f' };
            public char[] GHI = { 'g', 'h', 'i' };
            public char[] JKL = { 'j', 'k', 'l' };
            public char[] MNO = { 'm', 'n', 'o' };
            public char[] PQRS = { 'p', 'q', 'r' ,'s'};
            public char[] TUV = { 't', 'u', 'v' };
            public char[] WXYZ = { 'w', 'x', 'y','z' };

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text (letters only).");
            var inputArr = Console.ReadLine().ToLower().ToCharArray();
            Console.WriteLine("Choose decoding version: 1(nested-if) 2(switch).");
            var decodingVersion = int.Parse(Console.ReadLine());

            Console.WriteLine(DecodeTextToNumber(inputArr,decodingVersion));
            Console.ReadKey();
        }
        public static string DecodeTextToNumber(char[] arr, int version)
        {
            List<int> PhoneDigits1 = new List<int>();

            switch (version)
            {
                case 1:
                    foreach (var letter in arr)
                    {
                        PhoneDigits1.Add(PhoneNumber1.PhoneNum(letter));
                    }
                    return string.Join("", PhoneDigits1);
                    break;
                case 2:
                    foreach (var letter in arr)
                    {
                        PhoneDigits1.Add(PhoneNumber2.PhoneNum2(letter));
                    }
                    return string.Join("", PhoneDigits1);
                    break;
                default:
                    return "Choose version 1 or 2.";
                    break;
            }
        }
    }
}
