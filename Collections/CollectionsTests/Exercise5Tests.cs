using System;
using Xunit;
using WordCount;

namespace CollectionsTests
{
    public class Exercise5Tests
    {
        [Theory]
        [InlineData("this counts as 16", 17)]
        [InlineData("some text", 9)]
        [InlineData("some text with !< sym0", 22)]
        [InlineData("word \n or two", 13)]
        public void CharCount_ProvideText_ReturNumOfChars(string text, int expected)
        {
            //Act
            var actual = WordCount.Program.CharCount(text);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("this counts as 16", 1)]
        [InlineData("some\n text\n", 3)]
        [InlineData("word \n or two", 2)]
        public void LineCount_ProvideText_ReturNumOfLines(string text, int expected)
        {
            //Act
            var actual = WordCount.Program.LineCount(text);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("this counts as 16", 4)]
        [InlineData("this\n count's as 16", 5)]
        [InlineData("this\n count's as  16", 5)]
        [InlineData("this\n count's, as  16", 5)]
        public void WordCount_ProvideText_ReturNumOfWord(string text, int expected)
        {
            //Act
            var actual = WordCount.Program.WordCount(text);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
