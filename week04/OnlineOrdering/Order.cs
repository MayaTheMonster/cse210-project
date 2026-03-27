using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

public class Order
{
    public Order(string client)
    {
        _customer = client;
    }
    Customer customer =  new Customer();
    private List<Product> _Products = new List<Product>();
    private string _customer;
    private void CalculateTotalCost(bool CountryIsUS)
    {
        double total = 35;
        if(CountryIsUS == true)
        {
            total = 5; 
        }

        foreach (Product grocery in _Products)
        {
            total += grocery.GetRawValue();
        }
        Console.WriteLine($"Your total is: {total}");
    }
    public void CheckoutGroceries()
    {
        bool unitedStates = customer.livesOnUs();
        CalculateTotalCost(unitedStates);
    }
    public void GetOrderDetails(string street, string city, string estate, string country)
    {
        customer =  new Customer(_customer);
        customer.CustomerToAdress(street,city,estate,country);
    }
    public void GetOrderProducts(string name,int ID,double price,int quantity)
    {
        Product groceries = new Product(name,ID,price,quantity);
        _Products.Add(groceries);
    }
    public void ReturnPackingLabel()
    {
        Console.WriteLine("Packing label:");
        foreach (Product grocery in _Products)
        {
            string nameID = grocery.GetNameID();
            Console.WriteLine(nameID);
        }
    }

    public void ReturnShippingLabel()
    {
        string customerAdress = customer.CallAdress();
        Console.WriteLine("Shipping label:");
        Console.Write($"customer: {_customer} ");
        Console.WriteLine($"address:\n{customerAdress}");
    }
}