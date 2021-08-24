using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Arithmetic_exercise_8;

namespace Arithmatics.Tests
{
    public class Exercise8Tests
    {
        [Theory]
        [InlineData(3, 7, "No, no. Hourly rate 7h is too low!")]
        [InlineData(60, 6, "No, no. Hourly rate 6h is too low!")]
        [InlineData(12, 7.5, "No, no. Hourly rate 7.5h is too low!")]
        public void Salary_HourRateUnder8_ReturnWarning(int hours, decimal hourlyRate, string expected)
        {
            var actual = Arithmetic_exercise_8.Program.Salary(hours, hourlyRate);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(61, 8.6, "You salary is 720.00$. Sorry, but not more than 60h work time.")]
        [InlineData(70, 8, "You salary is 720.00$. Sorry, but not more than 60h work time.")]
        [InlineData(80, 10, "You salary is 720.00$. Sorry, but not more than 60h work time.")]
        public void Salary_WorkedHoursOver60_720Salary(int hours, decimal hourlyRate, string expected)
        {
            var actual = Arithmetic_exercise_8.Program.Salary(hours, hourlyRate);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(48, 8.6, "You salary is 447.20$.")]
        [InlineData(59, 8, "You salary is 548.00$.")]
        [InlineData(41, 10, "You salary is 415.00$.")]
        public void Salary_WorkedHoursBetween40And60_BiggerSalary(int hours, decimal hourlyRate, string expected)
        {
            var actual = Arithmetic_exercise_8.Program.Salary(hours, hourlyRate);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(40, 8, "You salary is 320.00$.")]
        [InlineData(20, 8.2, "You salary is 164.00$.")]
        [InlineData(39, 10, "You salary is 390.00$.")]
        public void Salary_WorkedHoursUnder40_BaseSalary(int hours, decimal hourlyRate, string expected)
        {
            var actual = Arithmetic_exercise_8.Program.Salary(hours, hourlyRate);

            Assert.Equal(expected, actual);
        }
    }
}
