using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQsortingcount
{
    class Emp

    {
        string _name;
        string _city;
        public string Name
        {
            get  { return _name; } 
        }
        public string City
        {
            get { return _city; } 
        }
        public Emp()
        { }
        public Emp(string name, string city)
        {
            _name = name;
            _city = city;
        }
    }
}
