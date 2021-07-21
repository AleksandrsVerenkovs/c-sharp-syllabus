using System;

namespace AsciiFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var size3 = Constant.Size3;
            //var side = 16;
            //var center = 0;
            //for(var i = 0; i < 5; i++)
            //{
            //    Console.Write(new String('/',side));
            //    Console.Write(new String('*', center));
            //    Console.Write(new String('\\', side));
            //    Console.WriteLine();
            //    side -= 4;
            //    center += 8;
            //}
            Pyramid(size3);

            Console.ReadLine();

            void Pyramid(int size)
            {
                var center = 0;
                var side = 0;
                for (var i = 2; i <= size; i++)
                {
                    side += 4;
                }

                for (var i = 0; i < size; i++)
                {
                    Console.Write(new String('/', side));
                    Console.Write(new String('*', center));
                    Console.Write(new String('\\', side));
                    Console.WriteLine();
                    side -= 4;
                    center += 8;
                }
            }
        }
        class Constant
        {
            public const int Size3 = 3;
        }
    }
}
