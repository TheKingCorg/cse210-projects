using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            //Open Menu class for use of PrintMenu method
            Menu menu = new Menu();
            Journal activeJournal = new Journal(); //Open a usable journal class

            //Displays menu and asks for input
            menu.PrintMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    activeJournal.AddEntry();
                    break;
                case "2":
                    activeJournal.DisplayAll();
                    break;
                case "3":
                    activeJournal.LoadFromFile();
                    break;
                case "4":
                    activeJournal.SaveToFile();
                    break;
                case "5":
                    Console.WriteLine("Exiting the program...");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

    }
}