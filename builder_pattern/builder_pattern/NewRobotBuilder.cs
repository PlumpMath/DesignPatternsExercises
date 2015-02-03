using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace builder_pattern
{
    class NewRobotBuilder : RobotBuilder
    {
        private Robot robot;
        public NewRobotBuilder()
        {
            this.robot = new Robot();
        }
        
        #region RobotBuilder Members

        public void buildRobotHead()
        {
            robot.setRobotHead("New Head");
        }

        public void buildRobotTorso()
        {
            robot.setRobotTorso("New Torso");
        }

        public void buildRobotArms()
        {
            robot.setRobotArms("New Arms");
        }

        public void buildRobotLegs()
        {
            robot.setRobotLegs("New Legs");
        }

        public Robot getRobot()
        {
            return this.robot;
        }

        #endregion
    }
}
