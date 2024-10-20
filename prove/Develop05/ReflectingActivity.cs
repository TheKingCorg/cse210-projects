public class ReflectingActivity : Activity
{
    //Member variables
    private List<string> _prompts;
    private List<string> _questions;

    //Constructors
    public ReflectingActivity(string duration) : base(duration, "Reflecting",
    "This activity will help you reflect on times in your life when you have shown strength\nand resilience. This will help you recognize the power you have and how you can use it in other\naspects of your life."){
        _prompts = [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
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
        //instantiate a list of indexes to track used questions
        List<int> questionIndexes = [];
        int starterIndex = 0;
        foreach (string q in _questions){
            questionIndexes.Add(starterIndex);
            starterIndex ++;
        }

        //Get Random
        Random random = new Random();

        //Give user time to think about prompt
        DisplayPrompt();

        //Loop for the duration
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime){
            //get a random index location from inside the questionIndexes list
            int randomIndex = random.Next(0, questionIndexes.Count);
            //Look at the randomly indexed location of questionIndexes and get that question from the question list
            GetRandomQuestion(questionIndexes[randomIndex]);
            //Remove that specific question index from questionIndexes using the randomIndex
            questionIndexes.RemoveAt(randomIndex);
        }
    }
    public string GetRandomPrompt(){
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count);
        return _prompts[randomIndex];
    }
    public string GetRandomQuestion(int i){
        return _questions[i];
    }
    public void DisplayPrompt(){
        Console.WriteLine($"\n{GetRandomPrompt()}\nTake your time to think of a good example.");
        Console.Write("The activity will start shortly... ");
        ShowCountDown(15);
    }
    public void DisplayQuestion(int i){
        Console.WriteLine($"\n{GetRandomQuestion(i)}");
    }
}