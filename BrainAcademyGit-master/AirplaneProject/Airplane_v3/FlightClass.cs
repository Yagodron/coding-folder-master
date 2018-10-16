using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplane_v4
{
    class FlightClass
    {
        string _name;
        int _cost;
        public FlightClass(string s, int n)
        {
            this._name = s;
            this._cost = n;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }
    }
}
