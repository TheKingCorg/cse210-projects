public class RunningActivity : Activity
{
    //member variables 
    private float _distance;

    //Constructors
    public RunningActivity(DateTime date, float duration, float distance) : base(date, duration)
    {
        _distance = distance;
        _type = "Running";
    }

    //Methods
    public override float GetDistance()
    {
        //return (distance) miles
        return _distance;
    }
    public override float GetPace()
    {
        //return (pace) min per mile
        float pace = (_duration / _distance);
        return pace;
    }
    public override float GetSpeed()
    {
        //return speed (mph)
        float speed = (_distance / (_duration / 60));
        return speed;
    }
}