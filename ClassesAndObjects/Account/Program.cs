using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            var MattAcc = new Account("Matt", 1000.00);
            var MyAcc = new Account("My Account", 0);

            Console.WriteLine("Initial state");
            Console.WriteLine(MattAcc);
            Console.WriteLine(MyAcc);
            Console.ReadKey();
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            to.deposit(from.withdrawal(howMuch));
        }
    }
}
