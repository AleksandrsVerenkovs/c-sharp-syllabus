using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Exercise5;

namespace ClassAndObjectsTests
{
    public class Exercise5Tests
    {
        [Theory]
        [InlineData(6,12,1992,"6/12/1992")]
        [InlineData(21, 10, 1832, "21/10/1832")]
        public void DisplayDate_ProvideDayMonthYear_ReturnCorrectDate(int day, int month,int year,string expected)
        {
            //Arrange
            var newDate = new Exercise5.Program.Date(day, month, year);
            //Act
            var actual = newDate.DisplayDate();
            //Assert
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData(32, 12, 1992, "31")]
        [InlineData(0, 10, 1832, "31")]
        public void DisplayDate_ProvideIncorrectDay_Return31AsDay(int day, int month, int year, string expected)
        {
            //Arrange
            var newDate = new Exercise5.Program.Date(day, month, year);
            //Act
            var actual = newDate.Day;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(32, 13, 1992, "12")]
        [InlineData(0, -1, 1832, "12")]
        public void DisplayDate_ProvideIncorrectMonth_Return12AsMonth(int day, int month, int year, string expected)
        {
            //Arrange
            var newDate = new Exercise5.Program.Date(day, month, year);
            //Act
            var actual = newDate.Month;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(32, 13, -1, "2000")]
        [InlineData(32, 13, 0, "2000")]
        public void DisplayDate_ProvideIncorrectYear_Return2000AsYear(int day, int month, int year, string expected)
        {
            //Arrange
            var newDate = new Exercise5.Program.Date(day, month, year);
            //Act
            var actual = newDate.Year;
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
