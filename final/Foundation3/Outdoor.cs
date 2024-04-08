class Outdoor : Event
{
    private string _weather;
    private string place;
    public Outdoor(string title, string description, string date, string time, string place1, string clouds)
    {
        this._title = title;
        this._description = description;
        this._date = date;
        this._time = time;
        this._weather = clouds;
        Address Place = new Address(place1);
        place = Place.getplace();

    }
    override public string GetDetails(int choice)
    {
        switch (choice)
        {
            case 1:
                return ($"{_title}, {_description}, {_date}, {_time}, {place}");
            case 2:
                return ($"{_title}, {_description}, {_date}, {_time}, {_address}\n {_weather}");
            case 3:
                return ($"Outdoor, {_title}, {_date}");
            default:
                return ("Error");
        }

    }

}