using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment hw1 = new Assignment("Tommy", "Digital Systems"); 
        Console.WriteLine(hw1.GetSummary());

        MathAssignment hw2 = new MathAssignment("Billison", "Engineering Stats","5.2, The Normal Distribution","1-4, 8, 12, 15-21");
        Console.WriteLine(hw2.GetSummary());
        Console.WriteLine(hw2.GetHomeWorkList());

        WritingAssignment hw3 = new WritingAssignment("Sarangelique","English Lit","Allusions to Tom Sawyer in Modern Media");
        Console.WriteLine(hw3.GetSummary());
        Console.WriteLine(hw3.GetWritingInformation());
    }
}