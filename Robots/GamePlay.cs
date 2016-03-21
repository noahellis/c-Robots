using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class GamePlay
    {
        public void Attack()
        {
            string choice;
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Enter 1 for Strong Attack");
            Console.WriteLine("Enter 2 for Normal Attack");
            Console.WriteLine("Enter 3 for Quick Attack");
            Console.WriteLine("Enter 4 for Heal");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine();
                    break;
                case "2":
                    Console.WriteLine();
                    break;
                case "3":
                    Console.WriteLine();
                    break;
                case "4":
                    Console.WriteLine();
                    break;
            }
        }

        public void StrongAttack()
        {
            
        }


            
    }
}
