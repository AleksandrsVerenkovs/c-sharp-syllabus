using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FlightPlanner
{

    public class Cities
    {
        private const string Path = "../../flights.txt";
        private string[] readText = File.ReadAllLines(Path);
        private List<List<string>> _cityPairs;

        public Cities()
        {
            _cityPairs = new List<List<string>>();
        }
        public HashSet<string> CityList()
        {
            var singleCities = new HashSet<string>();

            foreach (var s in readText)
            {
                var line = s.Split(new string[] { ">", "-" }, StringSplitOptions.RemoveEmptyEntries);
                var arrPair = new List<string>();

                foreach (var i in line)
                {
                    singleCities.Add(i.Trim());
                    arrPair.Add(i.Trim());
                }
                _cityPairs.Add(arrPair);
            }
            return singleCities;
        }
        public Dictionary<string, List<string>> CityDictionary()
        {
            var cityDictionary = new Dictionary<string, List<string>>();

            //Create Dictionary of flight paths
            for (var j = 0; j < _cityPairs.Count; j++)
            {
                if (!cityDictionary.ContainsKey(_cityPairs[j][0]))
                {
                    cityDictionary.Add(key: _cityPairs[j][0], value: new List<string>() { _cityPairs[j][1]});
                }
                else
                {
                    cityDictionary[_cityPairs[j][0]].Add(_cityPairs[j][1]);
                }
            }
            return cityDictionary;
        }
    }
}
