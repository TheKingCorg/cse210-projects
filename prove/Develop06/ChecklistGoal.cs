public class ChecklistGoal : Goal
{
    //member variables
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    //Constructor
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base (name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    //Methods
    public override void RecordEvent()
    {
        if (_amountCompleted < _target){
            _amountCompleted += 1;
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target){
            return true;
        } else {
            return false;
        }
    }
    public override string GetDetailsString(){
        return ($"{_shortName}: {_description}\n      {_points}ea. {_bonus} bonus");
    }
    public override string GetStringRepresentation()
    {
        if (_amountCompleted == _target){
            return ($"[{_target}/{_target}] {GetDetailsString()}");
        }else{
            return ($"[{_amountCompleted}/{_target}] {GetDetailsString()}");
        }
    }
}
