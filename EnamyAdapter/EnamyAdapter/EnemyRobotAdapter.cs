using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnamyAdapter
{
    class EnemyRobotAdapter : EnemyAttacker
    {

        EnemyRobot theRobot;
        public EnemyRobotAdapter(EnemyRobot newRobot)
        {
            theRobot = new EnemyRobot();
        }

        public void fireWeapon()
        {
            theRobot.smashWithHands();
        }

        public void driveForward()
        {
            theRobot.walkForward();
        }

        public void assignDriver(string driverName)
        {
            theRobot.reactToHuman(driverName);
        }

    }
}
