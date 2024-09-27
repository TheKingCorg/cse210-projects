//This class has a method that will print out the menu.
public class Menu
{
    //Constructor
    public Menu()
    {
    }

    // A method that displays the menu
    public void PrintMenu()
    {
        //Welcome user, print menu, and ask them to pick an option
        //the actual selecting of an option will be handled in Program.cs
        Console.WriteLine("\n\nWelcome to your Digital Journal!\nPlease select from the options below:");
        Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        Console.Write("Enter your selection here: ");
    }
}