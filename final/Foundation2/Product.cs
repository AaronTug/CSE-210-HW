class Product
{
    private string name;
    public string ID;
    private double unitPrice;
    private int quantity;

    public Product(string Name, string id, double UnitPrice, int Quantity)
    {
        this.name = Name;
        this.ID = id;
        this.unitPrice = UnitPrice;
        this.quantity = Quantity;
    }

    public double getprice()
    {
        return (unitPrice * quantity);
    }

}