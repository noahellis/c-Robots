using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class AttackAndHeal
    {
        public string attackStrong;
        public string attackNormal;
        public string attackQuick;
        AttackPercent getPercent = new AttackPercent();
        
        public void AttackStrong()
        {
            Console.WriteLine("You attempted to use " + attackStrong + "!!");
            getPercent.AttackSuccess60();
            //return health from enemy? 
        
        }

        public void AttackNormal()
        {
            Console.WriteLine("You attempted to use " + attackNormal + "!!");
            getPercent.AttackSuccess80();
            //return health from enemy?
        }

        public void AttackQuick()
        {
            Console.WriteLine("You attempted to use " + attackQuick + "!!");
            getPercent.AttackSuccess90();
            //return health from enemy?
        }

        public void HealRobot()
        {
            Console.WriteLine("You attempted to use Heal!!");
            getPercent.AttackSuccess90();

        }
         
    }
}
