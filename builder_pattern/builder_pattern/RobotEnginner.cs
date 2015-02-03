using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace builder_pattern
{
    class RobotEnginner
    {
        private RobotBuilder robotBuilder;

        public RobotEnginner(RobotBuilder robotBuilder)
        {
            this.robotBuilder = robotBuilder;
        }

        public Robot getRobot()
        {
            return this.robotBuilder.getRobot();
        }

        public void makerobot()
        {
            this.robotBuilder.buildRobotHead();
            this.robotBuilder.buildRobotTorso();
            this.robotBuilder.buildRobotArms();
            this.robotBuilder.buildRobotLegs();
        }

        public void makerobot(RobotBuilder robotBuilder)
        {
            this.robotBuilder = robotBuilder;
            this.makerobot();
        }
    }
}
