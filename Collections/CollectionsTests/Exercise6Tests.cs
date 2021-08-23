using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using FlightPlanner;
using System.Collections;

namespace CollectionsTests
{
    public class TestDataGenerator : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[]
                {
                    "b -> dest1",
                    "c-> dest2",
                    "d -> dest3",
                    "b -> dest4"
                }
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    public class Exercise6Tests
    {
        Cities cityCreator = new Cities();

        [Theory]
        [InlineData(new string[] { "b -> dest1", "c-> dest2", "d -> dest3", "b -> dest4" }, new string[] { "b", "c", "d" })]
        public void CityList_ProivideStrArray_ReturnHashSet(string[] list, string[] expected)
        {
            //Act
            var city = new Cities();
            city.CityDictionary(list);
            var actual = city.CityList();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void CityDictionary_ProvideStrArray_ReturnDictionary(string[] baseInfo)
        {
            //Arrange
            var expected = new Dictionary<string, List<string>>()
            {
                {"b",new List<string>(){"dest1","dest4" } },
                {"c",new List<string>(){"dest2" } },
                {"d",new List<string>(){"dest3" } }
            };
            //Act
            var actual = cityCreator.CityDictionary(baseInfo);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
