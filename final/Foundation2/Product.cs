class Product
{
    private string name;
    private string ID;
    private double unitPrice;
    private int quantity;

    public double getprice()
    {
        return (unitPrice * quantity);
    }

}