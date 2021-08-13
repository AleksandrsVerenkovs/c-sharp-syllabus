using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using CalculateArea;

namespace Arithmatics.Tests
{
    public class Exercise10Tests
    {
        [Theory]
        [InlineData(2.00, 12.57)]
        [InlineData(4.30, 27.02)]
        public void Geometry_CalculateAreaOfCircle(decimal radius, double expected)
        {
            var actual = CalculateArea.Geometry.areaOfCircle(radius);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2.00, 2.00, 4.00)]
        [InlineData(4.30, 3.40, 14.62)]
        public void Geometry_CalculateAreaOfRectangle(decimal length, decimal width, double expected)
        {
            var actual = CalculateArea.Geometry.areaOfRectangle(length, width);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2.00, 2.00, 2.00)]
        [InlineData(4.30, 3.40, 7.31)]
        public void Geometry_CalculateAreaOfRTriangle(decimal ground, decimal hight, double expected)
        {
            var actual = CalculateArea.Geometry.areaOfTriangle(ground, hight);
            Assert.Equal(expected, actual);
        }
    }
}
