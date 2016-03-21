using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class LegionRobot : Robot
    {
        AttackAndHeal attackHeal = new AttackAndHeal();

        public LegionRobot (string UserName)
        {

            userName = UserName;
            robotHealth = 100;
            attackStrong = "overwhelm";
            attackNormal = "swarm";
            attackQuick = "nanoBotPurge";

        }

        public void Overwhelm()
        {
            attackHeal.AttackStrong();
        }

        public void Swarm()
        {
            attackHeal.AttackNormal();
        }

        public void NanoBotPurge()
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
