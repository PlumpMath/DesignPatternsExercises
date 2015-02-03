using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarBild
{
    abstract class VehicleBuilder
    {
        public abstract void buildName();
        public abstract Vehicle getVehicle();
    }
}
