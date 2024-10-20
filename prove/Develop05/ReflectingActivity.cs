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
            "\nThink of a time when you did something truly selfless.",
            "\nThink of a time when you overcame a significant fear.",
            "\nRecall a moment when you had to make a difficult ethical decision.",
            "\nRemember an instance when you learned an important lesson from failure.",
            "\nThink of a time when you showed kindness to a stranger.",
            "\nReflect on a situation where you had to adapt to unexpected change.",
            "\nConsider a moment when you felt truly proud of yourself.",
            "\nThink of a time when you had to apologize and make amends.",
            "\nRecall an experience that changed your perspective on an important issue.",
            "\nRemember a time when you stepped out of your comfort zone.",
            "\nThink of an instance when you positively influenced someone's life.",
            "\nThink of a time when you had to apologize.",
            "\nThink of a time when you received unexpected kindness.",
            "\nThink of a time when you had to make a tough decision.",
            "\nThink of a time when you experienced failure.",
            "\nThink of a time when you had to compromise or collaborate with others."
        ];
        _questions = [
            "\nWhy was this experience meaningful to you?",
            "\nHave you ever done anything like this before?",
            "\nHow did you get started?",
            "\nHow did you feel when it was complete?",
            "\nWhat made this time different than other times when you were not as successful?",
            "\nWhat is your favorite thing about this experience?",
            "\nWhat could you learn from this experience that applies to other situations?",
            "\nWhat did you learn about yourself through this experience?",
            "\nHow can you keep this experience in mind in the future?",
            "\nWhy did you do what you did?",
            "\nHow did this experience make you feel?",
            "\nWhat was the most challenging part of this situation?",
            "\nWhat did you learn from this experience?",
            "\nHow did this event change you or your perspective?",
            "\nWhat would you do differently if faced with a similar situation now?",
            "\nWho else was involved, and how did they influence the outcome?",
            "\nWhat values or beliefs guided your actions in this moment?",
            "\nWhat surprised you most about this experience?",
            "\nHow did this event impact your relationships with others?",
            "\nWhat skills or strengths did you discover about yourself?",
            "\nWhat doubts or fears did you have to overcome?",
            "\nHow did you handle any emotions that arose during this time?",
            "\nWhat support did you receive or wish you had received?",
            "\nHow has this experience shaped your future decisions or goals?",
            "\nWhat assumptions did you challenge during this experience?",
            "\nHow did this situation test your personal boundaries or limits?",
            "\nWhat unexpected consequences arose from your actions?",
            "\nHow did this experience align or conflict with your personal values?",
            "\nWhat role did intuition or gut feeling play in your decisions?",
            "\nHow did this experience affect your self-perception or identity?",
            "\nWhat resources or skills do you wish you had in that moment?",
            "\nHow did time pressure or external factors influence your choices?",
            "\nWhat aspects of the situation were within or beyond your control?",
            "\nHow has this experience influenced your long-term goals or life path?"
        ];
    }

    //Methods
    public void Run(){
        //Give user time to think about prompt
        Console.Clear();
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