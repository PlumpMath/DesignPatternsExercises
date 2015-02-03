using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace builder_pattern
{
    interface RobotBuilder
    {
        void buildRobotHead();
        void buildRobotTorso();
        void buildRobotArms();
        void buildRobotLegs();
        Robot getRobot();
    }
}
