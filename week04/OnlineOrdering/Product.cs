public class Product
{
    public Product(string name, int ID, double price, int quantity)
    {
         _productName = name;
        _productID = ID;
        _price = price;
        _quantity = quantity;
    }
    public Product()
    {
        _productName = "";
        _productID = 0;
        _price = 0;
        _quantity = 0;
    }
    private string _productName;
    private int _productID;
    private double _price;
    private int _quantity;
    public double GetRawValue()
    {
        double rawValue = _price * _quantity;
        return rawValue;
    }
    public string GetNameID()
    {
        string returned = $"{_productName} : {_productID}";
        return returned;
    }
}