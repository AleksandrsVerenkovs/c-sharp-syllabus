﻿namespace Account
{
    public class Account
    {
        private string _name;
        private decimal _money;

        public Account(string v1, decimal v2)
        {
            _name = v1;
            _money = v2;
        }

        public decimal Withdrawal(decimal i)
        {
            return i;
        }

        public void Deposit(decimal i)
        {
            _money += i;
        }

        public decimal Balance()
        {
            return _money;
        }

        public override string ToString()
        {
            return $"{_name}: {_money:F}";
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}
