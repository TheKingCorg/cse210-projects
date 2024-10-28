public class SimpleGoal : Goal
{
    //Member variables
    private bool _isComplete;

    //Constructors
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public SimpleGoal(string name, string description, string points, string complete) : base(name, description, points)
    {
        //handles passing in the complete bool for reading a file
        if (complete == "true"){
            _isComplete = true;
        }else{
            _isComplete = false;
        }
    }

    //Methods
    public override int RecordEvent(){
        _isComplete = true;
        Console.WriteLine($"\nCongratulations, you earned {_points} points!");
        return Int32.Parse(_points);
    }
    public override bool IsComplete(){
        return _isComplete;
    }
    public override string GetStringRepresentation(){
        return ($"SimpleGoal~{_shortName}~{_description}~{_points}~{IsComplete()}");
    }

}
