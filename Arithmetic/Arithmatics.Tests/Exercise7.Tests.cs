using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using GravityCalculator;

namespace Arithmatics.Tests
{
    public class Exercise7_Tests
    {
        [Theory]
        [InlineData(0, 10, 0, -490.5)]
        [InlineData(0, 10, 5, -495.5)]
        [InlineData(12, 10, 0, -610.5)]
        public void FallingPosition_ResultNegative490Point5(double initVelocity, double fallingTime, double initPosition, double expected)
        {
            var actual = GravityCalculator.Program.FinalPosition(initVelocity, fallingTime, initPosition);

            Assert.Equal(expected, actual);
        }
    }
}
