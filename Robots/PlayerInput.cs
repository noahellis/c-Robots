using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class PlayerInput
        
    {
        
       public List<Robot> turnList = new List<Robot>();
        
        public int playerNumber;
       
        

        public int inputPlayerNumber()
        {
            Console.WriteLine("Please enter the number of Players (max of 4)");
            playerNumber = int.Parse(Console.ReadLine());
            if (playerNumber >0 && playerNumber <=4) 
            {
                inputPlayerName();
            }
           else 
            {
             Console.WriteLine("Inavlid Entry, please try again.");
             inputPlayerNumber();
            }
            
            return playerNumber;
            
            
        }

        public void inputPlayerName()
        {
            
            List <Robot> playNum = new List<Robot>(playerNumber);
            for (int numPlayers =0; numPlayers < playerNumber; numPlayers++)
            {
                playNum.Add (new Robot());
            }
            foreach (Robot numberPlayers in playNum)                

            {                
                Console.WriteLine("Please enter the next player's name: ");
                numberPlayers.userName =Console.ReadLine();
                SelectRobotType();
                        
            }
            PrintUserInfo();
        }

        public void SelectRobotType()
        {
            Robot robotChoice = new Robot();
            string choice;
            Console.WriteLine("Please select the type of Robot you would like.");
            Console.WriteLine("Enter 1 for Flying Robot");
            Console.WriteLine("Enter 2 for Tank Robot");
            Console.WriteLine("Enter 3 for Animal Robot");
            Console.WriteLine("Enter 4 for ExoSkeleton Robot");
            Console.WriteLine("Enter 5 for Alien Robot");
            Console.WriteLine("Enter 6 for a Legion of nanoRobots");
            choice = Console.ReadLine();

            

            switch (choice)
            {
                case "1":

                    Console.WriteLine("You have chosen the Flying Robot");
                    FlyingRobot createFlying = new FlyingRobot(robotChoice.userName);
                    turnList.Add (new FlyingRobot(robotChoice.userName));
                    createFlying.robotType = "FlyingRobot";
                    break;

                case "2":

                    Console.WriteLine("You have chosen the Tank Robot");
                    TankRobot createTank = new TankRobot(robotChoice.userName);
                    turnList.Add(new TankRobot(robotChoice.userName));
                    createTank.robotType = "TankRobot";
                    break;

                case "3":

                   Console.WriteLine("You have chosen the Animal Robot");
                   AnimalRobot createAnimal = new AnimalRobot(robotChoice.userName);
                   turnList.Add(new AnimalRobot(robotChoice.userName));
                    createAnimal.robotType = "AnimalRobot";
                   break;

                case "4":

                    Console.WriteLine("You have chosen the ExoSkeleton Robot");
                    ExoSkeletonRobot createExo = new ExoSkeletonRobot(robotChoice.userName);
                    turnList.Add(new ExoSkeletonRobot(robotChoice.userName));
                    createExo.robotType = "ExoSkeletonRobot";
                    break;

                case "5":

                    Console.WriteLine("You have chosen the Alien Robot");
                    AlienRobot createAlien = new AlienRobot(robotChoice.userName);
                    turnList.Add(new AlienRobot(robotChoice.userName));
                    createAlien.robotType = "AlienRobot";
                    break;

                case "6":

                    Console.WriteLine("You have chosen the Legion of nanoRobots");
                    LegionRobot createLegion = new LegionRobot(robotChoice.userName);
                    turnList.Add(new LegionRobot(robotChoice.userName));
                    createLegion.robotType = "LegionRobot";
                    break;

                default:
                    
                    Console.WriteLine("You have made an invalid selection. Please try again");
                    SelectRobotType();
                    break;
            }
            
        }

        public void PrintUserInfo()
        {
            
            foreach (Robot user in turnList)
            {
                Console.WriteLine(user.userName + " has selected " + user.robotType);
            }
        }

        public void takeTurns()
        {             

            for (int playTurn = 0; playTurn < playerNumber; playTurn++) ;
            

        }
    }
}
