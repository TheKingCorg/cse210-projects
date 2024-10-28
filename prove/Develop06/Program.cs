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
                    break;
                case "2":
                    //List goal details
                    manager.ListGoalDetails();
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                default:
                    //any value other than 1-5 will go back to the top
                    //if menu choice has been updated to 6, program will quit
                    break;
            }
        }

    }
}