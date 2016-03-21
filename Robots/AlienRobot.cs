using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class AlienRobot : Robot
    {
        AttackAndHeal attackHeal = new AttackAndHeal();
        public AlienRobot (string UserName)
        {

            userName = UserName;
            robotHealth = 100;
            attackStrong = "cowLaunch";
            attackNormal = "laserBeam";
            attackQuick = "transporter";
        }

        public void CowLaunch()
        {
            attackHeal.AttackStrong();

        }

        public void LaserBeam()
        {
            attackHeal.AttackNormal();
        }

        public void Transporter()
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

