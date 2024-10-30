public class SwimmingActivity : Activity
{
    //member variables
    private int _lapsFinsihed;

    //Constructors
    public SwimmingActivity(DateTime date, float duration, int laps) : base(date, duration)
    {
        _lapsFinsihed = laps;
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