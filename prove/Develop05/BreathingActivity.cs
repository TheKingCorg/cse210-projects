public class BreathingActivity : Activity
{
    //Member variables
    //none

    //Constructors
    public BreathingActivity(string duration) : base (duration, "Breathing", 
    "This activity will help you relax by walking your through breathing in and out slowly.\nClear your mind and focus on your breathing.")
    { //This constructor accepts a duration but passes a preset name and definition to its parent
      //class "Activity"
      //No other action is required from this constructor
    }

    //Member methods
    public void Run(){
        Console.WriteLine("\nGet ready for the breath activity.");
        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime);
            Console.Write("\nBreath in...");
            ShowCountDown(7);
            Console.Write("Breathe out...");
            ShowCountDown(5);
    }
}