using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Account;

namespace ClassAndObjectsTests
{
    public class Exercise12Tests
    {
        [Theory]
        [InlineData(12.00, 12.00)]
        public void Balance_ReturnAccBalance(decimal initial, decimal expected)
        {
            var personAcc = new Account.Account("Matt", initial);

            var actual = personAcc.Balance();

            Assert.Equal(expected,actual);

        }

        [Theory]
        [InlineData(12.00, 12.00, 24.00)]
        [InlineData(0.00, 12.00, 12.00)]
        public void Deposit_AddToAccount(decimal initial,decimal money, decimal expected)
        {
            var personAcc = new Account.Account("Matt", initial);

            personAcc.Deposit(money);
            var actual = personAcc.Balance();

            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData("Matt", 12.00, "Matt: 12.00")]
        [InlineData("Dave", 12.00, "Dave: 12.00")]
        public void ToString_ReturnFullInfo(string name,decimal initialDep, string expected)
        {
            var personAcc = new Account.Account(name, initialDep);


            var actual = personAcc.ToString();

            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData(0.00, 12.00, 12.00)]
        [InlineData(250, 105.50, 355.50)]
        public void Transfer_TransfersMoney(decimal initialDep, decimal transferSum, decimal expected)
        {
            var personAcc = new Account.Account("Matt", initialDep);
            var person2Acc = new Account.Account("Dace", initialDep);

            Account.Program.Transfer(personAcc,person2Acc,transferSum);
            var actual = person2Acc.Balance();

            Assert.Equal(expected, actual);
        }
    }
}
