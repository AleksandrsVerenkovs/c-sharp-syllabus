using System;
using System.Collections.Generic;

namespace FlightPlanner
{

    public class Cities
    {
        private List<List<string>> _cityPairs;
        private Dictionary<string, List<string>> _dict;
        private HashSet<string> _singleCities;

        public Cities()
        {
            _dict = new Dictionary<string, List<string>>();
            _cityPairs = new List<List<string>>();
            _singleCities = new HashSet<string>();
        }

        public HashSet<string> CityList()
        {
            foreach(KeyValuePair<string,List<string>> city in _dict)
            {
                _singleCities.Add(city.Key);
            }
            return _singleCities;
        }

        public void CityPairs(string[] baseInfo)
        {
            foreach (var pair in baseInfo)
            {
                var cityPair = pair.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                var start = cityPair[0].Trim();
                var dest = cityPair[1].Trim();
                if (_dict.ContainsKey(start))
                {
                    _dict[start].Add(dest);
                }
                else
                {
                    _dict.Add(start, new List<string> { dest });
                }
            }

        }
        
        public Dictionary<string, List<string>> CityDictionary(string[] baseInfo)
        {
            CityPairs(baseInfo);
            
            return _dict;
        }
    }
}
