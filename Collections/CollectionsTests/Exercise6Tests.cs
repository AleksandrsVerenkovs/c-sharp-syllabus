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
        private readonly ITestOutputHelper _testOutputHelper;
        Cities cityCreator = new Cities();

        [Theory]
        [InlineData(new string[] { "b -> dest1", "c-> dest2", "d -> dest3", "b -> dest4" }, new string[] { "b", "c", "d" })]
        public void CityList_ReturnHashSet(string[] list, string[] expected)
        {
            var city = new Cities();
            city.CityDictionary(list);
            var actual = city.CityList();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void CityDictionary_ReturnDictionary(string[] baseInfo)
        {
            var expected = new Dictionary<string, List<string>>()
            {
                {"b",new List<string>(){"dest1","dest4" } },
                {"c",new List<string>(){"dest2" } },
                {"d",new List<string>(){"dest3" } }
            };
            var actual = cityCreator.CityDictionary(baseInfo);

            Assert.Equal(expected,actual);


        }


    }
}
