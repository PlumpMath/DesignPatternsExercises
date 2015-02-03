using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarBuilder
{
    class Mazda626Builder : CarBuilder
    {
        private Car car;

        public Mazda626Builder()
        {
            car = new Car();
        }

        #region CarBuilder Members

        public void buildMaker()
        {
            car.setMaker("Mazda");
        }

        public void buildName()
        {
            car.setName("626");
        }

        public void buildType()
        {
            car.setType("Sedan");
        }

        public Car getCar()
        {
            return this.car;
        }

        #endregion
    }
}
