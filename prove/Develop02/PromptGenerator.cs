//Stores and will supply random prompts
public class PromptGenerator
{
    //Member variables
    public List<string> _promptList = new List<string>(); //Creates a list to hold prompts
    private Random _random = new Random();

    //Constructor
    public PromptGenerator()
    {
    //Store prompts
    _promptList.Add("In what ways did I succeed today?");
    _promptList.Add("What was the most interesting interaction I had today?");
    _promptList.Add("What brought me happiness today?");
    _promptList.Add("What emotion did I feel most today?");
    _promptList.Add("What part of today would I do-over if I could?");
    _promptList.Add("What places did I visit today?");
    _promptList.Add("How are my family and friends doing?");
    _promptList.Add("What am I grateful for?");
    _promptList.Add("If I had an extra hour today, how would I have spent it?");
    _promptList.Add("What do I want to remember from today five years from now?");
    }

    // A method that provides a random journal prompt
    public string GetRandomPrompt()
    {
        int randomIndex = _random.Next(0, _promptList.Count);
        return _promptList[randomIndex];
    }
}