using System;
using System.Linq;
using Xunit;
using CheckOddEven;
using System.IO;

namespace Arithmatics.Tests
{
    public class Exercise2_Tests
    {
        [Theory]
        [InlineData(2, "Even Number")]
        [InlineData(6, "Even Number")]
        [InlineData(4, "Even Number")]
        [InlineData(-8, "Even Number")]
        public void IsEvenTest_InputIsEven(int num, string expected)
        {
            var actual = IsEven.OddOrEven(num);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, "Odd Number")]
        [InlineData(3, "Odd Number")]
        [InlineData(-7, "Odd Number")]
        [InlineData(11, "Odd Number")]
        public void IsEvenTest_InputIsOdd(int num, string expected)
        {
            var actual = IsEven.OddOrEven(num);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(2, "Even Number\nbye!")]
        [InlineData(3, "Odd Number\nbye!")]

        public void IsEvenTest_OutputsBye(int number, string expected)
        {
            var actual = IsEven.FullMessage(number);

            Assert.Equal(expected,actual);
        }
    }
}
