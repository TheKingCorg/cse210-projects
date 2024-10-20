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
        Thread.Sleep(1500);

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
                    BreathingActivity breathActivity = new BreathingActivity(desiredTime);
                    breathActivity.Run();

                    //Ending message
                    breathActivity.ShowSpinner(4);
                    Console.Clear();
                    breathActivity.DisplayEndingMessage();
                    breathActivity.ShowSpinner(4);
                    break;

                case "2":
                    //temporary class for display use
                    ReflectingActivity tempReflect = new ReflectingActivity("0");
                    tempReflect.DisplayStartingMessage();
                    desiredTime = Console.ReadLine();

                    //Make the actual Reflecting Activity desired
                    ReflectingActivity reflectActivity = new ReflectingActivity(desiredTime);
                    reflectActivity.Run();

                    //Ending message
                    reflectActivity.ShowSpinner(4);
                    Console.Clear();
                    reflectActivity.DisplayEndingMessage();
                    reflectActivity.ShowSpinner(4);
                    break;
                    
                case "3":
                    //temporary class for display use
                    ListingActivity tempList = new ListingActivity("0");
                    tempList.DisplayStartingMessage();
                    desiredTime = Console.ReadLine();

                    //Make the actual Listing Activity desired
                    ListingActivity listActivity = new ListingActivity(desiredTime);
                    listActivity.Run();

                    //Ending message
                    listActivity.ShowSpinner(4);
                    Console.Clear();
                    listActivity.DisplayEndingMessage();
                    listActivity.ShowSpinner(4);
                    break;

                default: 
                    break;
            }
            //Wipe screen
            Console.Clear();
        }
    }
}