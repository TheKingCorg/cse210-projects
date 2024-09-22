using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();

        int favNum = PromptUserNumber();
        
        int theSquare = SquareNumber(favNum);

        DisplayResult(userName, theSquare);
    }

    static void DisplayWelcome()
    {
        //spacers
        Console.WriteLine();
        Console.WriteLine();
        //Displays the message, "Welcome to the Program!"
        Console.WriteLine("\nWelcome to the Program!");
    }

    static string PromptUserName()
    {
        //Asks for and returns the user's name (as a string)
        Console.Write("\nPlease enter your name here: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber ()
    {
        //Asks for and returns the user's favorite number (as an integer)
        Console.Write("\nPlease enter your favorite number here: ");
        string rawNum = Console.ReadLine();
        int favNum = int.Parse(rawNum);
        return favNum;
    }

    static int SquareNumber (int favNum)
    {
        //Accepts an integer as a parameter and returns that number squared (as an integer)
        int favSquared = favNum * favNum;
        return favSquared;
    }

    static void DisplayResult (string name, int square)
    {
        //Accepts the user's name and the squared number and displays them.
        Console.WriteLine($"\nThank you {name}.\nYour favorite number squared is {square}.\n\n");
    }
}