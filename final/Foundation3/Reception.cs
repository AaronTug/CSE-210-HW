class Reception : Event
{
    private List<string> atendies = new List<string>();
    private string RSVPemail;
    override public string GetDetails(int choice)
    {
        switch (choice)
        {
            case 1:
                return ($"{_title}, {_description}, {_date}, {_time}, {_address}");
            case 2:
                return ($"{_title}, {_description}, {_date}, {_time}, {_address}\n {RSVPemail}");
            case 3:
                return ($"Lecture, {_title}, {_date}");
            default:
                return ("Error");
        }

    }

}