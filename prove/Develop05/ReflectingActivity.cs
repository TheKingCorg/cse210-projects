public class ReflectingActivity : Activity
{
    //Member variables
    private List<string> _prompts;
    private List<string> _questions;

    //Constructors
    public ReflectingActivity(string duration) : base(duration, "Reflecting",
    "This activity will help you reflect on times in your life when you have shown strength\nand resilience. This will help you recognize the power you have and how you can use it in other\naspects of your life."){
        _prompts = [
            "\nThink of a time when you stood up for someone else.",
            "\nThink of a time when you did something really difficult.",
            "\nThink of a time when you helped someone in need.",
            "\nThink of a time when you did something truly selfless."
        ];
        _questions = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];
    }

    //Methods
    public void Run(){
        //Give user time to think about prompt
        DisplayPrompt();

        //Loop for the duration
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime){
            DisplayQuestion();
            ShowSpinner(5);
        }
    }
    public string GetRandomPrompt(){
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count);
        return _prompts[randomIndex];
    }
    public string GetRandomQuestion(){
        Random random = new Random();
        int randomIndex = random.Next(0, _questions.Count);
        return _questions[randomIndex];
    }
    public void DisplayPrompt(){
        Console.WriteLine($"\n{GetRandomPrompt()}\nTake your time to think of a good example.");
        Console.Write("The activity will start shortly... ");
        ShowCountDown(9);
        ShowSpinner(3);
    }
    public void DisplayQuestion(){
        Console.WriteLine($"\n{GetRandomQuestion()}");
    }
}