public class Order
{
    //Member variables
    private Customer _customer;
    private List<Product> _products;

    //Constructors
    public Order()
    {

    }

    //Methods
    public string GetShippingLabel()
    {
        return "";
    }
    public string GetPackingLabel()
    {
        return "";
    }
    public string GetTotalCost()
    {
        return "";
    }
}