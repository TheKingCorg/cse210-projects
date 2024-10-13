using System;

class Program
{
    static void Main(string[] args)
    {
        //Create our first order
        string person1 = "Tom Hiddleston";
        Address addy1 = new Address("301 NE Smith Rd", "Rexburg", "Idaho", "United States");    //create a usable address class
        Customer tomH = new Customer (person1,addy1);   //create a customer from the above address and name
        //Build their order -- list of products
        List<Product> groceries = new List<Product>();
        Product prod1 = new Product("4644", "tomato", 1.02, 3);
        groceries.Add(prod1);
        Product prod2 = new Product("3011", "banana", 0.84, 8);
        groceries.Add(prod2);
        Product prod3 = new Product("5275", "watermelon", 5.64, 1);
        groceries.Add(prod3);
        Product prod4 = new Product("2078", "garlic", 0.54, 2);
        groceries.Add(prod4);
        //create an order class using this customer and grocery list
        Order order1 = new Order(tomH,groceries);
        
        
        //Create our second order
        string person2 = "Mike Tyson";
        Address addy2 = new Address("420 Knockout Ln", "Montreal", "Quebec", "Canada");    //create a usable address class
        Customer mikeT = new Customer (person2,addy2);   //create a customer from the above address and name
        //Build their order -- list of products
        List<Product> supplies = new List<Product>();
        Product supply1 = new Product("86442987", "protein powder", 45.99, 5);
        supplies.Add(supply1);
        Product supply2 = new Product("9084123", "10lb mallet", 24.56, 1);
        supplies.Add(supply2);
        Product supply3 = new Product("123123095", "skittles", 2.09, 8);
        supplies.Add(supply3);
        //create an order class using this customer and grocery list
        Order order2 = new Order(mikeT,supplies);


        //get the packing label, the shipping label, and the total price of the order
        string spacer = "--------------------------------------------------------------------------------";
        Console.WriteLine($"{order1.GetShippingLabel()}\n{spacer}\n{order1.GetPackingLabel()}\nTotal Cost: ${order1.GetTotalCost()}");
        Console.WriteLine("\n\n");
        Console.WriteLine($"{order2.GetShippingLabel()}\n{spacer}\n{order2.GetPackingLabel()}\nTotal Cost: ${order2.GetTotalCost()}");


    }
}