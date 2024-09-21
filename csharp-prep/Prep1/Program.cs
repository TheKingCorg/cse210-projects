using System;

class Program
{
    static void Main(string[] args)
    {
        //Just a spacer here
        Console.WriteLine();

        //Gather first name
        Console.Write("Enter your first name: ");
        string fname = Console.ReadLine();
        
        //Gather last name
        Console.Write("Enter your last name: ");
        string lname = Console.ReadLine();
        
        //Display like Bond
        Console.WriteLine();
        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");
    }
}