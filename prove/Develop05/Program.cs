using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        Activity sample = new Activity("30","sample","sample activity for method testing");

        sample.DisplayEndingMessage();
    }
}