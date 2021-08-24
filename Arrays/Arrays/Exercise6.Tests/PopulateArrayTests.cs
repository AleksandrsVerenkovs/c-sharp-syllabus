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
        public void PopulateArray_ProvideBaseArray_CopiedArray()
        {
            //Arrange
            var arr = new int[] { 1, 2, 3, 4, 5 };
            //Act
            var actual = ArrayPopulate.CreateCopy(arr);
            //Assert
            Assert.Equal(arr, actual);
        }
        [Fact]
        public void PopulateArray_GivenMinus7_ChangeLastValue()
        {
            //Arrange
            var arr = new int[] { 1, 2, 3, 4, 5 };
            //Act
            var givenValue = -7;
            var actual = ArrayPopulate.CreateCopy(arr);
            //Assert
            ArrayPopulate.ChangeLastValueTo(actual, givenValue);

            Assert.NotEqual(arr[arr.Length - 1], actual[actual.Length - 1]);
        }
        [Fact]
        public void PopulateArray_ArraySize10_AllValuesAreUnder100()
        {
            //Arrange
            var arr = ArrayPopulate.CreateArray(10);
            //Act
            var arrFilter = arr.Where(num => num <= 0 || num > 100).ToArray();
            //Assert
            Assert.True(0 == arrFilter.Length);
        }


    }
}
