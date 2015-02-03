using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace builder_pattern
{
    interface RobotPlan
    {
        void setRobotHead(String head);
        void setRobotTorso(String torso);
        void setRobotArms(String arms);
        void setRobotLegs(String legs);
        String getRobotHead();
        String getRobotTorso();
        String getRobotArms();
        String getRobotLegs();
    }
}
