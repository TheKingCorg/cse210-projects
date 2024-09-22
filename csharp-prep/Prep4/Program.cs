using System;

class Program
{
    static void Main(string[] args)
    {
        //opening space for user's sake
        Console.WriteLine();
        Console.WriteLine();

        string userNum; //declare the variable for user entry
        int realNum = 1; //declare int version

        List <int> numList = new List<int> ();

        Console.WriteLine("Welcome to this list analysis program.\nBuild a list of numbers by entering them below. Enter a 0 at any time to quit.");

        do
        {
            Console.Write("\nEnter number here: ");
            userNum = Console.ReadLine(); //User enters number
            realNum = int.Parse(userNum); //String -> int
            numList.Add(realNum); //Stores int in the list
        } while (realNum != 0);

        //Find total, average, and maximum
        int total = 0;
        int average = 0;
        int maximum = 0;
        int listLength = 0;
        foreach (int number in numList)
        {
            total = total + number; //Adds new entry to total
            if (number > maximum)
            {
                maximum = number; //Instantiates new maximum
            }
            listLength ++; //increments list length
        }
        average = total / (listLength-1); //computes average

        //Display results
        Console.WriteLine("\nThank you, here's some info about your list:");
        Console.WriteLine($"Total: {total}\nMean: {average:0}\nMax: {maximum}");
    }
}