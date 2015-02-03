using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter_1
{
    class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called target Request()");
        }
    }
}
