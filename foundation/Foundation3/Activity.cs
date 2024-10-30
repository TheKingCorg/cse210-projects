public abstract class Activity{
    //member variables
    private DateTime _date;
    private float _duration;      //stored in minutes

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
        return "";
    }
}