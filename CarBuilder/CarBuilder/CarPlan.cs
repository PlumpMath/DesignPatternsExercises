using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarBuilder
{
    interface CarPlan
    {
        void setMaker(String maker);
        void setName(String name);
        void setType(String type);

        String getMaker();
        String getName();
        String getType();        
    }
}
