using System;

namespace BankAccount
{
    class Program
    {
        public class Account
        {
            private string Name;
            private double Balance;
            //public string name { get; set; }
            //public double balance { get; set; }


            public Account(string name, double balance)
            {
                Name = name;
                Balance = balance;
            }
        public string ShowUserNameAndBalance()
        {
                return $"{Name}, {_ = (Balance > 0 ? "" : "-")}${String.Format("{0:.00}", Math.Abs(Balance))}";
        }
        }
        static void Main(string[] args)
        {
            var p1 = new Account("Brendon",17.50);
            var p2 = new Account("Susan", 12.3);
            var p3 = new Account("Tommy", -5);
            var p4 = new Account("Megan", 7);

            Console.WriteLine(p1.ShowUserNameAndBalance());
            Console.WriteLine(p2.ShowUserNameAndBalance());
            Console.WriteLine(p3.ShowUserNameAndBalance());
            Console.WriteLine(p4.ShowUserNameAndBalance());

            Console.ReadKey();

        }
    }
}
