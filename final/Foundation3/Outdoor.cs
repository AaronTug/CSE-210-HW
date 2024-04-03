class Outdoor : Event
{
    private string _weather;
    public Outdoor(string title, string description, string date, string time, string place, string clouds)
    {
        this._title = title;
        this._description = description;
        this._date = date;
        this._time = time;
        this._weather = clouds;
    }
    override public string GetDetails(int choice)
    {
        switch (choice)
        {
            case 1:
                return ($"{_title}, {_description}, {_date}, {_time}, {_address}");
            case 2:
                return ($"{_title}, {_description}, {_date}, {_time}, {_address}\n {_weather}");
            case 3:
                return ($"Outdoor, {_title}, {_date}");
            default:
                return ("Error");
        }

    }

}