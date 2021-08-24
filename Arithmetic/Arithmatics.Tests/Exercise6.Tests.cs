using System;
using Xunit;
using CozaLozaWoza;
using System.Linq;

namespace Arithmatics.Tests
{
    public class Exercise6_Tests
    {
        [Theory]
        [InlineData(1,"1 ")]
        [InlineData(2,"2 ")]
        [InlineData(31,"31 ")]
        [InlineData(16,"16 ")]
        public void NameOrNumber_ReturnNumber(int num, string expected)
        {
            var actual = CozaLoza.NameOrNumber(num);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, "Coza ")]
        [InlineData(6, "Coza ")]
        [InlineData(18, "Coza ")]
        [InlineData(27, "Coza ")]
        public void NameOrNumber_ReturnCoza(int num, string expected)
        {
            var actual = CozaLoza.NameOrNumber(num);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, "Loza ")]
        [InlineData(10, "Loza ")]
        [InlineData(20, "Loza ")]
        public void NameOrNumber_ReturnLoza(int num, string expected)
        {
            var actual = CozaLoza.NameOrNumber(num);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(7, "Woza ")]
        [InlineData(14, "Woza ")]
        [InlineData(28, "Woza ")]
        public void NameOrNumber_ReturnWoza(int num, string expected)
        {
            var actual = CozaLoza.NameOrNumber(num);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(15, "CozaLoza ")]
        [InlineData(60, "CozaLoza ")]
        public void NameOrNumber_ReturnCozaLoza(int num, string expected)
        {
            var actual = CozaLoza.NameOrNumber(num);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(21, "CozaWoza ")]
        [InlineData(42, "CozaWoza ")]
        public void NameOrNumber_ReturnCozaWoza(int num, string expected)
        {
            var actual = CozaLoza.NameOrNumber(num);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(11, "11\n")]
        [InlineData(22, "22\n")]
        [InlineData(55, "55\n")]
        public void NameOrNumber_ReturnNumberBrakLine(int num, string expected)
        {
            var actual = CozaLoza.NameOrNumber(num);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(33, "Coza\n")]
        [InlineData(66, "Coza\n")]
        [InlineData(99, "Coza\n")]
        public void NameOrNumber_ReturnCozaBrakLine(int num, string expected)
        {
            var actual = CozaLoza.NameOrNumber(num);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrintPattern_ListLengthIs110()
        {
            var expected = 110;
            var actual = CozaLoza.PrintPattern().Count;

            Assert.True(expected == actual);
        }

        [Fact]
        public void PrintPattern_Has10Lines()
        {
            var expected = 10;
            var actual = CozaLoza.PrintPattern().Where(i => i.Contains("\n")).ToList().Count;

            Assert.Equal(expected, actual);
        }
    }
}
