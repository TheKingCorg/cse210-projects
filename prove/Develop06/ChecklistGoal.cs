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
    public override int RecordEvent()
    {
        if (_amountCompleted == _target){
            int earned = (Int32.Parse(_points) + _bonus);
            Console.WriteLine($"\nCongratulations! You earned {earned} points!");
            return earned;
        }else{
            _amountCompleted += 1;
            int earned = Int32.Parse(_points);
            Console.WriteLine($"\nCongratulations! You earned {earned} points!");
            return earned;
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
        if (IsComplete()){
            return ($"[x] {_shortName} ({_description}) -- completed {_amountCompleted}/{_target}"); 
        }else{
            return ($"[ ] {_shortName} ({_description}) -- completed {_amountCompleted}/{_target}");
        }
    }
    public override string GetStringRepresentation()
    {
        return ($"ChecklistGoal~{_shortName}~{_description}~{_points}~{_bonus}~{_target}~{_amountCompleted}");
    }
}
