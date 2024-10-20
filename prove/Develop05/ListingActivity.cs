public class ListingActivity : Activity
{
    //Member variables
    private int _count;
    private List<string> _prompts;

    //Constructors
    public ListingActivity(string duration) : base (duration, "Listing", "This activity will help you reflect on the good things in your life by\nhaving you list as many things as you can in a certain area.")
    {
        _count = 0;
        _prompts = [];
    }

    //Methods
    public void Run(){

    }
    public string GetRandomPrompt(){
        return "";
    }
    public List<string> GetListFromUser(){
        return [];
    }
}