using System;
using System.Globalization;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much money is in the account?: ");
            var balance = decimal.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the annual interest rate: ");
            var interestRate = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("How long has the account been opened?: ");
            var duration = int.Parse(Console.ReadLine());

            var account = new SavingsAccount(balance);
            decimal totalDeposit = 0;
            decimal totalWithdraw = 0;
            for (int i = 1; i <= duration; i++)
            {
                Console.WriteLine($"Enter amount deposited for month nr.{i}");
                var deposit = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"Enter amount withdrawn for month nr.{i}");
                var withdraw = decimal.Parse(Console.ReadLine());

                totalDeposit += deposit;
                account.Deposit(deposit);

                totalWithdraw += withdraw;
                account.Withdraw(withdraw);

                account.MonthlyInterest(interestRate);
            }
            Console.WriteLine($"Total deposited: {totalDeposit.ToString("C", CultureInfo.CurrentCulture)}");
            Console.WriteLine($"Total withdrawn: {totalWithdraw.ToString("C", CultureInfo.CurrentCulture)}");
            Console.WriteLine($"Interest earned: {(account.Balance - balance).ToString("C", CultureInfo.CurrentCulture)}");
            Console.WriteLine($"Ending balance: {account.Balance.ToString("C", CultureInfo.CurrentCulture)}");
        }
    }
}
