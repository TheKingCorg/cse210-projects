public class Order
{
    //Member variables
    private Customer _customer;
    private List<Product> _products;

    //Constructors
    public Order(Customer cust, List<Product> products)
    {
        _customer = cust;
        _products = products;
    }

    //Methods
    public string GetShippingLabel()
    {
        string shippingLabel = ($"{_customer.GetAddressText()}");
        return shippingLabel;
    }

    public string GetPackingLabel()
    {
        string packingLabel = ($"{_customer.GetNameText()}");
        foreach(Product indProd in _products)
        {
            packingLabel += ($"\n{indProd.GetDisplayText()}");
        }
        return packingLabel;
    }

    public string GetTotalCost()
    {
        double totalCost;
        totalCost = 0;
        foreach (Product indProd in _products)
        {
            double tempCost = indProd.GetCost();
            totalCost += tempCost;
        }
        if (_customer.ReturnUSResident())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost.ToString();
    }
}