using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace builder_pattern
{
    class OldRobotBuilder : RobotBuilder
    {

        private Robot robot;
        public OldRobotBuilder()
        {
            //Tworzenie instancji klacy Robot za każdym razem gdy wywolany jest konstruktor
            this.robot = new Robot();
        }

        #region RobotBuilder Members

        public void buildRobotHead()
        {
            robot.setRobotHead("Thin Head");
        }

        public void buildRobotTorso()
        {
            robot.setRobotTorso("Thin Torso");
        }

        public void buildRobotArms()
        {
            robot.setRobotArms("Blowtorch Arms");
        }

        public void buildRobotLegs()
        {
            robot.setRobotLegs("Roller Skates");
        }

        #endregion

        #region RobotBuilder Members


        public Robot getRobot()
        {
            return this.robot;
        }

        #endregion
    }
}
