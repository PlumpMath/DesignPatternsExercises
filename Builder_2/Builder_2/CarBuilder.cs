using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder_2
{
    class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            vehicle = new Vehicle("Car");
        }

        public override void BuildDoors()
        {
            vehicle["doors"] = "4";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "2500 cc";
        }

        public override void BuildFrame()
        {
            vehicle["frame"] = "4";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "4";
        }
    }
}
