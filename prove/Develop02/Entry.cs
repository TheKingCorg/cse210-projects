//This class functions as a journal entry to be filled by the user
public class Entry
{
    //Member variables
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";

    //Constructor
    public Entry()
    {
    }

    // A method that displays the person's journal entries
    public void EntryDisplay()
    {
        Console.WriteLine($"\n{_date}: {_promptText}\n{_entryText}");
    }
}