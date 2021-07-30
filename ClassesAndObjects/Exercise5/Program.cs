using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            var testDate = new Date(2, 33, 1993);
            testDate.DisplayDate();
            Console.ReadKey();
        }
        public class Date
        {
            private string _Month;
            private string _Day;
            private string _Year;

            public string Day
            {
                get { return _Year; }
                set
                {
                    int val = int.Parse(value);
                    _Year = val >= 1 && val <= 31 ? value : 2000.ToString();
                }
            }
            public string Month
            {
                get { return _Month; }
                set
                {
                    int val = int.Parse(value);
                    _Month = val >= 1 && val <= 12 ? value : 12.ToString();
                }
            }
            public string Year
            {
                get { return _Day; }
                set { _Day = int.Parse(value) != 0 ? value : 2000.ToString(); }
            }
            public Date(int day, int month, int year)
            {
                Day = day.ToString();
                Month = month.ToString();
                Year = year.ToString();
            }
            public void DisplayDate()
            {
                Console.Write($"{Day}/{Month}/{Year}");
            }
        }
    }
}
