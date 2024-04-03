class Outdoor : Event
{
    private string _weather;
    override public string GetDetails(int choice)
    {
        switch (choice)
        {
            case 1:
                return ($"{_title}, {_description}, {_date}, {_time}, {_address}");
            case 2:
                return ($"{_title}, {_description}, {_date}, {_time}, {_address}\n {_weather}");
            case 3:
                return ($"Lecture, {_title}, {_date}");
            default:
                return ("Error");
        }

    }

}