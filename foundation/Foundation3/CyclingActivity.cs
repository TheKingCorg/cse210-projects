public class CyclingActivity : Activity
{
    //member variables 
    private float _speed;

    //Constructor
    public CyclingActivity(DateTime date, float duration, float speed) : base(date, duration)
    {
        _speed = speed;
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