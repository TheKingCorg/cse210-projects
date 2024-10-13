public class Customer
{
    //Member variables
    private string _name;
    private Address _address;

    //Constructors
    public Customer(string name, Address addy)
    {
        _name = name;
        _address = addy;
    }

    //Methods
    public bool ReturnUSResident()
    {
        return _address.GetInUS();
    }
    public string GetAddressText()
    {
        return ($"{_name}\n{_address.GetDisplayText}");
    }
    public string GetNameText()
    {
        return ($"{_name}");
    }
}