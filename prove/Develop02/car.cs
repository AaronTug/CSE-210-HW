class Car
{
    public string model;
    public string make;
    public int MPG;
    public int gallons;

    public int TotalRange()
    {
        return gallons * MPG;
    }
}