using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        string scripText = File.ReadLines("SampleScripture.txt").ElementAtOrDefault(1);     //Store the scripture's full text into a string
        Reference targRef = new Reference("Romans", 8, 16, 17);     //Build the reference
        Scripture targScrip = new Scripture(targRef, scripText);    //build the scripture class

        while (!quit && !targScrip.IsCompletelyHidden()) //conditions to keep looping 
        {
            Console.Clear(); //Start each loop with a clear console
            
        } 

    }
}