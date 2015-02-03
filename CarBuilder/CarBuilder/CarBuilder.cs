using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarBuilder
{
    interface CarBuilder
    {
        void buildMaker();
        void buildName();
        void buildType();
        Car getCar();
    }
}
