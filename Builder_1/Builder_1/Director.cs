using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder_1
{
    class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
