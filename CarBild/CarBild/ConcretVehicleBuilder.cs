using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarBild
{
    class ConcretVehicleBuilder : VehicleBuilder
    {
        private Vehicle pojazd = new Vehicle("Samochod");

        
        public override void buildName()
        {
            this.pojazd["name"] = "Mazda 626";
        }



        public override Vehicle getVehicle()
        {
            return this.pojazd;
        }
    }
}
