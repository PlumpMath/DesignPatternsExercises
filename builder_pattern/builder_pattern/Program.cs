using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace builder_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RobotBuilder oldStyleRobot = new OldRobotBuilder();
            RobotBuilder newStyleRobot = new NewRobotBuilder();
            RobotEnginner enginner = new RobotEnginner(oldStyleRobot);
            enginner.makerobot();

            Robot firstRobot = enginner.getRobot();

            
            Console.WriteLine("Robot Head Type: " + firstRobot.getRobotHead());
            Console.WriteLine("Robot Torso Type: " + firstRobot.getRobotTorso());
            Console.WriteLine("Robot Arms Type: " + firstRobot.getRobotArms());
            Console.WriteLine("Robot Legs Type: " + firstRobot.getRobotLegs());

            enginner.makerobot(newStyleRobot);
            Robot secondRobot = enginner.getRobot();

            Console.WriteLine("");
            Console.WriteLine("Robot Head Type: " + secondRobot.getRobotHead());
            Console.WriteLine("Robot Torso Type: " + secondRobot.getRobotTorso());
            Console.WriteLine("Robot Arms Type: " + secondRobot.getRobotArms());
            Console.WriteLine("Robot Legs Type: " + secondRobot.getRobotLegs());

            Console.ReadKey();
        }
    }
}
