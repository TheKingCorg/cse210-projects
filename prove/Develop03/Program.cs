using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        string userEntry;
        bool quit = false;
        string scripText = File.ReadLines("SampleScripture.txt").ElementAtOrDefault(1);     //Store the scripture's full text into a string
        Reference targRef = new Reference("Romans", 8, 16, 17);     //Build the reference
        Scripture targScrip = new Scripture(targRef, scripText);    //build the scripture class

        Console.Clear(); //Start each loop with a clear console
        Console.WriteLine(targScrip.GetDisplayText()); //Use the scripture class's GetDisplayText method to show the scripture
        Console.Write("\nHit enter to continue or type 'quit' to quit.\n>"); //prompt user input
        userEntry = Console.ReadLine();

        //update quit
        if (userEntry == "quit")
        {
            quit = true;
        }
        
        while (!quit && !targScrip.IsCompletelyHidden()) //conditions to keep looping
        {
            targScrip.HideRandomWords(3);

            Console.Clear(); //Start each loop with a clear console
            Console.WriteLine(targScrip.GetDisplayText()); //Use the scripture class's GetDisplayText method to show the scripture
            Console.Write("\nHit enter to continue or type 'quit' to quit.\n>"); //prompt user input
            userEntry = Console.ReadLine(); 

            //update quit
            if (userEntry == "quit")
            {
                quit = true;
            }
        } 
    }
}