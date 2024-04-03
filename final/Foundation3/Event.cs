class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    virtual public string GetDetails(int choice)
    {
        return ("");

    }
    public string GetDescription()
    {
        return ($"{_description}");
    }
}