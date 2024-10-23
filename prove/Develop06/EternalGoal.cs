public class EternalGoal : Goal
{
    //Member variables
    //none

    //Constructors
    public EternalGoal (string name, string description, string points) : base (name, description, points)
    {
        //nothing required here
    }

    //Methods
    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }
    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}
