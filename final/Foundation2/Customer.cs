class Customer
{
    public string name;
    public Address Home = new Address();

    public string getship()
    {
        return ($"{name}, {Home}");
    }
}