using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class ExoSkeletonRobot : Robot
    {
        AttackAndHeal attackHeal = new AttackAndHeal();
        public ExoSkeletonRobot (string UserName)
        {

            userName = UserName;
            robotHealth = 100;
            attackStrong = "intelligentAttack";
            attackNormal = "longReachSlap";
            attackQuick = "chemWaste";
        }

        public void IntelligentAttack()
        {
            attackHeal.AttackStrong();

        }

        public void LongReachSlap()
        {
            attackHeal.AttackNormal();
        }

        public void ChemWaste()
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

