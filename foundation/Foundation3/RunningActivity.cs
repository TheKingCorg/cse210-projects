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
        throw new NotImplementedException();
    }
    public override float GetPace()
    {
        throw new NotImplementedException();
    }
    public override float GetSpeed()
    {
        throw new NotImplementedException();
    }
}