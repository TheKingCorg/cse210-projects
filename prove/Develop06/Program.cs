using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Create a goal manager
        GoalManager manager = new GoalManager();

        //open user choice variable for use
        string menuChoice = "";

        //Start program and loop until menuChoice = 6
        while (menuChoice != "6"){
            manager.Start();
            menuChoice = Console.ReadLine();
            
            //Switcher for function execution
            switch (menuChoice){
                case "1":
                    //Create new goal
                    manager.CreateGoal();
                    break;

                case "2":
                    //List goal details
                    manager.ListGoalDetails();
                    Console.Write("\nHit enter to continue: ");
                    Console.ReadLine();
                    break;

                case "3":
                    //Save goals to a file
                    manager.SaveGoals();
                    break;

                case "4":
                    //Load goals from a file
                    manager.LoadGoals();
                    break;

                case "5":
                    //Record event
                    manager.RecordEvent();
                    break;

                case "6":
                    //if menu choice has been updated to 6, program will quit
                    break;
                    
                default:
                    //any value other than 1-6 will go back to the top
                    Console.WriteLine("\nEnter a valid selection.");
                    Thread.Sleep(2000);
                    break;
            }
        }

    }
}