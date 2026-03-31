using System.Collections.Concurrent;
using System.Dynamic;
using Microsoft.VisualBasic;

public class Customer
{
    private Address userAddress = new Address();
    public Customer(string info)
    {
        _customer = info;
    }
    public Customer()
    {
        _customer = "";
    }
    private string _customer;
    public void CustomerToAdress(string street, string city, string estate, string country)
    {
        userAddress = new Address(street,city,estate,country);
    }
    
    public string CallAdress()
    {
        string wantedValue = userAddress.StringAdress();
        return wantedValue;
    }
    public bool livesOnUs()
    {
        bool country = userAddress.ReturnIfCountryIsUS();
        
        return country;
    }
}