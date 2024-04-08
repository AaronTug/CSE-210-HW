class Customer
{
    public string name;
    public Address Home = new Address();

    public bool InUS()
    {
        return (Home.InUS);
    }
    public string getaddress()
    {
        return ($"{Home.getAddress()}");
    }
}