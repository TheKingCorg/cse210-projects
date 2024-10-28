public abstract class Goal
{
    //Member variables
    protected string _shortName;
    protected string _description;
    protected string _points;

    //Constructor
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    //Methods
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString(){
        if (IsComplete()){
            return ($"[x] {_shortName} ({_description})"); 
        }else{
            return ($"[ ] {_shortName} ({_description})");
        }
    }
    public abstract string GetStringRepresentation();
    public string GetNameString(){
        return _shortName;
    }
}