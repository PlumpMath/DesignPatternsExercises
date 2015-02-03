using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnamyAdapter
{
    public interface EnemyAttacker
    {
        void fireWeapon();
        void driveForward();
        void assignDriver(String driverName);
    }
}
