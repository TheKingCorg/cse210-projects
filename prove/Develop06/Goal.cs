public abstract class Goal
{
    //Member variables
    private string _shortName;
    private string _description;
    private string _points;

    //Constructor
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    //Methods
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString(){
        return "";
    }
    public abstract string GetStringRepresentation();
}