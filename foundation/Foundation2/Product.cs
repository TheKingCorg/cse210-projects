public class Product
{
    //Member variables 
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;

    //constructors
    public Product(string id, string name, double price, int quant)
    {
        _productID = id;
        _name = name;
        _price = price;
        _quantity = quant;
    }

    //methods
    public double GetCost()
    {
        double cost = _price * _quantity;
        return cost;
    }
    public string GetDisplayText()
    {
        string prodInfo = ($"#{_productID} {_name} x{_quantity} @${_price}ea: ${GetCost()}");
        return prodInfo;
    }
}