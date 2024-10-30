public class SwimmingActivity : Activity
{
    //member variables
    private int _lapsFinsihed;

    //Constructors
    public SwimmingActivity(DateTime date, float duration, int laps) : base(date, duration)
    {
        _lapsFinsihed = laps;
        _type = "Swimming";
    }

    //Methods
    public override float GetDistance()
    {
        //return (distance) miles
        float kiloDist = (_lapsFinsihed * 50)/1000;
        float distance = (kiloDist * 0.62F);
        return distance;
    }
    public override float GetPace()
    {
        //return (pace) min per mile
        float distance = GetDistance();
        float pace = (_duration / distance);
        return pace;
    }
    public override float GetSpeed()
    {
        //return speed (mph)
        float speed = (GetDistance() / (_duration / 60));
        return speed;
    }
}