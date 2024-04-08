class Address
{
    public string place;

    public Address(string here)
    {
        this.place = here;
    }
    public string getplace()
    {
        return ($"{place}");
    }
}