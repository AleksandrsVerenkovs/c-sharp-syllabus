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
        public void DisplayDate_ReturnCorrectDate(int day, int month,int year,string expected)
        {
            var newDate = new Exercise5.Program.Date(day, month, year);

            var actual = newDate.DisplayDate();

            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData(32, 12, 1992, "31")]
        [InlineData(0, 10, 1832, "31")]
        public void DisplayDate_InccorectDay_Return31AsDay(int day, int month, int year, string expected)
        {
            var newDate = new Exercise5.Program.Date(day, month, year);

            var actual = newDate.Day;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(32, 13, 1992, "12")]
        [InlineData(0, -1, 1832, "12")]
        public void DisplayDate_InccorectMonth_Return12AsMonth(int day, int month, int year, string expected)
        {
            var newDate = new Exercise5.Program.Date(day, month, year);

            var actual = newDate.Month;

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(32, 13, -1, "2000")]
        [InlineData(32, 13, 0, "2000")]
        public void DisplayDate_InccorectYear_Return2000AsYear(int day, int month, int year, string expected)
        {
            var newDate = new Exercise5.Program.Date(day, month, year);

            var actual = newDate.Year;

            Assert.Equal(expected, actual);
        }
    }
}
