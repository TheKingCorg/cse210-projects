//Logs journal entries
using System.Security.Cryptography.X509Certificates;
using System.IO;

public class Journal
{
    //Member variables
    public List<Entry> _entryList = new List<Entry>(); //Creates a composed of entries
    private PromptGenerator _promptGenerator = new PromptGenerator();

    //Constructor
    public Journal()
    {
    }

    // A method that adds an entry to the journal
    public void AddEntry()
    {
        //Build a new entry
        Entry newEntry = new Entry();

        //Create date for entry
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        newEntry._date = dateText;
        
        //Get random prompt
        string newPrompt = _promptGenerator.GetRandomPrompt();
        newEntry._promptText = newPrompt;

        //Invite the user to record their answer to a randomly generated prompt
        Console.WriteLine($"\n{dateText}: {newPrompt}");
        Console.Write(">");
        string userResponse = Console.ReadLine();
        newEntry._entryText = userResponse;

        //Add this new entry to the list
        _entryList.Add(newEntry);
        Console.WriteLine("Response recorded.");
    }

    //Displays all journal entries
    public void DisplayAll()
    {
        foreach(Entry item in _entryList)
        {
            item.EntryDisplay();
        }
    }

    //Saves current journal to a file
    public void SaveToFile()
    {
        Console.Write("Enter the name of the file where your journal is kept: ");
        string fileSource = Console.ReadLine();
    }

    //Loads journal from a provided file
    public void LoadFromFile()
    {
        //Get source file from user
        Console.Write("Enter the name of the file where your journal is kept: ");
        string fileSource = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileSource); //Turns fileSource into an array of each line in the file
    }
}