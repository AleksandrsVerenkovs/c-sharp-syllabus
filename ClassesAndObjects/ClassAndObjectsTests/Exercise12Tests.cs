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
        public void Balance_ProvideBaseInfo_ReturnAccBalance(decimal initial, decimal expected)
        {
            //Arrange
            var personAcc = new Account.Account("Matt", initial);
            //Act
            var actual = personAcc.Balance();
            //Assert
            Assert.Equal(expected,actual);

        }

        [Theory]
        [InlineData(12.00, 12.00, 24.00)]
        [InlineData(0.00, 12.00, 12.00)]
        public void Deposit_ProvideAmount_AddToAccount(decimal initial,decimal money, decimal expected)
        {
            //Arrange
            var personAcc = new Account.Account("Matt", initial);
            //Act
            personAcc.Deposit(money);
            var actual = personAcc.Balance();
            //Assert
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData("Matt", 12.00, "Matt: 12.00")]
        [InlineData("Dave", 12.00, "Dave: 12.00")]
        public void ToString_ProvideBaseInfo_ReturnFullInfo(string name,decimal initialDep, string expected)
        {
            //Assert
            var personAcc = new Account.Account(name, initialDep);
            //Act
            var actual = personAcc.ToString();
            //Assert
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData(0.00, 12.00, 12.00)]
        [InlineData(250, 105.50, 355.50)]
        public void Transfer_ProvideAmountAndAccounts_TransfersMoney(decimal initialDep, decimal transferSum, decimal expected)
        {
            //Arrange
            var personAcc = new Account.Account("Matt", initialDep);
            var person2Acc = new Account.Account("Dace", initialDep);
            //Act
            Account.Program.Transfer(personAcc,person2Acc,transferSum);
            var actual = person2Acc.Balance();
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
