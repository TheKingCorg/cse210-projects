public class Address
{
    //Member variables
    private string _streetAddr;
    private string _city;
    private string _state;
    private string _country;

    //Constructors
    public Address(string street, string city, string state, string country)
    {
        _streetAddr = street;
        _city = city;
        _state = state;
        _country = country;
    }

    //Methods
    public string GetDisplayText()
    {
        string displayText = ($"{_streetAddr}\n{_city}, {_state}, {_country}");
        return displayText;
    }
    public bool GetInUS()
    {
        bool inUS;
        if (_country == "United States")
            inUS = true;
        else
            inUS = false;
        return inUS;
    }
}