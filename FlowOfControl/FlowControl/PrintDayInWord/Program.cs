using System;

namespace PrintDayInWord
{
    class Program
    {
        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter INT from 0 - 6.");
            var input = int.Parse(Console.ReadLine());

            Console.WriteLine(WeekDays1(input));
            Console.WriteLine(WeekDays2(input));
            Console.ReadKey();

        }
        public static string WeekDays1(int num)
        {
            if (num == 0) return $"{WeekDays.Monday}";
            else if (num == 1) return $"{WeekDays.Tuesday}";
            else if (num == 2) return $"{WeekDays.Wednesday}";
            else if (num == 3) return $"{WeekDays.Thursday}";
            else if (num == 4) return $"{WeekDays.Friday}";
            else if (num == 5) return $"{WeekDays.Saturday}";
            else if (num == 6) return $"{WeekDays.Sunday}";
            else return "Not valid day.";   
        }
        public static string WeekDays2(int num)
        {
            switch (num)
            {
                case 0:
                    return $"{WeekDays.Monday}";
                    break;
                case 1:
                    return $"{WeekDays.Tuesday}";
                    break;
                case 2:
                    return $"{WeekDays.Wednesday}";
                    break;
                case 3:
                    return $"{WeekDays.Thursday}";
                    break;
                case 4:
                    return $"{WeekDays.Friday}";
                    break;
                case 5:
                    return $"{WeekDays.Saturday}";
                    break;
                case 6:
                    return $"{WeekDays.Sunday}";
                    break;
                default:
                    return "Not valid day.";
                    break;
            }
        }
    }
}
