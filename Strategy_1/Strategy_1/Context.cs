using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy_1
{
    class Context
    {
        private Strategy _strategy;

        public Context(Strategy strategy)
        {
            this._strategy = strategy;
        }

        public void ContextInterface()
        {
            _strategy.AlgorithmInterface();
        }
    }
}
