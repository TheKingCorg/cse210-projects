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
    public override void RecordEvent(){
        _isComplete = true;
    }
    public override bool IsComplete(){
        return _isComplete;
    }
    public override string GetStringRepresentation(){
        if (_isComplete){
            return ($"{_shortName}\n{_description}         [x]");
        }else{
            return ($"{_shortName}\n{_description}         [ ]");
        }
    }

}
