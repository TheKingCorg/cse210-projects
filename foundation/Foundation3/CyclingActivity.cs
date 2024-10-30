public class CyclingActivity : Activity
{
    //member variables 
    private float _speed;

    //Constructor
    public CyclingActivity(DateTime date, float duration, float speed) : base(date, duration)
    {
        _speed = speed;
        _type = "Cycling";
    }

    //Methods
    public override float GetDistance()
    {
        //return (distance) miles
        float distance = (_speed * (_duration / 60));
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
        return _speed;
    }
}