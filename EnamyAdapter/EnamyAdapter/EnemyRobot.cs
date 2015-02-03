using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnamyAdapter
{
    class EnemyRobot
    {
        Random generator = new Random();

        public void smashWithHands()
        {
            int attackDamage = generator.Next(10) + 1;
            Console.WriteLine("Enemy Robot Causes " + attackDamage + " Damage With Its Hands");
        }

        public void walkForward()
        {
            int movement = generator.Next(5) + 1;
            Console.WriteLine("Enemy Robot Walks Forward " + movement + " Spaces");
        }

        public void reactToHuman(String driverName)
        {
            Console.WriteLine("Enemy Robot Tramps on " + driverName);
        }
    }
}
