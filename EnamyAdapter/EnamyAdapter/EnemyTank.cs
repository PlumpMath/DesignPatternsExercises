using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnamyAdapter
{
    class EnemyTank : EnemyAttacker
    {
        Random generator = new Random();

        #region EnamyAttacker Members

        public void fireWeapon()
        {
            int attackDemage = generator.Next(10) + 1;
            Console.WriteLine("Enemy Tank Does " + attackDemage + " Damage");
        }

        public void driveForward()
        {
            int movement = generator.Next(5) + 1;
            Console.WriteLine("Enemy Tank moves " + movement + " Spaces");
        }

        public void assignDriver(String driverName)
        {
            Console.WriteLine(driverName + " is driving the tank");
        }

        #endregion
    }
}
