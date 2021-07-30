using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class SavingsAccount
    {
        private decimal _balance;
        public decimal Balance
        {
            get { return _balance; }
        }
        public SavingsAccount(decimal balance)
        {
            _balance = balance;
        }
        public void Withdraw(decimal amount)
        {
            _balance -= amount;
        }
        public void Deposit(decimal amount)
        {
            _balance += amount;
        }
        public void MonthlyInterest(double anualInterest)
        {
            var monthlyRate = anualInterest / 12;
            _balance = _balance * (decimal)Math.Pow(1.0 + monthlyRate, 4);
        }
    }
}
