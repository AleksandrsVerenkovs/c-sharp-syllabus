using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using FlightPlanner;

namespace CollectionsTests
{
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

        //[Theory]
        //[InlineData(
        //    new string[] { "b -> dest1", "c-> dest2", "d -> dest3", "b -> dest4" },
        //    new Dictionary<string, List<string>>() {
        //        {"b",new List<string>(){"dest1","dest4" } }
        //    })]
        //public void CityDictionary_ReturnDictionary(string[] baseInfo, Dictionary<string, List<string>> expected)
        //{
        //    var cityCreator = new Cities();

        //}


    }
}
