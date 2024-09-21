using System;

class Program
{
    static void Main(string[] args)
    {
        //Opening Spacer
        Console.WriteLine();
        Console.WriteLine();

        //Take user input
        Console.WriteLine("With this program, you can determine your letter grade.");
        Console.Write("Please enter your grade as a percentage: ");
        string userValue = Console.ReadLine();
        float percentage = float.Parse(userValue);

        string letterGrade = "";

        //Determine letter grade
        if (percentage >= 90)
        {
            letterGrade = "A";
        }        
        else if (percentage >= 80)
        {
            letterGrade = "B";
        }
        else if (percentage >= 70)
        {
            letterGrade = "C";
        }
        else if (percentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        
        //Display result
        Console.WriteLine($"\nYour grade is a {letterGrade}.");

        if (percentage >= 70)
        {
            Console.WriteLine("You Passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass, better luck next time!");
        }

        //Closing spacers
        Console.WriteLine("");
        Console.WriteLine("");
    }
}