using System.Security.Authentication;

class Address
{
    private string streetAdd;
    private string city;
    private string state;
    private string country;

    public Address(string st, string ci, string sta, string count)
    {
        this.streetAdd = st;
        this.city = ci;
        this.state = sta;
        this.country = count;

    }
    public string getAddress()
    {
        return ($"{streetAdd}, {city}, {state}, {country}");
    }
}