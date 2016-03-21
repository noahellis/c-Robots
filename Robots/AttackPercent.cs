using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class AttackPercent : Robot
    {
       public bool sixty;
       public bool eighty;
       public bool ninety;
       public bool heal;

        Random random = new Random();
        

        public bool AttackSuccess60()
        { 
            
        
            int sixtyPercent = random.Next(0, 10);
            if (sixtyPercent <= 6)
            {
                sixty = true;
                Console.WriteLine("Your attack was successful!");
                //take 30 health

            }
            else if (sixtyPercent >= 7)
            {
                sixty = false;
                Console.WriteLine("Your attack failed!");
                //do nothing
            }
            return sixty;

        }

        public bool AttackSuccess80()
        {
            

            int eightyPercent = random.Next(0, 10);

            if (eightyPercent <= 7)
            {
                eighty = true;
                Console.WriteLine("Your attack was successful!");
                //take 20 health

            }
            else if (eightyPercent >= 8)
            {
                eighty = false;
                Console.WriteLine("Your attack failed!");
                // do nothing
            }
            return eighty;
        }

        public bool AttackSuccess90()
        {
           

            int ninetyPercent = random.Next(0, 10);

            if (ninetyPercent <=9)
            {
                ninety = true;
                Console.WriteLine("Your attack was successful!");
                //take 10 health
            }
            else if (ninetyPercent >=10)
            {
                ninety = false;
                Console.WriteLine("Your attack failed!");
                //do nothing
            }

            return ninety;
        }

        public int HealSuccess90()
        {
            int ninetyPercentHeal = random.Next(0, 10);
            

            if (ninetyPercentHeal <10)
            {
                heal = true;
                Console.WriteLine("Your Heal attempt was successful");
                robotHealth += 15;
                Console.WriteLine("Your health is currently " + robotHealth);
                
            }
            else if (ninetyPercentHeal >= 10)
            {
                heal = false;
                Console.WriteLine("Your Heal attempt was not successful");
            }
            return robotHealth;
        }
    }
}
