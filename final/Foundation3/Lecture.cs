class Lecture : Event
{
    private string _speaker;
    private int maxCapacity;
    private string place;

    public Lecture(string title, string description, string date, string time, string place1, string speeker, int Capacity)
    {
        this._title = title;
        this._description = description;
        this._date = date;
        this._time = time;
        this._speaker = speeker;
        this.maxCapacity = Capacity;
        Address Place = new Address(place1);
        place = Place.getplace();
    }
    override public string GetDetails(int choice)
    {
        switch (choice)
        {
            case 1:
                return ($"{_title}, {_description}, {_date}, {_time}, {_address}");
            case 2:
                return ($"{_title}, {_description}, {_date}, {_time}, {_address}\n {_speaker}, {maxCapacity}");
            case 3:
                return ($"Lecture, {_title}, {_date}");
            default:
                return ("Error");
        }

    }

}