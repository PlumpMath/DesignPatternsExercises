using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter_1
{
    class Adapter : Target
    {
        private Adaptee _adaptee = new Adaptee();

        public override void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
}
