public class EternalGoal : Goal
{
    //Member variables
    private int _timesComplete;

    //Constructors
    public EternalGoal (string name, string description, string points) : base (name, description, points)
    {
        _timesComplete = 0;
    }

    //Methods
    public override int RecordEvent()
    {
        _timesComplete += 1;
        Console.WriteLine($"\nCongratulations, you earned {_points} points!");
        return Int32.Parse(_points);
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return ($"[ ] {GetDetailsString()}\nCompleted {_timesComplete} times for {_timesComplete * Int32.Parse(_points)} points.");
    }
}
