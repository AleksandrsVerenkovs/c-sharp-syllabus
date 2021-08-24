using System;
using Xunit;
using Exercise_1;
namespace Arithmatics.Tests
{
    public class Exercise1_Tests
    {
        [Theory]
        [InlineData(15,0,true)]
        [InlineData(0, 15, true)]
        [InlineData(15, 15, true)]
        public void CompareTest_InputIs15(int x,int y,bool expected)
        {
            var actual = Checker.Compare(x, y);
            Assert.True(expected == actual);
        }
        [Theory]
        [InlineData(6, 5, false)]
        [InlineData(3, -2, false)]
        [InlineData(0, 0, false)]
        public void CompareTest_InputNot15(int x, int y, bool expected)
        {
            var actual = Checker.Compare(x, y);
            Assert.True(expected == actual);
        }
        [Theory]
        [InlineData(6, 9, true)]
        [InlineData(-15, 0, true)]
        [InlineData(30, -15, true)]
        [InlineData(-30, 15, true)]

        public void CompareTest_InputAbsSum15(int x, int y, bool expected)
        {
            var actual = Checker.Compare(x, y);
            Assert.True(expected == actual);
        }
    }
}
