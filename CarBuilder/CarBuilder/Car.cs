using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarBuilder
{
    class Car : CarPlan
    {
        String maker;
        String name;
        String type;
        
        #region CarPlan Members

        public void setMaker(string maker)
        {
            this.maker = maker;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public string getMaker()
        {
            return this.maker;
        }

        public string getName()
        {
            return this.name;
        }

        public string getType()
        {
            return this.type;
        }

        #endregion
    }
}
