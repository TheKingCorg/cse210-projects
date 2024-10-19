public class Activity
{
    //Member variables
    private int _duration;
    private string _name;
    private string _description;

    //Constructors
    public Activity(string duration, string name, string description){
        _duration = Int32.Parse(duration);
        _name = name;
        _description = description;
    }

    //Methods
    public void ShowCountDown(int seconds){
        for (int i = seconds; i > 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void ShowSpinner (int seconds){
        //Store spinner progression here
        List<string> spinnerStrings = [
            "|o     |",
            "| o    |",
            "|  o   |",
            "|   o  |",
            "|    o |",
            "|     o|",
            "|    o |",
            "|   o  |",
            "|  o   |",
            "| o    |"];

        //Calculate duration
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        //declare increment counter
        int i = 0;

        //Display spinner until endTime
        Console.Write("\nLoading... ");
        while (DateTime.Now < endTime){
            string s = spinnerStrings[i];
            Console.Write(s);
            Thread.Sleep(100);
            Console.Write("\b\b\b\b\b\b\b\b        \b\b\b\b\b\b\b\b");

            i++;

            if (i >= spinnerStrings.Count){
                i = 0;
            }
        }
        //Clear "loading" from console
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b");

    }
    public void DisplayEndingMessage(){
        Console.WriteLine("\nWell done!!");
        ShowSpinner(3);

        Console.WriteLine($"You completed another {_duration} seconds of the {_name} Activity!");
    }
    public void DisplayStartingMessage(){
        Console.WriteLine($"Welcome to the {_name} Activity!\n\n{_description}");
        Console.Write("\nHow long (in seconds) would you like this activity to last? ");
    }
}