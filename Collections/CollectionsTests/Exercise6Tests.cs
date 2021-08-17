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

        public IEnumerator<string[]> GetStr()
        {
            yield return (string[])(new object[] { new string[] { "b -> dest1", "c-> dest2", "d -> dest3", "b -> dest4" } });
        }
        IEnumerator IEnumerable.GetStr() => GetStr();

    }
    public class Exercise6Tests
    {
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
            var cityCreator = new Cities();


        }


    }
}
