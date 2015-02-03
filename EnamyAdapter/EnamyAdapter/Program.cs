using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnamyAdapter
{
    class Program
    {
        static void Main(string[] args)
        {           
            
            EnemyTank tank = new EnemyTank();
            EnemyAttacker attacker = tank;
            //tank.assignDriver("Janusz");
            //tank.fireWeapon();
            //tank.driveForward();
            attacker.assignDriver("Mark");
            attacker.fireWeapon();
            attacker.driveForward();

            Console.WriteLine();

            EnemyRobot robot = new EnemyRobot();
                        
            robot.reactToHuman("Tadek");
            robot.smashWithHands();
            robot.walkForward();

            Console.WriteLine();

            EnemyRobotAdapter robotAdapter = new EnemyRobotAdapter(robot);

            attacker = robotAdapter;
            attacker.assignDriver("Luck");
            attacker.fireWeapon();
            attacker.driveForward();

            Console.ReadKey();

        }
    }
}
