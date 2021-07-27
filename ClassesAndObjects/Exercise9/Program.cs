using System;

namespace Exercise9
{
    class Program
    {
        public class Point
        {
            private int X;
            private int Y;
            public int x
            {
                get { return X; }
                set { X = value; }
            }
            public int y
            {
                get { return Y; }
                set { Y = value; }
            }
            public Point(int first, int second)
            {
                X = first;
                Y = second;
            }
        }
        static void Main(string[] args)
        {
            var p1 = new Point(5, 2);
            var p2 = new Point(-3, 6);
            swapPoints(p1, p2);
            Console.WriteLine($"({p1.x},{p1.y})");
            Console.WriteLine($"({p2.x},{p2.y})");
            Console.ReadLine();
        }
        public static void swapPoints(Point first, Point second)
        {
            var firstCopy = new Point(first.x, first.y);

            first.x = second.x;
            first.y = second.y;

            second.x = firstCopy.x;
            second.y = firstCopy.y;
        }
    }
}
