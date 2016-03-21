using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class AnimalRobot : Robot
    {
        AttackAndHeal attackHeal = new AttackAndHeal();
        public AnimalRobot(string UserName)
        {

            userName = UserName;
            robotHealth = 100;
            attackStrong = "claw";
            attackNormal = "bite";
            attackQuick = "pounce";
        }

        public void Claw()
        {
            attackHeal.AttackStrong();

        }

        public void Bite()
        {
            attackHeal.AttackNormal();
        }

        public void Pounce()
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
