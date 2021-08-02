using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string,string> _data;
        private int _dataCount;

        public PhoneDirectory() {
            _data = new SortedDictionary<string, string>();
            _dataCount = _data.Count();
        }

        private int Find(string name) {
            for (var i = 0; i < _dataCount; i++) 
            {
                if (_data.ContainsKey(name)) 
                {
                    return i;
                }
            }

            return -1;
        }

        public string GetNumber(string name) 
        {
            var value = "";
            if(_data.TryGetValue(name, out value))
            {
                return value;
            }
            else
            {
                return "Number wasn't found";
            }
        }

        public void PutNumber(string name, string number) 
        {
            if (name == null || number == null) 
            {
                throw new Exception("name and number cannot be null");
            }

            if (_data.ContainsKey(name)) 
            {
                _data[name] = number;
            }
            else 
            {
                var newEntry = new PhoneEntry { name = name, number = number };
                _data.Add(newEntry.name, newEntry.number);
            }
        }
    }
}