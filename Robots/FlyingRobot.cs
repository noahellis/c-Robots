using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class FlyingRobot : Robot
    
    {
        AttackAndHeal attackHeal = new AttackAndHeal();
        public FlyingRobot(string userName)
        {

            
            robotHealth = 100;
            attackStrong = "diveBomb";
            attackNormal = "strafe";
            attackQuick = "fuelDump";

        }

        public void DiveBomb()
        {
            attackHeal.AttackStrong();
                                   
        }

        public void Strafe()
        {
            attackHeal.AttackNormal();
        }

        public void FuelDump()
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
