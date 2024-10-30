public abstract class Activity{
    //member variables
    private DateTime _date;
    protected float _duration;      //stored in minutes
    protected string _type;

    //Constructors
    public Activity(DateTime date, float duration){
        _date = date;
        _duration = duration;
    }

    //Methods
    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();
    public virtual string GetStringRepresentation(){
        return ($"{_date} {_type} ({_duration} min)- Distance {GetDistance().ToString("0.0")} miles, Speed {GetSpeed().ToString("0.0")} mph, Pace: {GetPace().ToString("0.0")} min per mile.");
    }
}