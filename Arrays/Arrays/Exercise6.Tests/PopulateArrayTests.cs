using System;
using System.Linq;
using Xunit;

namespace Exercise6.Tests
{
    public class PopulateArrayTests
    {
        [Fact]
        public void PopulateArray_GivenInt10_CreateArray()
        {
            //Arrange
            var givenInt = 10;
            //Act
            var actual = ArrayPopulate.CreateArray(givenInt);
            //Assert
            Assert.Equal(givenInt, actual.Length);
        }
        [Fact]
        public void PopulateArray_CopiedArray()
        {
            var arr = new int[] { 1, 2, 3, 4, 5 };

            var actual = ArrayPopulate.CreateCopy(arr);

            Assert.Equal(arr, actual);
        }
        [Fact]
        public void PopulateArray_GivenMinus7_ChangeLastValue()
        {
            var arr = new int[] { 1, 2, 3, 4, 5 };
            var givenValue = -7;
            var actual = ArrayPopulate.CreateCopy(arr);
            ArrayPopulate.ChangeLastValueTo(actual, givenValue);

            Assert.NotEqual(arr[arr.Length - 1], actual[actual.Length - 1]);
        }
        [Fact]
        public void PopulateArray_AllValuesAreUnder100()
        {
            var arr = ArrayPopulate.CreateArray(10);

            var arrFilter = arr.Where(num => num <= 0 || num > 100).ToArray();

            Assert.True(0 == arrFilter.Length);
        }


    }
}
