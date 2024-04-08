class Order
{
    private List<Product> items = new List<Product>();
    private Customer person = new Customer();

    public string givePackLabel()
    {
        string temp = " ";
        foreach (Product I in items)
        {
            temp = ($"{temp} {I.ID}");

        }
        return ($"{person.name} {temp}");
    }

    public string giveShipLabel()
    {
        return ($"{person.name}, {person.getaddress()}");
    }


}