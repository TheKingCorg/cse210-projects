public class SimpleGoal : Goal
{
    //Member variables
    private bool _isComplete;

    //Constructors
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
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
        if (_isComplete){
            return ($"[x] {GetDetailsString()}");
        }else{
            return ($"[ ] {GetDetailsString()}");
        }
    }

}
