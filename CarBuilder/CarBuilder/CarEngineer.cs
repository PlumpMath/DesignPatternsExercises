using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarBuilder
{
    class CarEngineer
    {
        public void Construct(CarBuilder carBuilder)
        {
            carBuilder.buildMaker();
            carBuilder.buildName();
            carBuilder.buildType();
        }
    }
}
