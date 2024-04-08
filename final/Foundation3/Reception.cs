class Reception : Event
{
    private List<string> atendies = new List<string>();
    private string RSVPemail;
    private string place;
    public Reception(string title, string description, string date, string time, string place1, string email)
    {
        this._title = title;
        this._description = description;
        this._date = date;
        this._time = time;
        this.RSVPemail = email;
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
                return ($"{_title}, {_description}, {_date}, {_time}, {_address}\n {RSVPemail}");
            case 3:
                return ($"Reception, {_title}, {_date}");
            default:
                return ("Error");
        }

    }

}