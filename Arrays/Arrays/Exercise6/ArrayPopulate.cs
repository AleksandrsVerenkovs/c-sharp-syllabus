using System;
using System.Linq;

namespace Exercise6
{
    public class ArrayPopulate
    {
        public static int[] CreateArray(int arrLength)
        {
            Random random = new Random();
            var arr = new int[arrLength].Select(num => random.Next(1, 100)).ToArray();
            return arr;
        }

        public static int[] CreateCopy(int[] arr)
        {
            var copiedArr = new int[arr.Length];
            Array.Copy(arr,copiedArr,arr.Length);
            return copiedArr;
        }

        public static int[] ChangeLastValueTo(int[] arr,int value)
        {
            arr[arr.Length - 1] = value;
            return arr;
        }
    }
}
