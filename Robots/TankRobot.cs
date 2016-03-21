using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class TankRobot : Robot
    {
        AttackAndHeal attackHeal = new AttackAndHeal();
        public TankRobot (string UserName)
        {
            userName = UserName;
            robotHealth = 100;
            attackStrong = "rollOver";
            attackNormal = "cannon";
            attackQuick = "fiftyCal";
        }

        public void RollOver()
        {
            attackHeal.AttackStrong();
        }

        public void Cannon()
        {
            attackHeal.AttackNormal();
        }

        public void FiftyCal()
        {
            attackHeal.AttackQuick();
        }

        public int Heal()
        {
            attackHeal.HealRobot();
            return robotHealth;
        }

    }
}
