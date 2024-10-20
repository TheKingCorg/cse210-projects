public class ListingActivity : Activity
{
    //Member variables
    private int _count;
    private List<string> _prompts;

    //Constructors
    public ListingActivity(string duration) : base (duration, "Listing", "This activity will help you reflect on the good things in your life by\nhaving you list as many things as you can in a certain area.")
    {
        _count = 0;
        _prompts = [
            "\nWho are people that you appreciate?",
            "\nWhat are personal strengths of yours?",
            "\nWho are people that you have helped this week?",
            "\nWhen have you felt the Holy Ghost this month?",
            "\nWho are some of your personal heroes?",
            "\nWhat are small things that brighten your day?",
            "\nWhat are skills you'd like to learn or improve?",
            "\nWhat are places you want to visit in your lifetime?",
            "\nWhat are books that have influenced you?",
            "\nWhat are your favorite childhood memories?",
            "\nWhat are accomplishments you're proud of?",
            "\nWhat are acts of kindness you've witnessed or experienced?",
            "\nWhat are foods that remind you of home?",
            "\nWhat are movies or TV shows that always make you laugh?",
            "\nWhat are challenges you've overcome?",
            "\nWhat are things in nature that you find beautiful?",
            "\nWhat are inventions that have improved your life?",
            "\nWhat are songs that hold special meaning for you?",
            "\nWhat are habits you'd like to develop?",
            "\nWhat are ways you can show gratitude to others?"
        ];
    }

    //Methods
    public void Run(){
        Console.Clear();
        Console.WriteLine($"\n{GetRandomPrompt()}\n\nTake a few seconds to think, then record as many answers as you can.");
        Console.Write("The activity will begin shortly... ");
        ShowCountDown(9);

        List<string> userResponses = GetListFromUser();
        _count = userResponses.Count();

        ShowSpinner(3);
        Console.WriteLine($"Entries recorded: {_count}");

    }
    public string GetRandomPrompt(){
        //This line of code is always funny to me because it made 0 sense before I understood classes
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count);
        return _prompts[randomIndex];
    }
    public List<string> GetListFromUser(){
        List<string> responseList = [];

        //Get starting time and end time
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine("");
        while (DateTime.Now < endTime){
            Console.Write("\n>");
            string entry = Console.ReadLine();
            responseList.Add(entry);
        }
        return responseList;
    }
}