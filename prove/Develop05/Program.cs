using System;

class Program
{
    static void Main(string[] args)
    {
        string menu = ("\nMenu options\n  1. Breathing Activity\n  2. Reflecting Activity\n  3. Listing Activity\n  4. Quit");
        string userChoice = "0";

        //Program setup
        Console.Clear();
        Console.WriteLine("Welcome to the Corg&Co mindfulness application!");
        Thread.Sleep(3000);

        while (userChoice != "4"){
            Console.WriteLine(menu);
            Console.Write("\nEnter your selection from the above menu: ");
            userChoice = Console.ReadLine();
            string desiredTime = "";

            switch (userChoice){
                case "1":
                    //temporary class for display use
                    BreathingActivity tempBreath = new BreathingActivity("0");
                    tempBreath.DisplayStartingMessage();
                    desiredTime = Console.ReadLine();

                    //Make the actual breathing Activity desired
                    BreathingActivity BreathActivity = new BreathingActivity(desiredTime);
                    BreathActivity.Run();

                    //Ending message
                    BreathActivity.ShowSpinner(4);
                    BreathActivity.DisplayEndingMessage();
                    break;

                case "2":
                    Console.Write("\nHow long (in seconds) would you like this activity to last? ");
                    desiredTime = Console.ReadLine();
                    break;
                case "3":
                    Console.Write("\nHow long (in seconds) would you like this activity to last? ");
                    desiredTime = Console.ReadLine();
                    break;
            }
            
        }
    }
}