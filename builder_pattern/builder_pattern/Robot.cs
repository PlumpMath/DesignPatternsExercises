using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace builder_pattern
{
    class Robot : RobotPlan
    {
        private String robotHead;
        private String robotTorso;
        private String robotArms;
        private String robotLegs;

        #region RobotPlan Members

        public void setRobotHead(string head)
        {
            robotHead = head;
        }

        public void setRobotTorso(string torso)
        {
            robotTorso = torso;
        }

        public void setRobotArms(string arms)
        {
            robotArms = arms;
        }

        public void setRobotLegs(string legs)
        {
            robotLegs = legs;
        }

        #endregion

        #region RobotPlan Members


        public string getRobotHead()
        {
            return this.robotHead;
        }

        public string getRobotTorso()
        {
            return this.robotTorso;
        }

        public string getRobotArms()
        {
            return this.robotArms;
        }

        public string getRobotLegs()
        {
            return this.robotLegs;
        }

        #endregion
    }
}
