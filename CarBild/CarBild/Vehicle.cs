using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarBild
{
    class Vehicle
    {
        private string _vehicleType;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        public Vehicle(string vehicleType)
        {
            this._vehicleType = vehicleType;
        }

        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n------------------");
            Console.WriteLine("Vehicle Type: {0}", _vehicleType);
            Console.WriteLine("        name: {0}", _parts["name"]);
        }


    }
}
