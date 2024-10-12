public class Address
{
    //Member variables
    private string _streetAddr;
    private string _city;
    private string _state;
    private string _country;

    //Constructors
    public Address()
    {
        
    }

    //Methods
    public string GetDisplayText()
    {
        string displayText = ($"");
        return displayText;
    }
    public bool GetInUS()
    {
        return true;
    }
}