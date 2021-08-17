using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using FlightPlanner;
using System.Collections;
using Xunit.Abstractions;
using Xunit.Sdk;

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
            yield return new object[]
            {
                new[]
                {
                    "g -> dest5",
                    "h-> dest6",
                    "j -> dest7",
                    "l -> dest8"
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    public class Exercise6Tests
    {
        private readonly ITestOutputHelper _testOutputHelper;
        Cities cityCreator = new Cities();

        public Exercise6Tests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

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
            var cityCreator = new Cities();
            
        }


    }
}
